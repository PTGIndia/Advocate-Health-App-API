using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
   public class ContentSearchDAL
    {
       #region "Variable"
       AdvocateHealthCareEntities context = null;
       #endregion
       #region Fetch ContentSearchInfo
       public List<MODEL.ContentSearch> GetAll(string String )
       {
           List<MODEL.ContentSearch> ContentSearchList = null;
           try
           {
              
               using (context = new AdvocateHealthCareEntities())
                   ContentSearchList = context.spGetContentSearch(String).Select(x => new MODEL.ContentSearch
                   {
                       Title=x.Title,
                       Content=x.Content,
                       TileImage=x.TileImage
                   }).ToList();
           }

           catch (Exception ex)
           {
               throw ex;
           }
           return ContentSearchList;
       }
       #endregion
    }
}