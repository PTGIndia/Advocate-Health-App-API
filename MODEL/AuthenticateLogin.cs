using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class AuthenticateLogin
    {
        public int ProfileID { get; set; }
        public int HospitalID { get; set; }

        public bool? Flag { get; set; }
        //public bool isValidUser { get; set; }
    }
}
