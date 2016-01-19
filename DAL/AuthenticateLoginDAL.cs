using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODEL;
using System.Data.Entity.Core.Objects;
namespace DAL
{
    public class AuthenticateLoginDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Fetch AuthenticateLoginInfo

        public MODEL.AuthenticateLogin GetAll(string UserEmailId, string UserPwd)
        {
            MODEL.AuthenticateLogin LoginList = null;
           
            try
            {
                using (context = new AdvocateHealthCareEntities())
                {
                    LoginList = context.spAuthenticateLogin(UserEmailId, UserPwd).Select(x => new MODEL.AuthenticateLogin
                    {
                        HospitalID = Convert.ToInt32(x.HospitalID),
                        ProfileID = Convert.ToInt32(x.ProfileID),
                        Flag=x.Flag
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return LoginList;
        }
        #endregion
    }
}
