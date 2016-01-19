using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class HospitalImageController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion

        #region Fetch HospitalImage
        [AcceptVerbs("GET", "POST")]
        public List<MODEL.HospitalImages> GetHosipitalImages(int UserID, int HospitalID, byte? AssetPositionID)
        {
            List<MODEL.HospitalImages> hosipitallImagesList = new List<MODEL.HospitalImages>();
            try
            {
                hosipitallImagesList = new HospitalImagesDAL().GetAll(UserID, HospitalID, AssetPositionID);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> HospitalImageController--> GetHosipitalImages-->" + ex.Message);

                //throw ex;
            }
            return hosipitallImagesList;
        }
        #endregion

        #region Hospital Image Save + Update

        [AcceptVerbs("GET", "POST")]       
        public int SaveHospitalImages(MODEL.HospitalImages hospitalimages)
        {
            try
            {
                List<MODEL.HospitalImages> profile = new List<MODEL.HospitalImages>();
                return new HospitalImagesDAL().Save(hospitalimages, DBNull.Value);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> HospitalImageController--> SaveHospitalImages-->" + ex.Message);

               // throw ex;
            }
            return 0;
        }
        #endregion
    }
}
