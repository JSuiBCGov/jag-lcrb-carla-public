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

    public partial class MicrosoftDynamicsCRMadoxioPersonalhistorysummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPersonalhistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPersonalhistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary(string adoxioBirthlastname = default(string), int? statuscode = default(int?), string adoxioBirthfirstname = default(string), string adoxioLicenceorjobnumber = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioLegalentityname = default(int?), string adoxioName = default(string), string adoxioMiddlename = default(string), object adoxioExpirydate = default(object), string adoxioPhonenumber = default(string), string _adoxioWorkeridValue = default(string), int? adoxioGender = default(int?), int? adoxioComplete = default(int?), string _owningteamValue = default(string), string _adoxioLegalentityidValue = default(string), string adoxioPersonalhistorysummaryid = default(string), string adoxioResidenceaddresspostalcode = default(string), string versionnumber = default(string), string _adoxioApplicationidValue = default(string), int? timezoneruleversionnumber = default(int?), string adoxioBirthmiddlename = default(string), string adoxioOtherlastnames = default(string), string adoxioFullname = default(string), string _adoxioContactidValue = default(string), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string adoxioEstablishmentparcelid = default(string), string _owningbusinessunitValue = default(string), int? adoxioSecuritystatus = default(int?), string adoxioDriverslicencenumber = default(string), string _createdbyValue = default(string), string adoxioEstablishmentname = default(string), object overriddencreatedon = default(object), string adoxioResidenceaddresscity = default(string), string adoxioWorkerjobnumber = default(string), int? statecode = default(int?), string adoxioFirstname = default(string), string adoxioResidenceaddressstreet = default(string), string _modifiedbyValue = default(string), bool? adoxioSameasapplyingperson = default(bool?), object modifiedon = default(object), int? utcconversiontimezonecode = default(int?), object adoxioBirthdate = default(object), string adoxioAssociatejobnumber = default(string), object createdon = default(object), string adoxioLastname = default(string), string adoxioEmail = default(string), object adoxioCompletedon = default(object), string _owninguserValue = default(string), string _owneridValue = default(string), string adoxioResidenceaddressprovincecountry = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioPersonalhistorysummarySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPersonalhistorysummaryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPersonalhistorysummaryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioPersonalhistorysummarySharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPersonalhistorysummaryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPersonalhistorysummaryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioApplication adoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication), IList<MicrosoftDynamicsCRMadoxioLegalentity> adoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary = default(IList<MicrosoftDynamicsCRMadoxioLegalentity>), MicrosoftDynamicsCRMcontact adoxioContactid = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioWorker adoxioWorkerId = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityId = default(MicrosoftDynamicsCRMadoxioLegalentity))
        {
            AdoxioBirthlastname = adoxioBirthlastname;
            Statuscode = statuscode;
            AdoxioBirthfirstname = adoxioBirthfirstname;
            AdoxioLicenceorjobnumber = adoxioLicenceorjobnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioLegalentityname = adoxioLegalentityname;
            AdoxioName = adoxioName;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioExpirydate = adoxioExpirydate;
            AdoxioPhonenumber = adoxioPhonenumber;
            this._adoxioWorkeridValue = _adoxioWorkeridValue;
            AdoxioGender = adoxioGender;
            AdoxioComplete = adoxioComplete;
            this._owningteamValue = _owningteamValue;
            this._adoxioLegalentityidValue = _adoxioLegalentityidValue;
            AdoxioPersonalhistorysummaryid = adoxioPersonalhistorysummaryid;
            AdoxioResidenceaddresspostalcode = adoxioResidenceaddresspostalcode;
            Versionnumber = versionnumber;
            this._adoxioApplicationidValue = _adoxioApplicationidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioBirthmiddlename = adoxioBirthmiddlename;
            AdoxioOtherlastnames = adoxioOtherlastnames;
            AdoxioFullname = adoxioFullname;
            this._adoxioContactidValue = _adoxioContactidValue;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioEstablishmentparcelid = adoxioEstablishmentparcelid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioSecuritystatus = adoxioSecuritystatus;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            this._createdbyValue = _createdbyValue;
            AdoxioEstablishmentname = adoxioEstablishmentname;
            Overriddencreatedon = overriddencreatedon;
            AdoxioResidenceaddresscity = adoxioResidenceaddresscity;
            AdoxioWorkerjobnumber = adoxioWorkerjobnumber;
            Statecode = statecode;
            AdoxioFirstname = adoxioFirstname;
            AdoxioResidenceaddressstreet = adoxioResidenceaddressstreet;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioSameasapplyingperson = adoxioSameasapplyingperson;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioBirthdate = adoxioBirthdate;
            AdoxioAssociatejobnumber = adoxioAssociatejobnumber;
            Createdon = createdon;
            AdoxioLastname = adoxioLastname;
            AdoxioEmail = adoxioEmail;
            AdoxioCompletedon = adoxioCompletedon;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            AdoxioResidenceaddressprovincecountry = adoxioResidenceaddressprovincecountry;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioPersonalhistorysummarySyncErrors = adoxioPersonalhistorysummarySyncErrors;
            AdoxioPersonalhistorysummaryDuplicateMatchingRecord = adoxioPersonalhistorysummaryDuplicateMatchingRecord;
            AdoxioPersonalhistorysummaryDuplicateBaseRecord = adoxioPersonalhistorysummaryDuplicateBaseRecord;
            AdoxioPersonalhistorysummarySharePointDocumentLocations = adoxioPersonalhistorysummarySharePointDocumentLocations;
            AdoxioPersonalhistorysummaryAsyncOperations = adoxioPersonalhistorysummaryAsyncOperations;
            AdoxioPersonalhistorysummaryBulkDeleteFailures = adoxioPersonalhistorysummaryBulkDeleteFailures;
            AdoxioApplicationid = adoxioApplicationid;
            AdoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary = adoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary;
            AdoxioContactid = adoxioContactid;
            AdoxioWorkerId = adoxioWorkerId;
            AdoxioLegalEntityId = adoxioLegalEntityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthlastname")]
        public string AdoxioBirthlastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthfirstname")]
        public string AdoxioBirthfirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenceorjobnumber")]
        public string AdoxioLicenceorjobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentityname")]
        public int? AdoxioLegalentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_expirydate")]
        public object AdoxioExpirydate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_workerid_value")]
        public string _adoxioWorkeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gender")]
        public int? AdoxioGender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complete")]
        public int? AdoxioComplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityid_value")]
        public string _adoxioLegalentityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummaryid")]
        public string AdoxioPersonalhistorysummaryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddresspostalcode")]
        public string AdoxioResidenceaddresspostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationid_value")]
        public string _adoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthmiddlename")]
        public string AdoxioBirthmiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otherlastnames")]
        public string AdoxioOtherlastnames { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fullname")]
        public string AdoxioFullname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentparcelid")]
        public string AdoxioEstablishmentparcelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_securitystatus")]
        public int? AdoxioSecuritystatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentname")]
        public string AdoxioEstablishmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddresscity")]
        public string AdoxioResidenceaddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerjobnumber")]
        public string AdoxioWorkerjobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddressstreet")]
        public string AdoxioResidenceaddressstreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameasapplyingperson")]
        public bool? AdoxioSameasapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthdate")]
        public object AdoxioBirthdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associatejobnumber")]
        public string AdoxioAssociatejobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_completedon")]
        public object AdoxioCompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddressprovincecountry")]
        public string AdoxioResidenceaddressprovincecountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPersonalhistorysummarySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPersonalhistorysummaryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPersonalhistorysummaryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioPersonalhistorysummarySharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPersonalhistorysummaryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPersonalhistorysummaryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_personalhistorysummary_adoxio_legalentity_CorrespondingPersonalHistorySummary")]
        public IList<MicrosoftDynamicsCRMadoxioLegalentity> AdoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactid")]
        public MicrosoftDynamicsCRMcontact AdoxioContactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_WorkerId")]
        public MicrosoftDynamicsCRMadoxioWorker AdoxioWorkerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityId")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityId { get; set; }

    }
}
