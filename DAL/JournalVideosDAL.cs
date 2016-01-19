using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class JournalVideosDAL
    {
        #region "Variable"
        AdvocateHealthCareEntities context = null;
        #endregion
        

        #region Fetch WeightEntries
         //public List<MODEL.JournalVideos> GetAll()
        /// <summary>
        /// this method is used to get the videos based on SUBCATEGORYID
        /// </summary>
        /// <param name="SUBCATEGORYID"></param>
        /// <returns></returns>
        public List<MODEL.JournalVideos> GetAll(int? SUBCATEGORYID)
        {
            List<MODEL.JournalVideos> JournalVideosList = null;
            try
            {
                
                using (context = new AdvocateHealthCareEntities())
                    JournalVideosList = context.spGetJournalVideos(SUBCATEGORYID).Select(x => new MODEL.JournalVideos
                        {
                            JournalVideoName = x.JournalVideoName,
                            JournalVideoAsset = x.JournalVideoAsset
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return JournalVideosList;
        }
        #endregion
    }
}
