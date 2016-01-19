using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEbAPI.Models;


namespace WEbAPI.Controllers
{
    public class AdvocateController : ApiController
    {
       // ProfilePage
         [AcceptVerbs("GET", "POST")]
         // public List<Home> SaveProfileData([FromBody] Home saveprofiledata)
        public Home SaveProfileData(string FirstName, string LastName, string EmailAddress, string Password, DateTime DateOfMissPeriod, string primarycarehospital)
         {
             Home Profile = new Home();
             try
             {
                 List<Home> saveprofile = new List<Home>();
                 
                 Profile.UserId = 1;
                 Profile.HospitalId = 1;
                 Profile.HospitalName = "Apollo";
                 return Profile;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

        //GetHosipitalDetails
        Home[] Details = new Home[] 
        {
             new Home { HospitalId = 1, HospitalName = "Apollo"},
             new Home { HospitalId = 2, HospitalName = "KIMS"}
        };
        // public Home[] GetJournalsForUserId(int UserId, int JournalTypeId)
        public Home[] GetHosipitalDetails()
        {
            List<Home> HosipitalDetailsTypeList = new List<Home>();
            try
            {
                return Details;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //post for Login

         // public List<Home> AuthenticateLogin([FromBody]Home authenticatelogindata)
         [AcceptVerbs("GET", "POST")]
         public Home AuthenticateLogin(string EmailAddress, string Password, bool flag)
         {
             Home login = new Home();
               flag=true;
               try
               {
                   if (flag == true)
                   {
                       List<Home> authenticate = new List<Home>();
                       login.UserId = 1;
                       login.HospitalId = 1;
                   }
               }

               catch (Exception ex)
               {
                   throw ex;
               }

               return login;
         }

        //get GetNotifications(working)
         Home[] Notifications = new Home[] 
        { 
            new Home { NotificationDate = Convert.ToDateTime("2015-10-16 00:00:00.000"), NotificationText = "Learn about Asem", NotificationTitle = "MD", NotificationType=1, HospitalId=1,HospitalName="kims" }, 
            new Home { NotificationDate = Convert.ToDateTime("2015-10-16 00:00:00.000"),   NotificationText = "obstetrician", NotificationTitle = "MD", NotificationType=1, HospitalId=1,HospitalName="kims" }, 
            new Home { NotificationDate =Convert.ToDateTime("2015-10-16 00:00:00.000"), NotificationText = "Advocate",NotificationTitle = "MD", NotificationType=1, HospitalId=1,HospitalName="kims" }, 
        };
       // public List<Home> GetNotifications(int UserId, int HospitalId)
         public Home[] GetNotifications(int UserId, int HospitalId)
        {
            List<Home> NotificationsTypeList = new List<Home>();
            try
            {
                return Notifications;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get User Navigates to Journal Screen
        Home[] Journal = new Home[] 
        { 
            new Home { JournalDateTime =Convert.ToDateTime("2015-10-16 00:00:00.000"), JournalText = "Learn about how Dr. Humera Asem", JournalTitle = "MD"}, 
            new Home { JournalDateTime =Convert.ToDateTime(" 2015-10-16 00:00:00.000"),   JournalText = "obstetrician and gynecologist", JournalTitle = "HR"},
            new Home { JournalDateTime = Convert.ToDateTime("2015-10-16 00:00:00.000"), JournalText = "Advocate Health Care,", JournalTitle = "MD",JournalTypeId=1}
        };

        public Home[] GetJournalsForUserId(int UserId, int JournalTypeId)
        {
            List<Home> JournalsTypeList = new List<Home>();
            try
            {
                return Journal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get QuestionsForUserId
        Home[] Questions = new Home[] 
          { 
              new Home { QuestionDateTime =Convert.ToDateTime("2015-10-16 00:00:00.000"),  QuestionText = "Learn about how Dr. Humera Asem", QuestionTitle = "MD"}, 
              new Home { QuestionDateTime =Convert.ToDateTime(" 2015-10-16 00:00:00.000"),   QuestionText = "obstetrician and gynecologist", QuestionTitle = "HR"},
              new Home { QuestionDateTime = Convert.ToDateTime("2015-10-16 00:00:00.000"), QuestionText = "Advocate Health Care,", QuestionTitle = "MD"}
          };
         // public Home[] GetJournalsForUserId(int UserId, int JournalTypeId)
       // public List<Home> GetQuestionsForUserId(int UserId)
              public Home[] GetQuestionsForUserId(int UserId)
            {
            List<Home> QuestionsTypeList = new List<Home>();
            try
            {
                return Questions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //save Journal\Question Entry
        //rajini
              [AcceptVerbs("GET", "POST")]
              //public List<Home> SaveJournalOrQuestions([FromBody] Home journalorquestionsdata)
              public Home SaveJournalOrQuestions(int UserId,string Text,int JournalTypeId)
              {
                  Home journal = new Home();
                  try
                  {

                      List<Home> journalorquestion = new List<Home>();
                      journal.UserId = 1;
                      journal.TypeOfText = "Jounal";
                      journal.UserName = "sarala";
                      journal.Text = "xyz";
                      journal.Date = Convert.ToDateTime("2015-10-16 00:00:00.000");
                      return journal;
                  }
                  catch (Exception ex)
                  {
                      throw ex;
                  }
              }
        //GetWeightEntries //working fine
        Home[] WeightEntries = new Home[] 
          { 
              new Home { WeightTrackerID=1, Weight=10.5M,  Date =  Convert.ToDateTime("2015-10-16 00:00:00.000")  }, 
              new Home {  WeightTrackerID=2, Weight=10.6M, Date = Convert.ToDateTime(" 2015-10-16 00:00:00.000")},
              new Home {  WeightTrackerID=3, Weight=10.7M, Date =  Convert.ToDateTime("2015-10-16 00:00:00.000")}
          };

        // public List<Home> GetWeightEntries(int UserId)

        public Home[] GetWeightEntries(int UserId)
        {
            List<Home> WeightEntriesTypeList = new List<Home>();
            try
            {
                return WeightEntries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //SaveWeight
        [AcceptVerbs("GET", "POST")]

        public Home SaveWeight(int UserId, DateTime Date, decimal Weight)
        {
            Home Weightobj = new Home();

            try
            {
                List<Home> journalorquestion = new List<Home>();
                Weightobj.WeightTrackerID = 1;
                Weightobj.Weight = 50.7M;
                Weightobj.Date = Convert.ToDateTime("2015-10-16 00:00:00.000");

                return Weightobj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
