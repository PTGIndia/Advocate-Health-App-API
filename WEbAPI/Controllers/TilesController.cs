using DAL;
using HCP.WebAPI.Helper;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace WEbAPI.Controllers
{
    public class TilesController : ApiController
    {
        #region "Variable"
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Fetch Data
        [AcceptVerbs("GET", "POST")]
        //to get TilesById
        public List<MODEL.Tiles> GetTilesById(int? SUBCATEGORYID)
        {
            List<MODEL.Tiles> TilesDetails = new List<MODEL.Tiles>();
            try
            {
                TilesDetails = new TilesDAL().GetAll(SUBCATEGORYID);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> TilesController--> GetTilesById-->" + ex.Message);

                //throw ex;
            }
            return TilesDetails;
        }

        //To get all tiles

        //public List<MODEL.Tiles> GetTiles()
        //{
        //    List<MODEL.Tiles> TilesDetails = new List<MODEL.Tiles>();
        //    try
        //    {
        //        TilesDetails = new TilesDAL().GetAll(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return TilesDetails;
        //}
         #endregion
    }
}