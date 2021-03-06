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
    
    public partial class Attendance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attendance()
        {
            this.Attendance_Portfolio = new HashSet<Attendance_Portfolio>();
            this.HeadCountLines = new HashSet<HeadCountLine>();
            this.RollCallQueues = new HashSet<RollCallQueue>();
        }
    
        public int Id { get; set; }
        public int ChildId { get; set; }
        public System.DateTime Day { get; set; }
        public Nullable<int> SignoutSignatureId { get; set; }
        public int Booking_SptId { get; set; }
        public bool HasAttended { get; set; }
        public System.DateTime BookedStart { get; set; }
        public System.DateTime BookedEnd { get; set; }
        public Nullable<System.DateTime> ActualStart { get; set; }
        public Nullable<System.DateTime> ActualEnd { get; set; }
        public string ActualStartKeyedBy { get; set; }
        public Nullable<System.DateTime> ActualStartKeyedOn { get; set; }
        public string ActualStartKeyedAt { get; set; }
        public string ActualEndKeyedBy { get; set; }
        public Nullable<System.DateTime> ActualEndKeyedOn { get; set; }
        public string ActualEndKeyedAt { get; set; }
        public Nullable<int> ExtraMins { get; set; }
        public Nullable<decimal> CostAdjustment { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public Nullable<int> ActualCostBy { get; set; }
        public string CostComment { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string SignedBy { get; set; }
        public Nullable<bool> IsAdjusted { get; set; }
        public Nullable<bool> IsInvoiced { get; set; }
        public string Status { get; set; }
        public Nullable<bool> ShouldPickup { get; set; }
        public Nullable<bool> HasPickedUp { get; set; }
        public Nullable<System.DateTime> PickupKeyedOn { get; set; }
        public string PickupKeyedAt { get; set; }
        public string PickupKeyedBy { get; set; }
        public string NoPickUpReason { get; set; }
        public string AbsentReason { get; set; }
        public Nullable<int> SignInSignatureId { get; set; }
        public Nullable<bool> IsMarkedAbsent { get; set; }
        public Nullable<int> SessionId { get; set; }
        public string SessionName { get; set; }
        public string SignedInBy { get; set; }
        public Nullable<int> DayIndex { get; set; }
        public Nullable<int> RollCallStatus { get; set; }
    
        public virtual Booking_Spt Booking_Spt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance_Portfolio> Attendance_Portfolio { get; set; }
        public virtual Session Session { get; set; }
        public virtual SignoutSignature SignoutSignature { get; set; }
        public virtual SignoutSignature SignoutSignature1 { get; set; }
        public virtual User User { get; set; }
        public virtual Child Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeadCountLine> HeadCountLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RollCallQueue> RollCallQueues { get; set; }
    }
}
