﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdvocateHealthCareEntities : DbContext
    {
        public AdvocateHealthCareEntities()
            : base("name=AdvocateHealthCareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<HospitalImages> HospitalImages { get; set; }
        public virtual DbSet<JournalType> JournalType { get; set; }
        public virtual DbSet<JournalVideo> JournalVideo { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileCategory> ProfileCategory { get; set; }
        public virtual DbSet<ProfileHistory> ProfileHistory { get; set; }
        public virtual DbSet<ProfileJournal> ProfileJournal { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tiles> Tiles { get; set; }
        public virtual DbSet<WeightTracker> WeightTracker { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<spAuthenticateLogin_Result> spAuthenticateLogin(string userEmailId, string userPwd)
        {
            var userEmailIdParameter = userEmailId != null ?
                new ObjectParameter("UserEmailId", userEmailId) :
                new ObjectParameter("UserEmailId", typeof(string));
    
            var userPwdParameter = userPwd != null ?
                new ObjectParameter("UserPwd", userPwd) :
                new ObjectParameter("UserPwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAuthenticateLogin_Result>("spAuthenticateLogin", userEmailIdParameter, userPwdParameter);
        }
    
        public virtual ObjectResult<spGetContentSearch_Result> spGetContentSearch(string @string)
        {
            var stringParameter = @string != null ?
                new ObjectParameter("String", @string) :
                new ObjectParameter("String", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetContentSearch_Result>("spGetContentSearch", stringParameter);
        }
    
        public virtual int spGetErrorInfo(ObjectParameter errorString)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetErrorInfo", errorString);
        }
    
        public virtual ObjectResult<spGetHosipitalDetails_Result> spGetHosipitalDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetHosipitalDetails_Result>("spGetHosipitalDetails");
        }
    
        public virtual ObjectResult<spGetHosipitalImages_Result> spGetHosipitalImages(Nullable<int> userID, Nullable<int> hospitalID, Nullable<byte> assetPositionID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var hospitalIDParameter = hospitalID.HasValue ?
                new ObjectParameter("HospitalID", hospitalID) :
                new ObjectParameter("HospitalID", typeof(int));
    
            var assetPositionIDParameter = assetPositionID.HasValue ?
                new ObjectParameter("AssetPositionID", assetPositionID) :
                new ObjectParameter("AssetPositionID", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetHosipitalImages_Result>("spGetHosipitalImages", userIDParameter, hospitalIDParameter, assetPositionIDParameter);
        }
    
        public virtual int spGetLanguages()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetLanguages");
        }
    
        public virtual ObjectResult<spGetTiles_Result> spGetTiles(Nullable<int> sUBCATEGORYID)
        {
            var sUBCATEGORYIDParameter = sUBCATEGORYID.HasValue ?
                new ObjectParameter("SUBCATEGORYID", sUBCATEGORYID) :
                new ObjectParameter("SUBCATEGORYID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTiles_Result>("spGetTiles", sUBCATEGORYIDParameter);
        }
    
        public virtual ObjectResult<spGetUserSavedImages_Result> spGetUserSavedImages(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserSavedImages_Result>("spGetUserSavedImages", userIDParameter);
        }
    
        public virtual int spSaveGoalsInfo(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveGoalsInfo", loggedInUserParameter);
        }
    
        public virtual int spSaveHospitalImages(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveHospitalImages", loggedInUserParameter);
        }
    
        public virtual int spSaveHospitalInfo(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveHospitalInfo", loggedInUserParameter);
        }
    
        public virtual int spSaveJournalVideos(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveJournalVideos", loggedInUserParameter);
        }
    
        public virtual int spSaveNotificationReadStatus(Nullable<int> userID, Nullable<int> notificationID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var notificationIDParameter = notificationID.HasValue ?
                new ObjectParameter("NotificationID", notificationID) :
                new ObjectParameter("NotificationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveNotificationReadStatus", userIDParameter, notificationIDParameter);
        }
    
        public virtual int spSaveNotifications(string loggedinuser)
        {
            var loggedinuserParameter = loggedinuser != null ?
                new ObjectParameter("loggedinuser", loggedinuser) :
                new ObjectParameter("loggedinuser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveNotifications", loggedinuserParameter);
        }
    
        public virtual int spSaveProfileCategory(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveProfileCategory", loggedInUserParameter);
        }
    
        public virtual int spSaveProfileInfo(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveProfileInfo", loggedInUserParameter);
        }
    
        public virtual int spSaveProfileInfo1(string loggedInUser, ObjectParameter @return)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveProfileInfo1", loggedInUserParameter, @return);
        }
    
        public virtual int spSaveProfileInfotest(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveProfileInfotest", loggedInUserParameter);
        }
    
        public virtual int spSaveProfileJournal(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveProfileJournal", loggedInUserParameter);
        }
    
        public virtual int spSaveTilesInfo(string loggedInUser)
        {
            var loggedInUserParameter = loggedInUser != null ?
                new ObjectParameter("LoggedInUser", loggedInUser) :
                new ObjectParameter("LoggedInUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveTilesInfo", loggedInUserParameter);
        }
    
        public virtual int spSaveWeightTracker(string loggedinuser)
        {
            var loggedinuserParameter = loggedinuser != null ?
                new ObjectParameter("loggedinuser", loggedinuser) :
                new ObjectParameter("loggedinuser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveWeightTracker", loggedinuserParameter);
        }
    
        public virtual ObjectResult<spGetWeightEntries_Result3> spGetWeightEntries(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetWeightEntries_Result3>("spGetWeightEntries", userIDParameter);
        }
    
        public virtual ObjectResult<spGetJournals_Result1> spGetJournals(Nullable<int> userId, Nullable<int> journalTypeId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var journalTypeIdParameter = journalTypeId.HasValue ?
                new ObjectParameter("JournalTypeId", journalTypeId) :
                new ObjectParameter("JournalTypeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetJournals_Result1>("spGetJournals", userIdParameter, journalTypeIdParameter);
        }
    
        public virtual ObjectResult<spGetJournalVideos_Result1> spGetJournalVideos(Nullable<int> sUBCATEGORYID)
        {
            var sUBCATEGORYIDParameter = sUBCATEGORYID.HasValue ?
                new ObjectParameter("SUBCATEGORYID", sUBCATEGORYID) :
                new ObjectParameter("SUBCATEGORYID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetJournalVideos_Result1>("spGetJournalVideos", sUBCATEGORYIDParameter);
        }
    
        public virtual ObjectResult<spGetNotifications_Result1> spGetNotifications(Nullable<int> userId, Nullable<int> hospitalId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var hospitalIdParameter = hospitalId.HasValue ?
                new ObjectParameter("HospitalId", hospitalId) :
                new ObjectParameter("HospitalId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetNotifications_Result1>("spGetNotifications", userIdParameter, hospitalIdParameter);
        }
    }
}
