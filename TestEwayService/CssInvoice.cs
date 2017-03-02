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
    
    public partial class CssInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CssInvoice()
        {
            this.CssInvoiceLines = new HashSet<CssInvoiceLine>();
            this.XeroCSSInvoiceQueues = new HashSet<XeroCSSInvoiceQueue>();
            this.XeroCSSInvoiceUpdateQueues = new HashSet<XeroCSSInvoiceUpdateQueue>();
        }
    
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int OrgId { get; set; }
        public Nullable<System.Guid> XeroInvoiceId { get; set; }
        public string XeroInvoiceCode { get; set; }
        public string Reference { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string DiscountReason { get; set; }
        public System.DateTime PeriodStart { get; set; }
        public System.DateTime PeriodEnd { get; set; }
        public Nullable<decimal> AmountDue { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Error { get; set; }
        public string ErrorDescription { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> XeroUpdatedDateUTC { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Org Org { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CssInvoiceLine> CssInvoiceLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeroCSSInvoiceQueue> XeroCSSInvoiceQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeroCSSInvoiceUpdateQueue> XeroCSSInvoiceUpdateQueues { get; set; }
    }
}
