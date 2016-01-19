using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class JournalsController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        /// <summary>
        /// This method is used to return the journals/questions information
        /// based on JournalTypeId
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="JournalTypeId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]

        public List<Journals> GetJournals(int UserId, int JournalTypeId)
        {
            List<Journals> JournalsDetails = new List<Journals>();
            try
            {
                JournalsDetails = new JournalsDAL().GetAll(UserId, JournalTypeId);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> JournalsController--> GetJournals-->" + ex.Message);

               // throw ex;
            }
            return JournalsDetails;
        }
        #endregion
    }
}
