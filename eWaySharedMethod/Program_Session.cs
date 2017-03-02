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
    
    public partial class Program_Session
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int SessionId { get; set; }
        public Nullable<int> XeroItemCodeId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Program Program { get; set; }
        public virtual Session Session { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
    }
}
