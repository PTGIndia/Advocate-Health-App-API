using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
   public class JournalsDAL
    {
        #region "Variable"
       AdvocateHealthCareEntities context = null;
       #endregion
       #region Fetch JournalsInfo
       public List<MODEL.Journals> GetAll(int userId, int journalTypeId)
       {
           List<MODEL.Journals> JournalsList = null;
           try
           {
               using (context = new AdvocateHealthCareEntities())
                   JournalsList = context.spGetJournals(userId, journalTypeId).Select(x => new MODEL.Journals
                       {
                           ProfileJournalID=x.ProfileJournalID,
                           ProfileName=x.ProfileName,
                           JournalInfo = x.JournalInfo,
                           JournalTitle = x.JournalTitle,
                           JournalAsset =x.JournalAsset,
                           LMPDate=x.LMPdate,
                          // CreatedDate=x.CreatedDate,
                           CreatedDate = x.Displaydate
                       }).ToList();
               Journals js=new Journals();
               js.JournalInfo = "Ask a new question";
               js.JournalTitle = "Question for my care providor";
              // js.JournalAsset = "http://183.82.48.194:5560/Images-Upload/add_a_journal.jpg";
               js.JournalAsset = "/Images-Upload/add_a_journal_small.png";
               JournalsList.Insert(0, js);
           }
            catch (Exception ex)
           {
               throw ex;
           }
           return JournalsList;
       }
       #endregion
    }
}
