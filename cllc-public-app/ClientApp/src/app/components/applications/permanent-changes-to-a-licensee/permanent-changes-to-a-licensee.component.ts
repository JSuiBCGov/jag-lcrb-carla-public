import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute, Router } from '@angular/router';
import { AppState } from '@app/app-state/models/app-state';
import { UPLOAD_FILES_MODE } from '@components/licences/licences.component';
import { Account } from '@models/account.model';
import { ApplicationLicenseSummary } from '@models/application-license-summary.model';
import { Application } from '@models/application.model';
import { Store } from '@ngrx/store';
import { ApplicationDataService } from '@services/application-data.service';
import { PaymentDataService } from '@services/payment-data.service';
import { FormBase } from '@shared/form-base';
import { Observable, of, forkJoin, merge, combineLatest } from 'rxjs';
import { catchError, delay, filter, mergeMap, takeWhile } from 'rxjs/operators';

@Component({
  selector: 'app-permanent-changes-to-a-licensee',
  templateUrl: './permanent-changes-to-a-licensee.component.html',
  styleUrls: ['./permanent-changes-to-a-licensee.component.scss']
})
export class PermanentChangesToALicenseeComponent extends FormBase implements OnInit {
  value: any; // placeholder prop
  application: Application;
  liquorLicences: ApplicationLicenseSummary[] = [];
  cannabisLicences: ApplicationLicenseSummary[] = [];
  account: Account;
  businessType: string;
  saveComplete: any;
  submitApplicationInProgress: boolean;
  proceedToSecurityScreeningInProgress: boolean;
  busyPromise: Promise<void>;
  showValidationMessages: boolean;
  savedFormData: any;
  invoiceType: any;
  dataLoaded: boolean;

  get hasLiquor(): boolean {
    return this.liquorLicences.length > 0;
  }

  get hasCannabis(): boolean {
    return this.cannabisLicences.length > 0;
  }

  changeList = [];
  form: FormGroup;

