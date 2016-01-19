using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Drawing.Imaging;

namespace MODEL
{
    public class Home
    {
        public string DocName { get; set; }
        public string DocDescription { get; set; }
        public string DocDesignation { get; set; }
        public string DocSpecialization { get; set; }
        public string DocImage { get; set; }
       public string UserName { get; set; }
       
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime DateOfMissPeriod { get; set; }
        public string primarycarehospital { get; set; }

         public DateTime NotificationDate { get; set; }
         public string NotificationText { get; set; }
         public string NotificationTitle { get; set; }
        // public string NotificationTitle { get; set; }
         public int NotificationType{get;set;}
         public int HospitalId{get;set;}
         public string HospitalName{get;set;}

        //DietPregnancy
        
            
            public string Text{get;set;}
            public int JournalTypeId{get;set;}
            public string TypeOfText{get;set;}

        //Journal Screen
         public DateTime JournalDateTime { get; set; }
         public string JournalText { get; set; }
         public string JournalTitle { get; set; }

         //QuestionScreen
         public DateTime? QuestionDateTime { get; set; }
         public string QuestionText { get; set; }
         public string QuestionTitle { get; set; }

        //GetWeightEntries
        public int WeightTrackerID{get;set;} 
        public decimal Weight{get;set;}
        public DateTime Date { get; set; }
        public bool flag { get; set; }

        //SaveImage
         public int UserId{get;set;} 
         public DateTime CreatedDate { get; set; }
        public string ImageStream{get;set;}
      
    }
}
