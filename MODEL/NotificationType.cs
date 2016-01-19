using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class NotificationType
    {
        public int NotificationID { get; set; }
        public byte NotificationTypeID { get; set; }
        public int ProfileID { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public bool? IsRead { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LoggedInUser { get; set; }

    }
}
