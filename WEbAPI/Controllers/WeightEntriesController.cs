using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class WeightEntriesController : ApiController
    {
        #region "Variable"
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        [AcceptVerbs("GET", "POST")]

        public List<WeightEntries> GetWeightEntries(int UserId)
        {
            List<WeightEntries> WeightEntriesDetails = new List<WeightEntries>();
            try
            {
                WeightEntriesDetails = new WeightEntriesDAL().GetAll(UserId);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> WeightEntriesController--> GetWeightEntries-->" + ex.Message);

                //throw ex;
            }
            return WeightEntriesDetails;
        }
        #endregion

       #region Save + Update
        [AcceptVerbs("GET", "POST")]
        public int SaveWeightTrackerType(MODEL.WeightEntries weightentries)
        {
        try
           {
               List<MODEL.WeightEntries> profile = new List<MODEL.WeightEntries>();
               return new WeightEntriesDAL().Save(weightentries, DBNull.Value);
            }
           catch (Exception ex)
            {
              throw ex;
            }
           //return 0;
        }
        #endregion
    }
}
