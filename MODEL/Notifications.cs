using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Notifications
    {
        public int? HospitalID { get; set; }
        public string UserName { get; set; }
        public int? NotificationID { get; set; }
        public string NotificationText { get; set; }
        public string NotificationTitle { get; set; }
        public string TypeOfNotification { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string HospitalName { get; set; }




       

    }
}
