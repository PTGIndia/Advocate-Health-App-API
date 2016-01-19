using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
   public class NotificationsDAL
    {
       #region "Variable"
       AdvocateHealthCareEntities context = null;
       #endregion
       #region Fetch NotificationsInfo
       public List<MODEL.Notifications> GetAll(int UserId, int HospitalId)
       {
           List<MODEL.Notifications> NotificationsList = null;
           try
           {
               using (context = new AdvocateHealthCareEntities())
                   //assessmentdetailsLst = dbCtx.spGetAssessmentDetails().Select(x => new refModel.AssessmentDetails

                   NotificationsList = context.spGetNotifications(UserId, HospitalId).Select(x => new MODEL.Notifications
                   {
                       HospitalID = x.HospitalID,
                       UserName=x.UserName,
                       NotificationID=x.NotificationID,
                       NotificationText=x.NotificationText,
                       NotificationTitle=x.NotificationTitle,
                       TypeOfNotification=x.TypeOfNotification,
                       IsRead=x.IsRead,
                       NotificationDate=x.NotificationDate,
                       HospitalName = x.HospitalName,
                   }).ToList();
           }

           catch (Exception ex)
           {
               throw ex;
           }
           return NotificationsList;
       }
       #endregion
    }
}
