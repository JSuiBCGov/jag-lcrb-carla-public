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
    /// Microsoft.Dynamics.CRM.dynamicpropertyinstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance(string dynamicpropertyinstanceid = default(string), int? timezoneruleversionnumber = default(int?), decimal? valuedecimal = default(decimal?), string _transactioncurrencyidValue = default(string), string name = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? validationstatus = default(bool?), string _owneridValue = default(string), string _createdonbehalfbyValue = default(string), int? dmtimportstate = default(int?), string valuestring = default(string), int? utcconversiontimezonecode = default(int?), decimal? valuedouble = default(decimal?), string versionnumber = default(string), int? valueinteger = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _dynamicpropertyidValue = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), decimal? exchangerate = default(decimal?), IList<MicrosoftDynamicsCRMsyncerror> dynamicpropertyinstanceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMteam> dynamicpropertyinstanceTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> dynamicpropertyinstanceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> dynamicpropertyinstanceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> dynamicpropertyinstanceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> dynamicpropertyinstancePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMquotedetail regardingobjectidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), MicrosoftDynamicsCRMinvoicedetail regardingobjectidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), MicrosoftDynamicsCRMopportunityproduct regardingobjectidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), MicrosoftDynamicsCRMsalesorderdetail regardingobjectidSalesorderdetail = default(MicrosoftDynamicsCRMsalesorderdetail))
        {
            Dynamicpropertyinstanceid = dynamicpropertyinstanceid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Valuedecimal = valuedecimal;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Name = name;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Validationstatus = validationstatus;
            this._owneridValue = _owneridValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Dmtimportstate = dmtimportstate;
            Valuestring = valuestring;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Valuedouble = valuedouble;
            Versionnumber = versionnumber;
            Valueinteger = valueinteger;
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Modifiedon = modifiedon;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            Exchangerate = exchangerate;
            DynamicpropertyinstanceSyncErrors = dynamicpropertyinstanceSyncErrors;
            DynamicpropertyinstanceTeams = dynamicpropertyinstanceTeams;
            DynamicpropertyinstanceAsyncOperations = dynamicpropertyinstanceAsyncOperations;
            DynamicpropertyinstanceMailboxTrackingFolders = dynamicpropertyinstanceMailboxTrackingFolders;
            DynamicpropertyinstanceBulkDeleteFailures = dynamicpropertyinstanceBulkDeleteFailures;
            DynamicpropertyinstancePrincipalObjectAttributeAccesses = dynamicpropertyinstancePrincipalObjectAttributeAccesses;
            Createdby = createdby;
            Dynamicpropertyid = dynamicpropertyid;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            Ownerid = ownerid;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            Owninguser = owninguser;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedonbehalfby = modifiedonbehalfby;
            RegardingobjectidQuotedetail = regardingobjectidQuotedetail;
            RegardingobjectidInvoicedetail = regardingobjectidInvoicedetail;
            RegardingobjectidOpportunityproduct = regardingobjectidOpportunityproduct;
            RegardingobjectidSalesorderdetail = regardingobjectidSalesorderdetail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstanceid")]
        public string Dynamicpropertyinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedecimal")]
        public decimal? Valuedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationstatus")]
        public bool? Validationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuestring")]
        public string Valuestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedouble")]
        public decimal? Valuedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueinteger")]
        public int? Valueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public string _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DynamicpropertyinstanceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_Teams")]
        public IList<MicrosoftDynamicsCRMteam> DynamicpropertyinstanceTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DynamicpropertyinstanceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DynamicpropertyinstanceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DynamicpropertyinstanceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DynamicpropertyinstancePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail RegardingobjectidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail RegardingobjectidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct RegardingobjectidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorderdetail")]
        public MicrosoftDynamicsCRMsalesorderdetail RegardingobjectidSalesorderdetail { get; set; }

    }
}
