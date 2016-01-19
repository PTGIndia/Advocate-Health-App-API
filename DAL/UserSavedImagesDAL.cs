using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.IO;

namespace DAL
{
    public class UserSavedImagesDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Fetch GetUserSavedImages

        public List<MODEL.UserSavedImages> GetAll(int userId)
        {
            List<MODEL.UserSavedImages> ImagesList = null;

            try
            {
                //var image = "text";
                ////string uri = "http://183.82.48.194:5560/api/NotificationReadStatus/" + arun;
                //string uri1 = "http://183.82.48.194:5560/api/NotificationReadStatus/" + image;
                //string userName = WebConfigurationManager.AppSettings["baseurl"];
                ////string uri = userName+"/api/NotificationReadStatus/" + arun;
                //string uri = userName + "" + image;



                //string path = System.IO.Path.Combine(System.Web.HttpContext.Current.Request.PhysicalApplicationPath, "Image-Upload");
                //System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(path);
                //System.Security.AccessControl.DirectorySecurity DirPermission = new System.Security.AccessControl.DirectorySecurity();
                //System.Security.AccessControl.FileSystemAccessRule FRule = new System.Security.AccessControl.FileSystemAccessRule
                //    ("Everyone", System.Security.AccessControl.FileSystemRights.ReadAndExecute, System.Security.AccessControl.AccessControlType.Allow);
                //DirPermission.AddAccessRule(FRule);

                //if (DirInfo.Exists == false)
                //{
                //    System.IO.Directory.CreateDirectory(path);
                //}

                using (context = new AdvocateHealthCareEntities())
                    ImagesList = context.spGetUserSavedImages(userId).Select(x => new MODEL.UserSavedImages
                        {
                            JournalTitle = x.JournalTitle,
                            JournalAsset = x.JournalAsset,
                            CreatedDate = x.DisplayDate
                        }).ToList();
                UserSavedImages usi = new UserSavedImages();
               // usi.JournalAsset = "http://183.82.48.194:5560/Images-Upload/camera.jpg";
                 usi.JournalAsset ="/Images-Upload/camera.png";
              //usi.JournalAsset = "~/Images-Upload/camera-updated.png";
               
                ImagesList.Insert(0, usi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ImagesList;
        }
        #endregion
    }
}
