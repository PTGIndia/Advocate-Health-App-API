using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class HospitalInfoDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        #region Save + Update
          
        public int Save(HospitalInfo hospitalinfo, DBNull t2)
        {
           
            var result = 0;
            var dbCtx = new AdvocateHealthCareEntities();
            var dtHospitalInfoType = new DataTable();

            dtHospitalInfoType.Columns.Add("HospitalID", typeof(int));
            dtHospitalInfoType.Columns.Add("HospitalName", typeof(string));
            dtHospitalInfoType.Columns.Add("Description", typeof(string));
            dtHospitalInfoType.Columns.Add("CreatedDate", typeof(DateTime));
            dtHospitalInfoType.Columns.Add("CreatedBy", typeof(string));
            dtHospitalInfoType.Columns.Add("ModifiedDate", typeof(DateTime));
            dtHospitalInfoType.Columns.Add("ModifiedBy", typeof(string));

            //dtHospitalInfoType.Rows.Add(hospitalinfo.HospitalID, hospitalinfo.HospitalName, hospitalinfo.Description,
            //                                hospitalinfo.CreatedDate, hospitalinfo.CreatedBy, hospitalinfo.ModifiedDate,
            //                                hospitalinfo.ModifiedBy);
            dtHospitalInfoType.Rows.Add(7, "dsggcxcf", "dsggfsf",
                                      null, null, null,
                                      null);


            var spSaveHospitalInfo = new SqlParameter();
            spSaveHospitalInfo.ParameterName = "@HospitalType";
            spSaveHospitalInfo.Value = dtHospitalInfoType;
            spSaveHospitalInfo.SqlDbType = SqlDbType.Structured;
            spSaveHospitalInfo.TypeName = "HospitalType";


            var caseId = new SqlParameter("@LoggedInUser", SqlDbType.VarChar);
            //caseId.Value = hospitalinfo.LoggedInUser;
            caseId.Value = "PTG";
            result = dbCtx.Database.ExecuteSqlCommand("EXEC " + DataAccess.DataAccessConstants.SaveHospitalInfo + "@HospitalType, @LoggedInUser", new object[] { spSaveHospitalInfo, caseId });

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

        #region Fetch HospitalInfo
        public List<MODEL.HospitalInfo> GetAll()
        {
            List<MODEL.HospitalInfo> hosipitalDetailsList = null;
            try
            {
                using (context = new AdvocateHealthCareEntities())

                    hosipitalDetailsList = context.spGetHosipitalDetails().Select(x => new MODEL.HospitalInfo
                       {
                           HospitalID = x.HospitalID,
                           HospitalName = x.HospitalName,
                       }).ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return hosipitalDetailsList;
        }
        #endregion
    }
}


