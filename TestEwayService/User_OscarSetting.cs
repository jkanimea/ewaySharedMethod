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
    
    public partial class User_OscarSetting
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OscarSettingId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    
        public virtual OscarSetting OscarSetting { get; set; }
        public virtual User User { get; set; }
    }
}
