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
    
    public partial class Child_Condition
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public Nullable<int> ConditionId { get; set; }
        public string OtherName { get; set; }
        public Nullable<int> OtherTypeId { get; set; }
        public string Severity { get; set; }
        public string DoctorName { get; set; }
        public string DoctorContact { get; set; }
        public string Symptoms { get; set; }
        public string TreatmentDesc { get; set; }
        public string MedicationDesc { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual Condition Condition { get; set; }
    }
}
