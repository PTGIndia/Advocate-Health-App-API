using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
   public class TilesDAL
    {
       #region "Variable"
       AdvocateHealthCareEntities context = null;
       #endregion

       #region Fetch TilesInfo
       public List<MODEL.Tiles> GetAll(int? SUBCATEGORYID)
       {
           List<MODEL.Tiles> TilesList = null;
           try
           {
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

                   TilesList = context.spGetTiles(SUBCATEGORYID).Select(x => new MODEL.Tiles
                   {
                       TITLE=x.TITLE,
                       CONTENT=x.CONTENT,
                       TITLEIMAGE = x.TILEIMAGE
                   }).ToList();
           }

           catch (Exception ex)
           {
               throw ex;
           }
           return TilesList;
       }

      
       #endregion
    }
}
