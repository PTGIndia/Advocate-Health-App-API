using DAL;
using HCP.WebAPI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class ProfileJournalController : ApiController
    {
       
        #region "Variable"
        LogEntry objHelper = new LogEntry();

        ProfileJournalDAL objDal = new ProfileJournalDAL();
        #endregion

        #region Profile JournalSave + Update

        [AcceptVerbs("GET", "POST")]
        public int SaveProfileJournal(MODEL.ProfileJournal profilejournal)
        {
            try
            {
                List<MODEL.ProfileJournal> profile = new List<MODEL.ProfileJournal>();

                string imageInString = profilejournal.JournalAsset;
                if (imageInString != null)
                {
                    int NumberChars = imageInString.Length;
                    byte[] imageinbyte = new byte[NumberChars / 2];
                    for (int i = 0; i < NumberChars; i += 2)
                        imageinbyte[i / 2] = Convert.ToByte(imageInString.Substring(i, 2), 16);
                    MemoryStream streams = new MemoryStream(imageinbyte);

                    Image img = Image.FromStream(streams);
                    string uniqueKey = Guid.NewGuid().ToString().GetHashCode().ToString("x");

                    string path = System.Web.HttpContext.Current.Server.MapPath("~/Images-Upload/" + uniqueKey + ".jpg");
                    img.Save(path, ImageFormat.Png);
                    profilejournal.JournalAsset = "/Images-Upload/" + uniqueKey + ".jpg";
                }
                return new ProfileJournalDAL().Save(profilejournal, DBNull.Value);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> ProfileJournalController--> SaveProfileJournal-->" + ex.Message);

               // throw ex;
            }
            return 0;
        }
        #endregion
    }
}
