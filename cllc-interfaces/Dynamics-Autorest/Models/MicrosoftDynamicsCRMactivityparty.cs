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
    /// Microsoft.Dynamics.CRM.activityparty
    /// </summary>
    public partial class MicrosoftDynamicsCRMactivityparty
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactivityparty
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMactivityparty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactivityparty
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMactivityparty(string addressused = default(string), bool? donotphone = default(bool?), bool? donotpostalmail = default(bool?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), bool? donotfax = default(bool?), bool? ispartydeleted = default(bool?), string _activityidValue = default(string), int? participationtypemask = default(int?), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), int? instancetypecode = default(int?), string versionnumber = default(string), int? addressusedemailcolumnnumber = default(int?), string _resourcespecidValue = default(string), decimal? effort = default(decimal?), string _partyidValue = default(string), string exchangeentryid = default(string), string activitypartyid = default(string), bool? donotemail = default(bool?), string _owneridValue = default(string), MicrosoftDynamicsCRMabsScheduledprocessexecution activityidAbsScheduledprocessexecutionActivityparty = default(MicrosoftDynamicsCRMabsScheduledprocessexecution), MicrosoftDynamicsCRMadoxioApplication partyidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLicences partyidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMentitlement partyidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMadoxioEvent partyidAdoxioEvent = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioLocalgovindigenousnation partyidAdoxioLocalgovindigenousnation = default(MicrosoftDynamicsCRMadoxioLocalgovindigenousnation), MicrosoftDynamicsCRMadoxioSpecialevent partyidAdoxioSpecialevent = default(MicrosoftDynamicsCRMadoxioSpecialevent), MicrosoftDynamicsCRMcampaignactivity partyidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMincident partyidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMserviceappointment activityidServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), IList<MicrosoftDynamicsCRMsyncerror> activityPartySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMrecurringappointmentmaster activityidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMinvoice partyidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMcontract partyidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMcampaignactivity activityidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsocialactivity activityidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMappointment activityidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMqueue partyidQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMsystemuser partyidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMfax activityidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMsalesorder partyidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMphonecall activityidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMtask activityidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMcampaignresponse activityidCampaignresponse = default(MicrosoftDynamicsCRMcampaignresponse), MicrosoftDynamicsCRMquoteclose activityidQuoteclose = default(MicrosoftDynamicsCRMquoteclose), MicrosoftDynamicsCRMresourcespec resourcespecid = default(MicrosoftDynamicsCRMresourcespec), MicrosoftDynamicsCRMletter activityidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMorderclose activityidOrderclose = default(MicrosoftDynamicsCRMorderclose), MicrosoftDynamicsCRMbulkoperation partyidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMquote partyidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMemail activityidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMknowledgearticle partyidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMlead partyidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunityclose activityidOpportunityclose = default(MicrosoftDynamicsCRMopportunityclose), MicrosoftDynamicsCRMequipment partyidEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMopportunity partyidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMcampaign partyidCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMaccount partyidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMincidentresolution activityidIncidentresolution = default(MicrosoftDynamicsCRMincidentresolution), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMcontact partyidContact = default(MicrosoftDynamicsCRMcontact))
        {
            Addressused = addressused;
            Donotphone = donotphone;
            Donotpostalmail = donotpostalmail;
            Scheduledstart = scheduledstart;
            Donotfax = donotfax;
            Ispartydeleted = ispartydeleted;
            this._activityidValue = _activityidValue;
            Participationtypemask = participationtypemask;
            Scheduledend = scheduledend;
            Instancetypecode = instancetypecode;
            Versionnumber = versionnumber;
            Addressusedemailcolumnnumber = addressusedemailcolumnnumber;
            this._resourcespecidValue = _resourcespecidValue;
            Effort = effort;
            this._partyidValue = _partyidValue;
            Exchangeentryid = exchangeentryid;
            Activitypartyid = activitypartyid;
            Donotemail = donotemail;
            this._owneridValue = _owneridValue;
            ActivityidAbsScheduledprocessexecutionActivityparty = activityidAbsScheduledprocessexecutionActivityparty;
            PartyidAdoxioApplication = partyidAdoxioApplication;
            PartyidAdoxioLicences = partyidAdoxioLicences;
            PartyidEntitlement = partyidEntitlement;
            PartyidAdoxioEvent = partyidAdoxioEvent;
            PartyidAdoxioLocalgovindigenousnation = partyidAdoxioLocalgovindigenousnation;
            PartyidAdoxioSpecialevent = partyidAdoxioSpecialevent;
            PartyidCampaignactivity = partyidCampaignactivity;
            PartyidIncident = partyidIncident;
            ActivityidServiceappointment = activityidServiceappointment;
            ActivityPartySyncErrors = activityPartySyncErrors;
            ActivityidRecurringappointmentmaster = activityidRecurringappointmentmaster;
            PartyidInvoice = partyidInvoice;
            PartyidContract = partyidContract;
            ActivityidCampaignactivity = activityidCampaignactivity;
            ActivityidSocialactivity = activityidSocialactivity;
            ActivityidAppointment = activityidAppointment;
            PartyidQueue = partyidQueue;
            PartyidSystemuser = partyidSystemuser;
            ActivityidFax = activityidFax;
            PartyidSalesorder = partyidSalesorder;
            ActivityidPhonecall = activityidPhonecall;
            ActivityidTask = activityidTask;
            ActivityidCampaignresponse = activityidCampaignresponse;
            ActivityidQuoteclose = activityidQuoteclose;
            Resourcespecid = resourcespecid;
            ActivityidLetter = activityidLetter;
            ActivityidOrderclose = activityidOrderclose;
            PartyidBulkoperation = partyidBulkoperation;
            PartyidQuote = partyidQuote;
            ActivityidEmail = activityidEmail;
            PartyidKnowledgearticle = partyidKnowledgearticle;
            PartyidLead = partyidLead;
            ActivityidOpportunityclose = activityidOpportunityclose;
            PartyidEquipment = partyidEquipment;
            PartyidOpportunity = partyidOpportunity;
            PartyidCampaign = partyidCampaign;
            PartyidAccount = partyidAccount;
            ActivityidIncidentresolution = activityidIncidentresolution;
            ActivityidActivitypointer = activityidActivitypointer;
            PartyidContact = partyidContact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressused")]
        public string Addressused { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotphone")]
        public bool? Donotphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotpostalmail")]
        public bool? Donotpostalmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduledstart")]
        public System.DateTimeOffset? Scheduledstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotfax")]
        public bool? Donotfax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispartydeleted")]
        public bool? Ispartydeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activityid_value")]
        public string _activityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "participationtypemask")]
        public int? Participationtypemask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduledend")]
        public System.DateTimeOffset? Scheduledend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instancetypecode")]
        public int? Instancetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressusedemailcolumnnumber")]
        public int? Addressusedemailcolumnnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_resourcespecid_value")]
        public string _resourcespecidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effort")]
        public decimal? Effort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_partyid_value")]
        public string _partyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeentryid")]
        public string Exchangeentryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypartyid")]
        public string Activitypartyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotemail")]
        public bool? Donotemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_abs_scheduledprocessexecution_activityparty")]
        public MicrosoftDynamicsCRMabsScheduledprocessexecution ActivityidAbsScheduledprocessexecutionActivityparty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication PartyidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_licences")]
        public MicrosoftDynamicsCRMadoxioLicences PartyidAdoxioLicences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_entitlement")]
        public MicrosoftDynamicsCRMentitlement PartyidEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_event")]
        public MicrosoftDynamicsCRMadoxioEvent PartyidAdoxioEvent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_localgovindigenousnation")]
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation PartyidAdoxioLocalgovindigenousnation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_specialevent")]
        public MicrosoftDynamicsCRMadoxioSpecialevent PartyidAdoxioSpecialevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity PartyidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_incident")]
        public MicrosoftDynamicsCRMincident PartyidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment ActivityidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityParty_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ActivityPartySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ActivityidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_invoice")]
        public MicrosoftDynamicsCRMinvoice PartyidInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_contract")]
        public MicrosoftDynamicsCRMcontract PartyidContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity ActivityidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ActivityidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_appointment")]
        public MicrosoftDynamicsCRMappointment ActivityidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_queue")]
        public MicrosoftDynamicsCRMqueue PartyidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser PartyidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_fax")]
        public MicrosoftDynamicsCRMfax ActivityidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_salesorder")]
        public MicrosoftDynamicsCRMsalesorder PartyidSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ActivityidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_task")]
        public MicrosoftDynamicsCRMtask ActivityidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_campaignresponse")]
        public MicrosoftDynamicsCRMcampaignresponse ActivityidCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_quoteclose")]
        public MicrosoftDynamicsCRMquoteclose ActivityidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespecid")]
        public MicrosoftDynamicsCRMresourcespec Resourcespecid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_letter")]
        public MicrosoftDynamicsCRMletter ActivityidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_orderclose")]
        public MicrosoftDynamicsCRMorderclose ActivityidOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_bulkoperation")]
        public MicrosoftDynamicsCRMbulkoperation PartyidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_quote")]
        public MicrosoftDynamicsCRMquote PartyidQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_email")]
        public MicrosoftDynamicsCRMemail ActivityidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle PartyidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_lead")]
        public MicrosoftDynamicsCRMlead PartyidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_opportunityclose")]
        public MicrosoftDynamicsCRMopportunityclose ActivityidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_equipment")]
        public MicrosoftDynamicsCRMequipment PartyidEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_opportunity")]
        public MicrosoftDynamicsCRMopportunity PartyidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_campaign")]
        public MicrosoftDynamicsCRMcampaign PartyidCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_account")]
        public MicrosoftDynamicsCRMaccount PartyidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_incidentresolution")]
        public MicrosoftDynamicsCRMincidentresolution ActivityidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_contact")]
        public MicrosoftDynamicsCRMcontact PartyidContact { get; set; }

    }
}
