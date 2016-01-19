using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
   public class HospitalImagesDAL
    {
       #region "Variable"
       AdvocateHealthCareEntities context = null;
       #endregion

       #region Fetch HospitalImages
       /// <summary>
       /// This method is used to get the images based on Hospital selection
       /// </summary>
       /// <param name="UserID"></param>
       /// <param name="HospitalID"></param>
       /// <param name="AssetPositionID"></param>
       /// <returns></returns>
       public List<MODEL.HospitalImages> GetAll(int UserID, int HospitalID, byte? AssetPositionID)
    
       {
           List<MODEL.HospitalImages> HospitalImagesList = null;
           try
           {
                using (context = new AdvocateHealthCareEntities())
                    HospitalImagesList = context.spGetHosipitalImages(UserID, HospitalID, AssetPositionID).Select(x => new MODEL.HospitalImages
                   {
                       AssetURL=x.AssetURL,
                       AssetText=x.AssetText,
                       AssetImage=x.AssetImage,
                       AssetPositionID = x.AssetPositionID.Value

                   }).ToList();
           }
            catch (Exception ex)
            {
                throw ex;
            }
            return HospitalImagesList;
        }
        #endregion


       #region Hospital Images Save + Update
       /// <summary>
       /// This method is used to save the Hospital Images
       /// </summary>
       /// <param name="hospitalimages"></param>
       /// <param name="t2"></param>
       /// <returns></returns>
       public int Save(MODEL.HospitalImages hospitalimages, DBNull t2)
       {
           var result = 0;
           var dbCtx = new AdvocateHealthCareEntities();
           var dtHospitalImagesType = new DataTable();
           dtHospitalImagesType.Columns.Add("HospitalImagesID", typeof(int));
           dtHospitalImagesType.Columns.Add("HospitalID", typeof(int));
           dtHospitalImagesType.Columns.Add("AssetURL", typeof(string));
           dtHospitalImagesType.Columns.Add("AssetText", typeof(string));
           dtHospitalImagesType.Columns.Add("AssetImage", typeof(string));
           dtHospitalImagesType.Columns.Add("AssetPositionID", typeof(byte));

            dtHospitalImagesType.Rows.Add(hospitalimages.HospitalImagesID, hospitalimages.HospitalID,
                                         hospitalimages.AssetURL, hospitalimages.AssetText, hospitalimages.AssetImage,hospitalimages.AssetPositionID);

         //  dtHospitalImagesType.Rows.Add(null,4,null);

           var spSaveHospitalImages = new SqlParameter();
           spSaveHospitalImages.ParameterName = "@HospitalImagesType";
           spSaveHospitalImages.Value = dtHospitalImagesType;
           spSaveHospitalImages.SqlDbType = SqlDbType.Structured;
           spSaveHospitalImages.TypeName = "HospitalImagesType";

           var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
            //caseId.Value = "PTG";
          caseId.Value = hospitalimages.LoggedInUser;

           result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveHospitalImages + " @HospitalImagesType, @LoggedInUser", new object[] { spSaveHospitalImages, caseId });

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
