// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.invoicedetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvoicedetail
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoicedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoicedetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoicedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoicedetail(string shiptoName = default(string), string productassociationid = default(string), string _owningbusinessunitValue = default(string), string parentbundleid = default(string), bool? isproductoverridden = default(bool?), decimal? tax = default(decimal?), decimal? baseamountBase = default(decimal?), int? skippricecalculation = default(int?), string _owningteamValue = default(string), string shiptoCountry = default(string), string invoicedetailname = default(string), bool? willcall = default(bool?), string shiptoLine1 = default(string), string _parentbundleidrefValue = default(string), decimal? extendedamount = default(decimal?), int? timezoneruleversionnumber = default(int?), string shiptoTelephone = default(string), decimal? volumediscountamount = default(decimal?), string invoicedetailid = default(string), decimal? manualdiscountamountBase = default(decimal?), string _modifiedbyValue = default(string), decimal? quantityshipped = default(decimal?), int? shiptoFreighttermscode = default(int?), decimal? baseamount = default(decimal?), string productdescription = default(string), string _invoiceidValue = default(string), string _salesorderdetailidValue = default(string), string shiptoLine3 = default(string), int? lineitemnumber = default(int?), decimal? volumediscountamountBase = default(decimal?), string productnumber = default(string), decimal? priceperunit = default(decimal?), decimal? extendedamountBase = default(decimal?), bool? ispriceoverridden = default(bool?), System.DateTimeOffset? actualdeliveryon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string shiptoFax = default(string), string shiptoCity = default(string), string _owneridValue = default(string), string _uomidValue = default(string), string shiptoLine2 = default(string), decimal? taxBase = default(decimal?), bool? iscopied = default(bool?), string productname = default(string), decimal? quantitybackordered = default(decimal?), string _productidValue = default(string), int? producttypecode = default(int?), string description = default(string), string _modifiedonbehalfbyValue = default(string), decimal? quantity = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _salesrepidValue = default(string), int? propertyconfigurationstatus = default(int?), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? sequencenumber = default(int?), decimal? priceperunitBase = default(decimal?), string shiptoStateorprovince = default(string), int? importsequencenumber = default(int?), decimal? manualdiscountamount = default(decimal?), decimal? exchangerate = default(decimal?), string owninguser = default(string), bool? invoiceispricelocked = default(bool?), int? pricingerrorcode = default(int?), string versionnumber = default(string), string shippingtrackingnumber = default(string), decimal? quantitycancelled = default(decimal?), int? utcconversiontimezonecode = default(int?), int? invoicestatecode = default(int?), string shiptoPostalcode = default(string), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMteam> invoicedetailTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> invoicedetailMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> invoiceDetailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> invoicedetailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> invoiceDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMsystemuser salesrepid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> invoiceDetailDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMsyncerror> invoiceDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> invoiceDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMinvoice invoiceid = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMinvoicedetail parentbundleidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), IList<MicrosoftDynamicsCRMinvoicedetail> invoicedetailParentInvoicedetail = default(IList<MicrosoftDynamicsCRMinvoicedetail>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMinvoicedetail parentbundleidrefInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), IList<MicrosoftDynamicsCRMinvoicedetail> invoicedetailParentrefInvoicedetail = default(IList<MicrosoftDynamicsCRMinvoicedetail>), MicrosoftDynamicsCRMsalesorderdetail salesOrderDetailId = default(MicrosoftDynamicsCRMsalesorderdetail))
        {
            ShiptoName = shiptoName;
            Productassociationid = productassociationid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Parentbundleid = parentbundleid;
            Isproductoverridden = isproductoverridden;
            Tax = tax;
            BaseamountBase = baseamountBase;
            Skippricecalculation = skippricecalculation;
            this._owningteamValue = _owningteamValue;
            ShiptoCountry = shiptoCountry;
            Invoicedetailname = invoicedetailname;
            Willcall = willcall;
            ShiptoLine1 = shiptoLine1;
            this._parentbundleidrefValue = _parentbundleidrefValue;
            Extendedamount = extendedamount;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            ShiptoTelephone = shiptoTelephone;
            Volumediscountamount = volumediscountamount;
            Invoicedetailid = invoicedetailid;
            ManualdiscountamountBase = manualdiscountamountBase;
            this._modifiedbyValue = _modifiedbyValue;
            Quantityshipped = quantityshipped;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Baseamount = baseamount;
            Productdescription = productdescription;
            this._invoiceidValue = _invoiceidValue;
            this._salesorderdetailidValue = _salesorderdetailidValue;
            ShiptoLine3 = shiptoLine3;
            Lineitemnumber = lineitemnumber;
            VolumediscountamountBase = volumediscountamountBase;
            Productnumber = productnumber;
            Priceperunit = priceperunit;
            ExtendedamountBase = extendedamountBase;
            Ispriceoverridden = ispriceoverridden;
            Actualdeliveryon = actualdeliveryon;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            ShiptoFax = shiptoFax;
            ShiptoCity = shiptoCity;
            this._owneridValue = _owneridValue;
            this._uomidValue = _uomidValue;
            ShiptoLine2 = shiptoLine2;
            TaxBase = taxBase;
            Iscopied = iscopied;
            Productname = productname;
            Quantitybackordered = quantitybackordered;
            this._productidValue = _productidValue;
            Producttypecode = producttypecode;
            Description = description;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Quantity = quantity;
            Overriddencreatedon = overriddencreatedon;
            Modifiedon = modifiedon;
            this._salesrepidValue = _salesrepidValue;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdon = createdon;
            Sequencenumber = sequencenumber;
            PriceperunitBase = priceperunitBase;
            ShiptoStateorprovince = shiptoStateorprovince;
            Importsequencenumber = importsequencenumber;
            Manualdiscountamount = manualdiscountamount;
            Exchangerate = exchangerate;
            Owninguser = owninguser;
            Invoiceispricelocked = invoiceispricelocked;
            Pricingerrorcode = pricingerrorcode;
            Versionnumber = versionnumber;
            Shippingtrackingnumber = shippingtrackingnumber;
            Quantitycancelled = quantitycancelled;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Invoicestatecode = invoicestatecode;
            ShiptoPostalcode = shiptoPostalcode;
            Owningteam = owningteam;
            InvoicedetailTeams = invoicedetailTeams;
            InvoicedetailMailboxTrackingFolders = invoicedetailMailboxTrackingFolders;
            InvoiceDetailProcessSessions = invoiceDetailProcessSessions;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            InvoicedetailPrincipalobjectattributeaccess = invoicedetailPrincipalobjectattributeaccess;
            Modifiedonbehalfby = modifiedonbehalfby;
            InvoiceDetailBulkDeleteFailures = invoiceDetailBulkDeleteFailures;
            Uomid = uomid;
            Salesrepid = salesrepid;
            Productid = productid;
            InvoiceDetailDynamicpropertyinstance = invoiceDetailDynamicpropertyinstance;
            InvoiceDetailSyncErrors = invoiceDetailSyncErrors;
            InvoiceDetailAsyncOperations = invoiceDetailAsyncOperations;
            Invoiceid = invoiceid;
            ParentbundleidInvoicedetail = parentbundleidInvoicedetail;
            InvoicedetailParentInvoicedetail = invoicedetailParentInvoicedetail;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            ParentbundleidrefInvoicedetail = parentbundleidrefInvoicedetail;
            InvoicedetailParentrefInvoicedetail = invoicedetailParentrefInvoicedetail;
            SalesOrderDetailId = salesOrderDetailId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public decimal? BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skippricecalculation")]
        public int? Skippricecalculation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetailname")]
        public string Invoicedetailname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentbundleidref_value")]
        public string _parentbundleidrefValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public decimal? Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public decimal? Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetailid")]
        public string Invoicedetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public decimal? ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityshipped")]
        public decimal? Quantityshipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public decimal? Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_invoiceid_value")]
        public string _invoiceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderdetailid_value")]
        public string _salesorderdetailidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public decimal? VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public decimal? Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public decimal? ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualdeliveryon")]
        public System.DateTimeOffset? Actualdeliveryon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public decimal? TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscopied")]
        public bool? Iscopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productname")]
        public string Productname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitybackordered")]
        public decimal? Quantitybackordered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesrepid_value")]
        public string _salesrepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public decimal? PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public decimal? Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceispricelocked")]
        public bool? Invoiceispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingtrackingnumber")]
        public string Shippingtrackingnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitycancelled")]
        public decimal? Quantitycancelled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicestatecode")]
        public int? Invoicestatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_Teams")]
        public IList<MicrosoftDynamicsCRMteam> InvoicedetailTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> InvoicedetailMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> InvoiceDetailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> InvoicedetailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> InvoiceDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesrepid")]
        public MicrosoftDynamicsCRMsystemuser Salesrepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> InvoiceDetailDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> InvoiceDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> InvoiceDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public MicrosoftDynamicsCRMinvoice Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail ParentbundleidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_parent_invoicedetail")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> InvoicedetailParentInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleidref_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail ParentbundleidrefInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_parentref_invoicedetail")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> InvoicedetailParentrefInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrderDetailId")]
        public MicrosoftDynamicsCRMsalesorderdetail SalesOrderDetailId { get; set; }

    }
}
