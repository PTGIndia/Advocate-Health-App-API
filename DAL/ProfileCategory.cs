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
    
    public partial class ProfileCategory
    {
        public int ProfileCategoryID { get; set; }
        public int ProfileID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Profile Profile { get; set; }
    }
}