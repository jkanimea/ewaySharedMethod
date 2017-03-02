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
    
    public partial class RollCallQueue
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int AttendanceId { get; set; }
        public int ProgramCategoryType { get; set; }
        public int Method { get; set; }
        public int Direction { get; set; }
        public bool HasAttended { get; set; }
        public Nullable<System.DateTime> ActualStart { get; set; }
        public string ActualStartKeyedBy { get; set; }
        public string SignedInBy { get; set; }
        public Nullable<System.DateTime> ActualStartKeyedOn { get; set; }
        public string AbsentReason { get; set; }
        public Nullable<System.DateTime> ActualEnd { get; set; }
        public string ActualEndKeyedBy { get; set; }
        public Nullable<System.DateTime> ActualEndKeyedOn { get; set; }
        public string SignedBy { get; set; }
        public Nullable<int> SignatureId { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsProceed { get; set; }
        public Nullable<System.DateTime> ProceedOn { get; set; }
        public string ErrorMsg { get; set; }
    
        public virtual Attendance Attendance { get; set; }
        public virtual Child Child { get; set; }
        public virtual SignoutSignature SignoutSignature { get; set; }
    }
}
