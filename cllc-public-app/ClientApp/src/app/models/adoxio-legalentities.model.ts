import { DynamicsAccount } from './dynamics-account.model';

export class AdoxioLegalEntity {
  
  id: string; // guid
  name: string;
  isindividual: boolean;
  sameasapplyingperson: boolean;
  legalentitytype: string;
  otherlegalentitytype: string;
  firstname: string;
  middlename: string;
  lastname: string;
  isOfficer: boolean;
  isDirector: boolean;
  isSeniorManagement: boolean;
  isShareholder: boolean;
  isPartner: boolean;
  dateofbirth: Date;
  interestpercentage: number;
  commonvotingshares: number;
  preferredvotingshares: number;
  commonnonvotingshares: number;
  preferrednonvotingshares: number;
  account: DynamicsAccount;
  relatedentities: AdoxioLegalEntity[];
  email: string;
  dateofappointment: Date; //adoxio_dateofappointment
  accountId: string;
  // helper fields
  shareholderType: string;
  sendConsentRequest: boolean;
  parentLegalEntityId: string;
  position: string;

}
