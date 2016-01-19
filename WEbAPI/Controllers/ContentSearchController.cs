using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class ContentSearchController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        /// <summary>
        /// In this method is used to search implementation
        /// throught out the application.
        /// </summary>
        /// <param name="String"></param>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]

        public List<ContentSearch> GetContentSearch(string String)
        {
            List<ContentSearch> ContentSearchDetails = new List<ContentSearch>();
            try
            {
                ContentSearchDetails = new ContentSearchDAL().GetAll(String);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> ContentSearchController--> GetContentSearch-->" + ex.Message);

                //throw ex;
            }
            return ContentSearchDetails;
        }
        #endregion
    }
}