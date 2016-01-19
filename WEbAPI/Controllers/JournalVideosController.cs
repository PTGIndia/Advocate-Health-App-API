using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace WEbAPI.Controllers
{
    public class JournalVideosController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        /// <summary>
        /// This method is for getting the videos based on SUBCATEGORYID
        /// </summary>
        /// <param name="SUBCATEGORYID"></param>
        /// <returns></returns>
         #region Fetch Data
        [AcceptVerbs("GET", "POST")]
       // public List<JournalVideos> GetJournalVideos()
            
        public List<JournalVideos> GetJournalVideos(int? SUBCATEGORYID)
        {
            List<JournalVideos> JournalVideosDetails = new List<JournalVideos>();
            try
            {
                //JournalVideosDetails = new JournalVideosDAL().GetAll();
                JournalVideosDetails = new JournalVideosDAL().GetAll(SUBCATEGORYID);
               
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> JournalVideosController--> GetJournalVideos-->" + ex.Message);
                //throw ex;
            }
            return JournalVideosDetails;
        }
         #endregion
    }
}
