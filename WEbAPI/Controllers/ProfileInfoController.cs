using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Http;

namespace WEbAPI.Controllers
{
      //public class ProfileInfoController : ApiController
      //{
    public class ProfileInfoController : ApiController, IDisposable
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion

        private bool isDalDisposed;

        public ProfileInfoController()
            : base()
        {
            // opens a connection that will have to be cleaned up
            isDalDisposed = false;
        }

        #region Profile Information Save + Update

        [AcceptVerbs("GET", "POST")]
        public int SaveProfileInfo(MODEL.ProfileInfo profileinfo)
        {
            try
            {
                // MODEL.ProfileInfo TEST = new ProfileInfo();         
                List<ProfileInfo> profile = new List<ProfileInfo>();
                //string imageInString = TEST.Picture;                 
                string imageInString = profileinfo.Picture;
                if (imageInString != null)
                {
                    int NumberChars = imageInString.Length;
                    byte[] imageinbyte = new byte[NumberChars / 2];
                    for (int i = 0; i < NumberChars; i += 2)
                        imageinbyte[i / 2] = Convert.ToByte(imageInString.Substring(i, 2), 16);
                    MemoryStream streams = new MemoryStream(imageinbyte);
                    Image img = Image.FromStream(streams);
                    //This is for maintaing the unique id to store the image in image-Upload folder.
                    string uniqueKey = Guid.NewGuid().ToString().GetHashCode().ToString("x");
                    string path = System.Web.HttpContext.Current.Server.MapPath("~/Images-Upload/" + uniqueKey + ".jpg");
                    img.Save(path);
                    streams.Dispose();
                    img.Dispose();
                    profileinfo.Picture = "/Images-Upload/" + uniqueKey + ".jpg";
                }

                return new ProfileInfoDAL().Save(profileinfo, DBNull.Value);
            }
                
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> ProfileInfoController--> SaveProfileInfo-->" + ex.Message);
                //throw ex;
            }
            return 0;
        }

        #endregion

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}

