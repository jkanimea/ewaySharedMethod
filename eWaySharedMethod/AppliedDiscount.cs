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
    
    public partial class AppliedDiscount
    {
        public int Id { get; set; }
        public int Booking_SptId { get; set; }
        public Nullable<int> ChildDiscountId { get; set; }
        public Nullable<decimal> DiscountedRate { get; set; }
        public string Description { get; set; }
        public decimal TotalAppliedAmount { get; set; }
        public decimal TotalAppliedPercentage { get; set; }
        public string DiscountType { get; set; }
        public string DiscountLogicType { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Booking_Spt Booking_Spt { get; set; }
        public virtual ChildDiscount ChildDiscount { get; set; }
    }
}
