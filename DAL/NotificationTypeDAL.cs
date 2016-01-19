using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NotificationTypeDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Save + Update
        public int Save(MODEL.NotificationType notificationtype, DBNull t2)
        {
         
            var result = 0;
            var dbCtx = new AdvocateHealthCareEntities();
            var dtnotificationType = new DataTable();
            dtnotificationType.Columns.Add("NotificationID", typeof(int));
            dtnotificationType.Columns.Add("NotificationTypeID", typeof(int));
            dtnotificationType.Columns.Add("ProfileID", typeof(int));
            dtnotificationType.Columns.Add("Title", typeof(string));
            dtnotificationType.Columns.Add("Comments", typeof(string));
            dtnotificationType.Columns.Add("IsRead", typeof(bool));
            dtnotificationType.Columns.Add("CreatedDate", typeof(DateTime));
            dtnotificationType.Columns.Add("CreatedBy", typeof(string));


            dtnotificationType.Rows.Add(notificationtype.NotificationID, notificationtype.NotificationTypeID, notificationtype.ProfileID,
                                        notificationtype.Title, notificationtype.Comments, notificationtype.IsRead, notificationtype.CreatedDate,
                                        notificationtype.CreatedBy);

            //dtnotificationType.Rows.Add(7,1,3,"Pregnancy",null,null,null,null);


            var spSaveNotifications = new SqlParameter();
            spSaveNotifications.ParameterName = "@NotificationType";
            spSaveNotifications.Value = dtnotificationType;
            spSaveNotifications.SqlDbType = SqlDbType.Structured;
            spSaveNotifications.TypeName = "NotificationType";


            var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
            caseId.Value = notificationtype.LoggedInUser;
         // caseId.Value = "PTG";
            result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveNotifications + " @NotificationType, @LoggedInUser", new object[] { spSaveNotifications, caseId });

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

