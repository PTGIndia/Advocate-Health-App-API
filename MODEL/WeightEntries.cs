using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class WeightEntries
    {
       public decimal? Weight { get; set; }
       public DateTime? LMPDATE { get; set; }
       public string CreatedDate { get; set; }
       public string LoggedInUser { get; set; }
       public int WeightTrackerID { get; set; }
       public int? ProfileID { get; set; }
       //public DateTime? CreatedDate1 { get; set; } //this is for saveweightentries
         public  DateTime? DisplayDate { get; set; }

    }
}
