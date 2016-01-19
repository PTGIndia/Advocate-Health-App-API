using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class UserSavedImagesController : ApiController
    {
        #region "Variable"
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        [AcceptVerbs("GET", "POST")]

        public List<UserSavedImages> GetUserSavedImages(int UserId)
        {
            List<UserSavedImages> ImagesDetails = new List<UserSavedImages>();
            try
            {
                ImagesDetails = new UserSavedImagesDAL().GetAll(UserId);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> UserSavedImagesController--> GetUserSavedImages-->" + ex.Message);

               // throw ex;
            }
            return ImagesDetails;
        }
        #endregion
    }
}
