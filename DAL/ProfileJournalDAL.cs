using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ProfileJournalDAL
    {
         #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Save + Update
       public int Save(MODEL.ProfileJournal profilejournal, DBNull t2)
        {
            var result = 0;
            var dbCtx = new AdvocateHealthCareEntities();
            var dtProfileJournalType = new DataTable();
            dtProfileJournalType.Columns.Add("ProfileJournalID", typeof(string));
            dtProfileJournalType.Columns.Add("ProfileID", typeof(int));
            dtProfileJournalType.Columns.Add("JournalTitle", typeof(string));
            dtProfileJournalType.Columns.Add("JournalInfo", typeof(string));
            dtProfileJournalType.Columns.Add("JournalAsset", typeof(string));
            dtProfileJournalType.Columns.Add("JournalTypeID", typeof(int));
            //dtProfileJournalType.Columns.Add("CreatedDate", typeof(string));
            dtProfileJournalType.Columns.Add("CreatedDate", typeof(DateTime));
            //dtProfileJournalType.Columns.Add("CreatedBy", typeof(string));


            dtProfileJournalType.Rows.Add(profilejournal.ProfileJournalID, profilejournal.ProfileID,
                                            profilejournal.JournalTitle, profilejournal.JournalInfo,
                                            profilejournal.JournalAsset, profilejournal.JournalTypeID,
                                            profilejournal.CreatedDate);
                                        
          // dtProfileJournalType.Rows.Add(5, 2, "sirisha", null, "~/Images-Upload/gallery_img1.png", 2);
                                 

             var spSaveProfileJournal = new SqlParameter();
             spSaveProfileJournal.ParameterName = "@ProfileJournalType";
             spSaveProfileJournal.Value = dtProfileJournalType;
             spSaveProfileJournal.SqlDbType = SqlDbType.Structured;
             spSaveProfileJournal.TypeName = "ProfileJournalType";


        var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
         // caseId.Value = "PTG";
        caseId.Value = profilejournal.LoggedInUser;

           result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveProfileJournal + " @ProfileJournalType, @LoggedInUser", new object[] { spSaveProfileJournal, caseId });

            if (result == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        #endregion
    }
}
