using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Web.Http;
namespace WEbAPI.Controllers
{
    public class AuthenticateLoginController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion

        #region Fetch Data
        /// <summary>
        /// This method is taking EmailId and password and it returns the 
        /// hospital id and user id.
        /// </summary>
        /// <param name="UserEmailId"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]
        

        public AuthenticateLogin GetAuthentication(string UserEmailId, string UserPwd)
        {
            AuthenticateLogin AuthenticationDetails = new AuthenticateLogin();
            try
            {
                AuthenticationDetails = new AuthenticateLoginDAL().GetAll(UserEmailId, UserPwd);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> AuthenticateLoginController--> GetAuthentication-->" + ex.Message);

                //throw ex;
            }
            //if (AuthenticationDetails != null)
            //    return AuthenticationDetails;
            //return new AuthenticateLogin()
            //{
            //   isValidUser = false
                
            //};
            return AuthenticationDetails;
        }
        #endregion
    }
}
