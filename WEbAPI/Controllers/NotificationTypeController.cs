using DAL;
using HCP.WebAPI.Helper;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class NotificationTypeController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
          #region "Variable"

        NotificationTypeDAL objDal = new NotificationTypeDAL();
        //LogEntry objHelper = new LogEntry();

        #endregion
        #region Notification Type Save + Update
        [AcceptVerbs("GET", "POST")]
        public int SaveNotifications(MODEL.NotificationType notifications)
        {
            try
            {
                List<MODEL.NotificationType> notification = new List<MODEL.NotificationType>();
                return new NotificationTypeDAL().Save(notifications, DBNull.Value);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> NotificationTypeController--> SaveNotifications-->" + ex.Message);

               // throw ex;
            }
            return 0;
        }
         #endregion
    }
}