  constructor(private applicationDataService: ApplicationDataService,
    private paymentDataService: PaymentDataService,
    private router: Router,
    private route: ActivatedRoute,
    private snackBar: MatSnackBar,
    private fb: FormBuilder,
    private store: Store<AppState>) {
    super();
    this.store.select(state => state.currentAccountState.currentAccount)
      .pipe(filter(account => !!account))
      .subscribe(account => {
        this.account = account;
        this.changeList = masterChangeList.filter(item => !!item.availableTo.find(bt => bt === account.businessType));
      });

    combineLatest([this.route.paramMap, route.queryParams])
      .subscribe(([pmap, { trnId, SessionKey }]) => {
        this.invoiceType = pmap.get('invoiceType');
      });
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      csInternalTransferOfShares: [''],
      csExternalTransferOfShares: [''],
      csChangeOfDirectorsOrOfficers: [''],
      csNameChangeLicenseeCorporation: [''],
      csNameChangeLicenseePartnership: [''],
      csNameChangeLicenseeSociety: [''],
      csNameChangeLicenseePerson: [''],
      csAdditionalReceiverOrExecutor: [''],
      firstNameOld: [''],
      firstNameNew: [''],
      lastNameOld: [''],
      lastNameNew: [''],
      description2: [''],
      description3: [''],
    });

    this.applicationDataService.getPermanentChangesToLicenseeData()
      .subscribe(({ application, licences }) => {
        this.liquorLicences = licences.filter(item => item.licenceTypeCategory === 'Liquor');
        this.cannabisLicences = licences.filter(item => item.licenceTypeCategory === 'Cannabis');
        this.application = application;
        if ((this.invoiceType === 'primary' && !this.application.primaryInvoicePaid) ||
          (this.invoiceType === 'secondary' && !this.application.secondaryInvoicePaid)) {
          this.paymentDataService.verifyPaymentURI(this.invoiceType + 'Invoice', this.application.id)
            .subscribe(res => {
              this.dataLoaded = true;
              debugger;
            });
        }else{
          this.dataLoaded = true;
        }
        debugger;
        if (this.application.primaryInvoicePaid || this.application.secondaryInvoicePaid) {
          this.form.disable();
        }
        this.form.patchValue(application);
      });

  }

  /**
 * Save form data
 * @param showProgress
 */
  save(showProgress: boolean = false, appData: Application = <Application>{}): Observable<[boolean, Application]> {
    const saveData = this.form.value;

    return this.applicationDataService.updateApplication({
      ...this.application,
      ...this.form.value,
      ...appData
    })
      .pipe(takeWhile(() => this.componentActive))
      .pipe(catchError(() => {
        this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        const res: [boolean, Application] = [false, null];
        return of(res);
      }))
      .pipe(mergeMap((data) => {
        if (showProgress === true) {
          this.snackBar.open('Application has been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
        }
        const res: [boolean, Application] = [true, <Application>data];
        return of(res);
      }));
  }

  isValid(): boolean {
    return true;
  }

  /**
   * Submit the application for payment
   * */
  submit_application(invoiceType: 'primary' | 'secondary') {

    // Only save if the data is valid
    if (this.isValid()) {
      this.submitApplicationInProgress = true;
      this.save(!this.application.applicationType.isFree, <Application>{ invoiceTrigger: 1 }) // trigger invoice generation when saving
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(([saveSucceeded, app]) => {
          if (saveSucceeded) {
            // payment is required
            if (app) {
              this.submitPayment(invoiceType)
                .subscribe(res => {
                  this.saveComplete.emit(true);
                  this.submitApplicationInProgress = false;
                });
            }
            // else if (app) {
            //   // mark application as complete
            //   this.save(!this.application.applicationType.isFree, <Application>{ isApplicationComplete: 'Yes' })
            //     .subscribe(res => {
            //       this.saveComplete.emit(true);
            //       // however we need to redirect if the application is Free
            //       if (this.application.applicationType.isFree) {
            //         this.snackBar.open('Application submitted', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
            //         this.router.navigateByUrl('/dashboard');
            //       }
            //     });
            // }
          } else if (this.application.applicationType.isFree) { // show error message the save failed and the application is free
            this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
            this.submitApplicationInProgress = false;
          }
        });
    } else {
      this.showValidationMessages = true;
    }
  }


  private proceedToSecurityScreening() {
    //send event to move to the next step of the multi-step
    if (this.isValid()) { // Only proceed if the data is valid
      this.proceedToSecurityScreeningInProgress = true;
      this.busyPromise = this.save(true)
        .toPromise()
        .then(([saveSucceeded, app]) => {
          this.proceedToSecurityScreeningInProgress = false;
          if (saveSucceeded) {
            this.saveComplete.next(true);
          } else {
            this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          }
        });
    } else {
      this.showValidationMessages = true;
    }
  }

  /**
   * Redirect to payment processing page (Express Pay / Bambora service)
   * */
  private submitPayment(invoiceType: 'primary' | 'secondary') {
    debugger;
    let payMethod = this.paymentDataService.getPaymentURI('primaryInvoice', this.application.id);
    if (invoiceType === 'secondary') {
      payMethod = this.paymentDataService.getPaymentURI('secondaryInvoice', this.application.id);
    }
    return payMethod
      .pipe(takeWhile(() => this.componentActive))
      .pipe(mergeMap(jsonUrl => {
        debugger;
        window.location.href = jsonUrl['url'];
        return jsonUrl['url'];
      }, (err: any) => {
        if (err._body === 'Payment already made') {
          this.snackBar.open('Application payment has already been made.', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        }
      }));
  }

}

const masterChangeList = [
  {
    name: 'Internal Transfer of Shares',
    formControlName: 'csInternalTransferOfShares',
    availableTo: ['PrivateCorporation', 'LimitedLiabilityPartnership'],
    CannabisFee: 110,
    LiquorFee: 110,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['When shares or partnership units are redistributed between existing sharesholders/unit holders',
      'Removal of shareholders/unit holders',
      'Amalgamations that do not add new shareholders or legal entities to the licensee coroporation',
      'Third party operators should also complete this section when an internal share transfer or an amalgamation occurs'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'External Transfer of Shares',
    formControlName: 'csExternalTransferOfShares',
    availableTo: ['PrivateCorporation', 'LimitedLiabilityPartnership'],
    CannabisFee: 330,
    LiquorFee: 330,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['when new shareholders have been added (companies or individuals) to the licensee corporation or holding companies as a result of a transfer of existing shares or the issuance of new shares',
      'Third party operators should also complete this section when an external transfer occurs'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'Change of Directors or Officers',
    formControlName: 'csChangeOfDirectorsOrOfficers',
    availableTo: ['PrivateCorporation', 'PublicCorporation', 'Society'],
    CannabisFee: 550,
    LiquorFee: 220,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['When there are changes in directors or officers of a public corporation or society within the licensee legal entity'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'Name Change, Licensee -- Corporation',
    formControlName: 'csNameChangeLicenseeCorporation',
    availableTo: ['PrivateCorporation', 'PublicCorporation'],
    CannabisFee: 500,
    LiquorFee: 500,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['When a corporation with an interest in a licence has legally changed its name, but existing corporate shareholders, directors and officers, and certificate number on the certificate of incorporation have not changed'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'Name Change, Licensee -- Partnership',
    formControlName: 'csNameChangeLicenseePartnership',
    availableTo: ['GeneralPartnership', 'LimitedLiabilityPartnership'],
    CannabisFee: 220,
    LiquorFee: 220,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['When the legal name of a partnership is changed but no new partners are added and no existing partners'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',

  },
  {
    name: 'Name Change, Licensee -- Society',
    formControlName: 'csNameChangeLicenseeSociety',
    availableTo: ['Society'],
    CannabisFee: 220,
    LiquorFee: 220,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['When the legal name of a society is changed, but the society structure, membership and certification number on the certificate of incorporation does not change'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'Name Change, Person',
    formControlName: 'csNameChangeLicenseePerson',
    availableTo: ['PrivateCorporation', 'PublicCorporation', 'GeneralPartnership',
      'LimitedLiabilityPartnership', 'IndigenousNation', 'LocalGovernment', 'Society'],
    CannabisFee: 220,
    LiquorFee: 220,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['when a person holding an interest in a licence has legally changed their name'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  },
  {
    name: 'Addition of Receiver or Executor',
    formControlName: 'csAdditionalReceiverOrExecutor',
    availableTo: ['PrivateCorporation', 'PublicCorporation', 'GeneralPartnership',
      'LimitedLiabilityPartnership', 'Society'],
    CannabisFee: 220,
    LiquorFee: 220,
    RequiresPHS: false,
    RequiresCAS: false,
    helpTextHeader: 'Use this option to report:',
    helpText: ['upon the death, bankruptcy or receivership of a licensee'
    ],
    helpTextLink: 'https://www2.gov.bc.ca/gov/content/employment-business/business/liquor-regulation-licensing/liquor-licences-permits/changing-a-liquor-licence',
  }
];
