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
    
    public partial class EventDuration
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string EventCode { get; set; }
        public System.DateTime StartOn { get; set; }
        public Nullable<System.DateTime> FinishOn { get; set; }
        public Nullable<bool> IsSync { get; set; }
        public Nullable<System.DateTime> SyncOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    
        public virtual User User { get; set; }
    }
}
