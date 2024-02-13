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
    /// Microsoft.Dynamics.CRM.goalrollupquery
    /// </summary>
    public partial class MicrosoftDynamicsCRMgoalrollupquery
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMgoalrollupquery class.
        /// </summary>
        public MicrosoftDynamicsCRMgoalrollupquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMgoalrollupquery class.
        /// </summary>
        public MicrosoftDynamicsCRMgoalrollupquery(string _owningteamValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), string queryentitytype = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string fetchxml = default(string), string name = default(string), string goalrollupqueryid = default(string), int? statecode = default(int?), int? statuscode = default(int?), string _owneridValue = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMgoal> goalrollupqueryActualint = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryActualmoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryActualdecimal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustomint = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustommoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustomdecimal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressint = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressmoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressdecimal = default(IList<MicrosoftDynamicsCRMgoal>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> goalRollupQueryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMasyncoperation> goalrollupqueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> goalRollupQueryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMprocesssession> goalrollupqueryProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMsyncerror> goalRollupQuerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit))
        {
            this._owningteamValue = _owningteamValue;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Queryentitytype = queryentitytype;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Fetchxml = fetchxml;
            Name = name;
            Goalrollupqueryid = goalrollupqueryid;
            Statecode = statecode;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            Owningteam = owningteam;
            GoalrollupqueryActualint = goalrollupqueryActualint;
            GoalRollupqueryActualmoney = goalRollupqueryActualmoney;
            GoalRollupqueryActualdecimal = goalRollupqueryActualdecimal;
            GoalRollupqueryCustomint = goalRollupqueryCustomint;
            GoalRollupqueryCustommoney = goalRollupqueryCustommoney;
            GoalRollupqueryCustomdecimal = goalRollupqueryCustomdecimal;
            GoalRollupqueryInprogressint = goalRollupqueryInprogressint;
            GoalRollupqueryInprogressmoney = goalRollupqueryInprogressmoney;
            GoalRollupqueryInprogressdecimal = goalRollupqueryInprogressdecimal;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            GoalRollupQueryDuplicateBaseRecord = goalRollupQueryDuplicateBaseRecord;
            Ownerid = ownerid;
            GoalrollupqueryAsyncOperations = goalrollupqueryAsyncOperations;
            GoalRollupQueryDuplicateMatchingRecord = goalRollupQueryDuplicateMatchingRecord;
            GoalrollupqueryProcessSessions = goalrollupqueryProcessSessions;
            GoalRollupQuerySyncErrors = goalRollupQuerySyncErrors;
            Owningbusinessunit = owningbusinessunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryentitytype")]
        public string Queryentitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fetchxml")]
        public string Fetchxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupqueryid")]
        public string Goalrollupqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupquery_actualint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalrollupqueryActualint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_actualmoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryActualmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_actualdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryActualdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_customint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustomint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_custommoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustommoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_customdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustomdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressmoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalRollupQueryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupquery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> GoalrollupqueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalRollupQueryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupquery_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> GoalrollupqueryProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> GoalRollupQuerySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

    }
}
