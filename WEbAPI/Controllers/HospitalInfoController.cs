using DAL;
using HCP.WebAPI.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WEbAPI.Controllers
{
    public class HospitalInfoController : ApiController
    {
        #region Variable
        LogEntry objHelper = new LogEntry();
        #endregion
        #region Hospita lInfo Save + Update
        [AcceptVerbs("GET", "POST")]
        public int SaveHospitalInfo(HospitalInfo hospitalinfo)
        {
            try
            {
                List<HospitalInfo> hospital = new List<HospitalInfo>();
                return new HospitalInfoDAL().Save(hospitalinfo, DBNull.Value);
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> HospitalInfoController--> SaveHospitalInfo-->" + ex.Message);

                //throw ex;
            }
            return 0;
        }
        #endregion

        #region Fetch Data
        /// <summary>
        /// This method is return the Hospital Information
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]

        public List<HospitalInfo> GetHosipitalDetails()
        {
            List<HospitalInfo> hosipitalDetailsList = new List<HospitalInfo>();
            try
            {
                hosipitalDetailsList = new HospitalInfoDAL().GetAll();
            }
            catch (Exception ex)
            {
                objHelper.WriteErrorLog("HCP.WebAPI --> HospitalInfoController--> GetHosipitalDetails-->" + ex.Message);

                //throw ex;
            }
            return hosipitalDetailsList;
        }
        #endregion
    }
}
