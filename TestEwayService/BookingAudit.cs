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
    
    public partial class BookingAudit
    {
        public int Id { get; set; }
        public Nullable<int> BillingId { get; set; }
        public string XmlOld { get; set; }
        public string XmlNew { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public string Caller { get; set; }
        public System.Guid TransactionId { get; set; }
    
        public virtual Billing Billing { get; set; }
        public virtual User User { get; set; }
    }
}