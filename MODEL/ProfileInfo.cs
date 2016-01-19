using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class ProfileInfo
    {        
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? LMPdate { get; set; }
        public string Picture { get; set; }
       // public byte[] picture1 { get; set; }
        public int HospitalID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LoggedInUser { get; set; }
        //public string LoggedInUser {
        //    get { return FirstName + " " + LastName; }
        //}

    }
}
