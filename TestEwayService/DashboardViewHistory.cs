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
    
    public partial class DashboardViewHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProgramCategoryId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
    
        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual User User { get; set; }
    }
}
