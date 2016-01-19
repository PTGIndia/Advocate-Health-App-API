using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace DAL
{
    public class WeightEntriesDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Fetch WeightEntries
         public List<MODEL.WeightEntries> GetAll(int userId)
       {
           List<MODEL.WeightEntries> WeightEntriesList = null;
           try
           {
               using (context = new AdvocateHealthCareEntities())
                   WeightEntriesList = context.spGetWeightEntries(userId).Select(x => new MODEL.WeightEntries
                       {
                           Weight=x.Weight,
                           LMPDATE=x.LMPDATE,
                           CreatedDate=x.DisplayDate
                       }).ToList();
           }
            catch (Exception ex)
           {
               throw ex;
           }
           return WeightEntriesList;
       }
       #endregion

         #region Save + Update
         public int Save(MODEL.WeightEntries weightentries, DBNull t2)
         {
             var result = 0;
             var dbCtx = new AdvocateHealthCareEntities();
             var dtweightentriesType = new DataTable();
             dtweightentriesType.Columns.Add("WeightTrackerID", typeof(int));
             dtweightentriesType.Columns.Add("ProfileID", typeof(int));
             dtweightentriesType.Columns.Add("Weight", typeof(decimal));
             dtweightentriesType.Columns.Add("CreatedDate",typeof(DateTime));
             DateTime stcreateddate =Convert.ToDateTime(weightentries.CreatedDate);
             dtweightentriesType.Rows.Add(weightentries.WeightTrackerID, weightentries.ProfileID, weightentries.Weight, stcreateddate);
        // dtweightentriesType.Rows.Add(null,6,null,"2015-12-30 18:05:54.993");

             var spsaveweightTracker = new SqlParameter();
             spsaveweightTracker.ParameterName = "@WeightTrackerType";
             spsaveweightTracker.Value = dtweightentriesType;
             spsaveweightTracker.SqlDbType = SqlDbType.Structured;
             spsaveweightTracker.TypeName = "WeightTrackerType";

              var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
            // caseId.Value = "PTG";
             caseId.Value = weightentries.LoggedInUser;
       

            result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveweightTracker + " @WeightTrackerType, @LoggedInUser", new object[] { spsaveweightTracker, caseId });

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

    
