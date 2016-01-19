using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class NotificationReadStatusController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Notification Read Status Save + Update
        [AcceptVerbs("GET", "POST")]
        public void SaveNotificationReadStatus(NotificationReadStatus notificationreadstatus)
        {
            try
            {
                NotificationReadStatusDAL notif = new NotificationReadStatusDAL();
                List<NotificationReadStatus> hospital = new List<NotificationReadStatus>();
                notif.Save(notificationreadstatus);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> NotificationReadStatusController--> SaveNotificationReadStatus-->" + ex.Message);

                //throw ex;
            }
           
        }
         #endregion
    }
}
