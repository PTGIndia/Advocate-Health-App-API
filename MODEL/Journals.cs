using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Journals
    {
        public int? ProfileJournalID { get; set; }
        public string ProfileName { get; set; }
        public string JournalTitle { get; set; }
        public string JournalInfo { get; set; }
        //public string CreatedDate { get; set; }
        public string JournalAsset { get; set; }
        public DateTime? LMPDate { get; set; }
        public string CreatedDate { get; set; }
        //public string Displaydate { get; set; }
    }
}
