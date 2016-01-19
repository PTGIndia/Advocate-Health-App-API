using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class NotificationReadStatusDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Notification Read Status Save + Update
        /// <summary>
        /// This method is for to update the notification from unread to read
        /// </summary>
        /// <param name="notificationreadstatus"></param>
        public void Save(NotificationReadStatus notificationreadstatus)
        {
            var result = 0;
            var dbCtx = new AdvocateHealthCareEntities();
          
            dbCtx.spSaveNotificationReadStatus(notificationreadstatus.UserID, notificationreadstatus.NotificationID);
               
            //dbCtx.spSaveNotificationReadStatus(3, 1);
           
        }
         #endregion
    }
}

