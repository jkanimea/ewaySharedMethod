//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eWaySharedMethod
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffRosterStage
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public System.DateTime RosterDayStartTime { get; set; }
        public System.DateTime RosterDayEndTime { get; set; }
        public string NoteforStaff { get; set; }
        public decimal PayAmount { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool IsProcessed { get; set; }
    }
}
