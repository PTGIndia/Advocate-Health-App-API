//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hospital
    {
        public Hospital()
        {
            this.HospitalImages = new HashSet<HospitalImages>();
            this.Profile = new HashSet<Profile>();
        }
    
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<HospitalImages> HospitalImages { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
    }
}
