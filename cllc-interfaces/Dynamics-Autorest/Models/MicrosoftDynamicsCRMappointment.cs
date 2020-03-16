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
    /// Microsoft.Dynamics.CRM.appointment
    /// </summary>
    public partial class MicrosoftDynamicsCRMappointment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappointment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappointment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappointment
        /// class.
        /// </summary>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="subscriptionid">For internal use only.</param>
        /// <param name="modifiedfieldsmask">For internal use only. </param>
        /// <param name="globalobjectid">Shows the ID of the appointment in
        /// Microsoft Office Outlook. The ID is used to synchronize the
        /// appointment between Microsoft Dynamics 365 and the correct Exchange
        /// account.</param>
        /// <param name="attachmenterrors">Select the error code to identify
        /// issues with the outlook item recipients or attachments, such as
        /// blocked attachments.</param>
        /// <param name="outlookownerapptid">Unique identifier of the Microsoft
        /// Office Outlook appointment owner that correlates to the
        /// PR_OWNER_APPT_ID MAPI property.</param>
        /// <param name="isalldayevent">Select whether the appointment is an
        /// all-day event to make sure that the required resources are
        /// scheduled for the full day.</param>
        /// <param name="subcategory">Type a subcategory to identify the
        /// appointment type and relate the activity to a specific product,
        /// sales region, business group, or other function.</param>
        /// <param name="originalstartdate">The original start date of the
        /// appointment.</param>
        /// <param name="category">Type a category to identify the appointment
        /// type, such as sales demo, prospect call, or service call, to tie
        /// the appointment to a business group or function.</param>
        /// <param name="location">Type the location where the appointment will
        /// take place, such as a conference room or customer office.</param>
        public MicrosoftDynamicsCRMappointment(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string subscriptionid = default(string), string modifiedfieldsmask = default(string), string globalobjectid = default(string), int? attachmenterrors = default(int?), int? outlookownerapptid = default(int?), bool? isalldayevent = default(bool?), string subcategory = default(string), System.DateTimeOffset? originalstartdate = default(System.DateTimeOffset?), string category = default(string), string location = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementAppointment = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateAppointment = default(MicrosoftDynamicsCRMentitlementtemplate), IList<MicrosoftDynamicsCRMpostregarding> appointmentPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> appointmentPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingAppointment = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderAppointment = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordAppointment = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMqueueitem> appointmentQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceAppointment = default(MicrosoftDynamicsCRMinvoice), IList<MicrosoftDynamicsCRMannotation> appointmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMsyncerror> appointmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMincident regardingobjectidIncidentAppointment = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMrecurringappointmentmaster seriesidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMbusinessunit owningbusinessunitAppointment = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> appointmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignAppointment = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMactivityparty> appointmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMquote regardingobjectidQuoteAppointment = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMcontract regardingobjectidContractAppointment = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMasyncoperation> appointmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyAppointment = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> appointmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMconnection> appointmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceAppointment = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMsystemuser modifiedbyAppointment = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitymimeattachment> appointmentActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMbulkdeletefailure> appointmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMlead regardingobjectidLeadAppointment = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMconnection> appointmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMactioncard> appointmentActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMsla slaAppointmentSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityAppointment = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMcontact regardingobjectidContactAppointment = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser createdonbehalfbyAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleAppointment = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMservice serviceidAppointment = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMaccount regardingobjectidAccountAppointment = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidAppointment = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsla slainvokedidAppointmentSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdbyAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderAppointment = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationAppointment = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityAppointment = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMteam owningteamAppointment = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMcampaignresponse> appointmentCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMsystemuser owninguserAppointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessAppointment = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationAppointment = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintAppointment = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationAppointment = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesAppointment = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerAppointment = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationAppointment = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventAppointment = default(MicrosoftDynamicsCRMadoxioEvent))
        {
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Subscriptionid = subscriptionid;
            Modifiedfieldsmask = modifiedfieldsmask;
            Globalobjectid = globalobjectid;
            Attachmenterrors = attachmenterrors;
            Outlookownerapptid = outlookownerapptid;
            Isalldayevent = isalldayevent;
            Subcategory = subcategory;
            Originalstartdate = originalstartdate;
            Category = category;
            Location = location;
            RegardingobjectidEntitlementAppointment = regardingobjectidEntitlementAppointment;
            RegardingobjectidEntitlementtemplateAppointment = regardingobjectidEntitlementtemplateAppointment;
            AppointmentPostRegardings = appointmentPostRegardings;
            AppointmentPostFollows = appointmentPostFollows;
            RegardingobjectidBookableresourcebookingAppointment = regardingobjectidBookableresourcebookingAppointment;
            RegardingobjectidBookableresourcebookingheaderAppointment = regardingobjectidBookableresourcebookingheaderAppointment;
            RegardingobjectidKnowledgebaserecordAppointment = regardingobjectidKnowledgebaserecordAppointment;
            AppointmentQueueItem = appointmentQueueItem;
            RegardingobjectidInvoiceAppointment = regardingobjectidInvoiceAppointment;
            AppointmentAnnotation = appointmentAnnotation;
            AppointmentSyncErrors = appointmentSyncErrors;
            StageidProcessstage = stageidProcessstage;
            RegardingobjectidIncidentAppointment = regardingobjectidIncidentAppointment;
            SeriesidRecurringappointmentmaster = seriesidRecurringappointmentmaster;
            OwningbusinessunitAppointment = owningbusinessunitAppointment;
            AppointmentDuplicateBaseRecord = appointmentDuplicateBaseRecord;
            RegardingobjectidCampaignAppointment = regardingobjectidCampaignAppointment;
            AppointmentActivityParties = appointmentActivityParties;
            RegardingobjectidQuoteAppointment = regardingobjectidQuoteAppointment;
            RegardingobjectidContractAppointment = regardingobjectidContractAppointment;
            AppointmentAsyncOperations = appointmentAsyncOperations;
            ModifiedonbehalfbyAppointment = modifiedonbehalfbyAppointment;
            AppointmentDuplicateMatchingRecord = appointmentDuplicateMatchingRecord;
            AppointmentConnections1 = appointmentConnections1;
            SlakpiinstanceAppointment = slakpiinstanceAppointment;
            ModifiedbyAppointment = modifiedbyAppointment;
            AppointmentActivityMimeAttachment = appointmentActivityMimeAttachment;
            AppointmentBulkDeleteFailures = appointmentBulkDeleteFailures;
            RegardingobjectidLeadAppointment = regardingobjectidLeadAppointment;
            AppointmentConnections2 = appointmentConnections2;
            AppointmentActioncard = appointmentActioncard;
            SlaAppointmentSla = slaAppointmentSla;
            RegardingobjectidOpportunityAppointment = regardingobjectidOpportunityAppointment;
            RegardingobjectidContactAppointment = regardingobjectidContactAppointment;
            CreatedonbehalfbyAppointment = createdonbehalfbyAppointment;
            RegardingobjectidKnowledgearticleAppointment = regardingobjectidKnowledgearticleAppointment;
            ServiceidAppointment = serviceidAppointment;
            RegardingobjectidAccountAppointment = regardingobjectidAccountAppointment;
            ActivityidActivitypointer = activityidActivitypointer;
            TransactioncurrencyidAppointment = transactioncurrencyidAppointment;
            SlainvokedidAppointmentSla = slainvokedidAppointmentSla;
            CreatedbyAppointment = createdbyAppointment;
            RegardingobjectidSalesorderAppointment = regardingobjectidSalesorderAppointment;
            RegardingobjectidBulkoperationAppointment = regardingobjectidBulkoperationAppointment;
            RegardingobjectidCampaignactivityAppointment = regardingobjectidCampaignactivityAppointment;
            OwningteamAppointment = owningteamAppointment;
            AppointmentCampaignresponse = appointmentCampaignresponse;
            OwninguserAppointment = owninguserAppointment;
            RegardingobjectidAbsScheduledprocessAppointment = regardingobjectidAbsScheduledprocessAppointment;
            RegardingobjectidAdoxioApplicationAppointment = regardingobjectidAdoxioApplicationAppointment;
            RegardingobjectidAdoxioComplaintAppointment = regardingobjectidAdoxioComplaintAppointment;
            RegardingobjectidAdoxioInvestigationAppointment = regardingobjectidAdoxioInvestigationAppointment;
            RegardingobjectidAdoxioLicencesAppointment = regardingobjectidAdoxioLicencesAppointment;
            RegardingobjectidAdoxioWorkerAppointment = regardingobjectidAdoxioWorkerAppointment;
            RegardingobjectidAdoxioComplianceinvestigationAppointment = regardingobjectidAdoxioComplianceinvestigationAppointment;
            RegardingobjectidAdoxioEventAppointment = regardingobjectidAdoxioEventAppointment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedfieldsmask")]
        public string Modifiedfieldsmask { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the appointment in Microsoft Office
        /// Outlook. The ID is used to synchronize the appointment between
        /// Microsoft Dynamics 365 and the correct Exchange account.
        /// </summary>
        [JsonProperty(PropertyName = "globalobjectid")]
        public string Globalobjectid { get; set; }

        /// <summary>
        /// Gets or sets select the error code to identify issues with the
        /// outlook item recipients or attachments, such as blocked
        /// attachments.
        /// </summary>
        [JsonProperty(PropertyName = "attachmenterrors")]
        public int? Attachmenterrors { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Microsoft Office Outlook
        /// appointment owner that correlates to the PR_OWNER_APPT_ID MAPI
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "outlookownerapptid")]
        public int? Outlookownerapptid { get; set; }

        /// <summary>
        /// Gets or sets select whether the appointment is an all-day event to
        /// make sure that the required resources are scheduled for the full
        /// day.
        /// </summary>
        [JsonProperty(PropertyName = "isalldayevent")]
        public bool? Isalldayevent { get; set; }

        /// <summary>
        /// Gets or sets type a subcategory to identify the appointment type
        /// and relate the activity to a specific product, sales region,
        /// business group, or other function.
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// Gets or sets the original start date of the appointment.
        /// </summary>
        [JsonProperty(PropertyName = "originalstartdate")]
        public System.DateTimeOffset? Originalstartdate { get; set; }

        /// <summary>
        /// Gets or sets type a category to identify the appointment type, such
        /// as sales demo, prospect call, or service call, to tie the
        /// appointment to a business group or function.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets type the location where the appointment will take
        /// place, such as a conference room or customer office.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_appointment")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_appointment")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> AppointmentPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> AppointmentPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_appointment")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_appointment")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_appointment")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> AppointmentQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_appointment")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> AppointmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AppointmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_appointment")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seriesid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster SeriesidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_appointment")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AppointmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_appointment")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AppointmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_appointment")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_appointment")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AppointmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_appointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AppointmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> AppointmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_appointment")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_appointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_activity_mime_attachment")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> AppointmentActivityMimeAttachment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Appointment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AppointmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_appointment")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> AppointmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> AppointmentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_appointment_sla")]
        public MicrosoftDynamicsCRMsla SlaAppointmentSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_appointment")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_appointment")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_appointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_appointment")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_appointment")]
        public MicrosoftDynamicsCRMservice ServiceidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_appointment")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_appointment")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_appointment_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidAppointmentSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_appointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_appointment")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_appointment")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_appointment")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_appointment")]
        public MicrosoftDynamicsCRMteam OwningteamAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointment_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> AppointmentCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_appointment")]
        public MicrosoftDynamicsCRMsystemuser OwninguserAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_appointment")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_appointment")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_appointment")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_appointment")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_appointment")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_appointment")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_appointment")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_appointment")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventAppointment { get; set; }

    }
}
