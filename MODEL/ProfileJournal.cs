using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ProfileJournal
    {
        public string ProfileJournalID { get; set; }
        public int ProfileID { get; set; }
        public string JournalTitle { get; set; }
        public string JournalInfo { get; set; }
        public string JournalAsset { get; set; }
        public byte JournalTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LoggedInUser { get; set; }
        public string Picture { get; set; }
      
    }
}
