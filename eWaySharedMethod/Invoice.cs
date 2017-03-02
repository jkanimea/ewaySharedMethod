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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.CreditNote_LineItem = new HashSet<CreditNote_LineItem>();
            this.CreditNote_LineItem1 = new HashSet<CreditNote_LineItem>();
            this.DeletingInvoiceQueues = new HashSet<DeletingInvoiceQueue>();
            this.InvoiceLines = new HashSet<InvoiceLine>();
            this.InvoicePayments = new HashSet<InvoicePayment>();
            this.PaymentSources = new HashSet<PaymentSource>();
            this.Payments = new HashSet<Payment>();
            this.SubsidyPayments = new HashSet<SubsidyPayment>();
            this.XeroEditInvoiceQueues = new HashSet<XeroEditInvoiceQueue>();
            this.XeroInvoiceQueues = new HashSet<XeroInvoiceQueue>();
        }
    
        public int Id { get; set; }
        public int BillingId { get; set; }
        public int StatusId { get; set; }
        public Nullable<System.Guid> XeroInvoiceId { get; set; }
        public string XeroInvoiceCode { get; set; }
        public string Reference { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string DiscountReason { get; set; }
        public System.DateTime PeriodStart { get; set; }
        public System.DateTime PeriodEnd { get; set; }
        public Nullable<System.DateTime> LastAttDate { get; set; }
        public Nullable<System.DateTime> FirstAttDate { get; set; }
        public Nullable<decimal> AmountDue { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public Nullable<decimal> AmountCredited { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Description { get; set; }
        public bool Error { get; set; }
        public string ErrorDescription { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> XeroUpdatedDateUTC { get; set; }
        public string InvoiceType { get; set; }
        public string EmailStatus { get; set; }
        public string EmailToken { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Billing Billing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNote_LineItem> CreditNote_LineItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNote_LineItem> CreditNote_LineItem1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeletingInvoiceQueue> DeletingInvoiceQueues { get; set; }
        public virtual Lookup Lookup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentSource> PaymentSources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubsidyPayment> SubsidyPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeroEditInvoiceQueue> XeroEditInvoiceQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeroInvoiceQueue> XeroInvoiceQueues { get; set; }
    }
}
