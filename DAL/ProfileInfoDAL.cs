using MODEL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProfileInfoDAL
    {
        #region "Variable"

        AdvocateHealthCareEntities context = null;
        #endregion
        #region Profile information Save + Update
        /// <summary>
        /// This Method is for create new Profile .
        /// </summary>
        /// <param name="profileinfo"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public int Save(ProfileInfo profileinfo, DBNull t2)
        {

            // byte[] byteArray = profileinfo.picture1;

            // MemoryStream ms = new MemoryStream(byteArray);
            // System.Drawing.Image im = System.Drawing.Image.FromStream(ms);

            //// im.Save("~/images/1111.jpg");
            // System.Web.Hosting.HostingEnvironment.MapPath("~/Images-Upload/1111.jpg");

            var result = 0;
            var dbCtx = new AdvocateHealthCareEntities();
            var dtProfileInfoType = new DataTable();
            dtProfileInfoType.Columns.Add("ProfileID", typeof(int));
            dtProfileInfoType.Columns.Add("FirstName", typeof(string));
            dtProfileInfoType.Columns.Add("LastName", typeof(string));
            dtProfileInfoType.Columns.Add("Email", typeof(string));
            dtProfileInfoType.Columns.Add("Password", typeof(string));
            dtProfileInfoType.Columns.Add("LMPdate", typeof(DateTime));
            dtProfileInfoType.Columns.Add("Picture", typeof(string));
            dtProfileInfoType.Columns.Add("HospitalID", typeof(int));
            dtProfileInfoType.Columns.Add("CreatedDate", typeof(DateTime));

            dtProfileInfoType.Rows.Add(profileinfo.ProfileID, profileinfo.FirstName, profileinfo.LastName,
                                       profileinfo.Email, profileinfo.Password, profileinfo.LMPdate,
                                       profileinfo.Picture, profileinfo.HospitalID, profileinfo.CreatedDate);

            //dtProfileInfoType.Rows.Add(null, "dsggcxcf", "dsggfsf", "abc@ptgindia1p231.com", 123, null, null, 1,

            //                            DateTime.Now);

            var spSaveProfileInfo1 = new SqlParameter();
            spSaveProfileInfo1.ParameterName = "@ProfileType";
            spSaveProfileInfo1.Value = dtProfileInfoType;
            spSaveProfileInfo1.SqlDbType = SqlDbType.Structured;
            spSaveProfileInfo1.TypeName = "ProfileType";

            var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
            // caseId.Value = "PTG";
           caseId.Value = profileinfo.LoggedInUser;


            //This code is for Return the Output value

             var spReturn = new SqlParameter("RetVal", SqlDbType.Int, 100);
             spReturn.Direction = ParameterDirection.Output;



            //result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveProfileInfo + " @ProfileType, @LoggedInUser", new object[] { spSaveProfileInfo1, caseId });

             result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveProfileInfo1 + " @ProfileType, @LoggedInUser,@RetVal OUTPUT", new object[] { spSaveProfileInfo1, caseId, spReturn });

           return (int)spReturn.Value == 0 ? 0 : 1;

            //if (result >1)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
        #endregion
    }
}


