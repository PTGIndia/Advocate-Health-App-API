using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class NotificationsController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        /// <summary>
        /// This method return the Notifications and Type of Notifications
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="HospitalId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]

        public List<Notifications> GetNotifications(int UserId, int HospitalId)
        {
            List<Notifications> NotificationsDetails = new List<Notifications>();
            try
            {
                NotificationsDetails = new NotificationsDAL().GetAll(UserId, HospitalId);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> NotificationsController--> GetNotifications-->" + ex.Message);

                //throw ex;
            }
            return NotificationsDetails;
        }
        #endregion
    }
}
