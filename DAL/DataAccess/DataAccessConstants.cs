using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess
{
    public class DataAccessConstants
    {
        #region "Constant Declaration"
        /*HospitalInfo*/
        public const string SaveHospitalInfo = "[dbo].[spSaveHospitalInfo]";
        /*ProfileInfo*/
        public const string SaveProfileInfo = "[dbo].[spSaveProfileInfo]";


        public const string SaveProfileInfo1 = "[dbo].[spSaveProfileInfo1]";
        /*Notifications*/
        public const string SaveNotifications = "[dbo].[spSaveNotifications]";
        /*ProfileJournal*/
        public const string SaveProfileJournal = "[dbo].[spSaveProfileJournal]";
        /*weightTracker*/
        public const string SaveweightTracker = "[dbo].[spSaveweightTracker]";
        /*HospitalImagesType*/
        public const string SaveHospitalImages = "[dbo].[spSaveHospitalImages]";

        #endregion
    }
}
