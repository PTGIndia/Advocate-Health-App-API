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
    
    public partial class Category
    {
        public Category()
        {
            this.ProfileCategory = new HashSet<ProfileCategory>();
            this.SubCategory = new HashSet<SubCategory>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual ICollection<ProfileCategory> ProfileCategory { get; set; }
        public virtual ICollection<SubCategory> SubCategory { get; set; }
    }
}