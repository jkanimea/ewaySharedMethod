//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEwayService
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteNote
    {
        public int Id { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<int> ProgramCategoryId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Org Org { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
    }
}
