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
    
    public partial class InvoicePayment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public System.Guid XeroPaymentId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public System.DateTime XeroUpdatedDateUTC { get; set; }
        public System.DateTime XeroDateCreated { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
