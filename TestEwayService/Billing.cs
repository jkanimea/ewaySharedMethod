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
    
    public partial class Billing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billing()
        {
            this.BillingDiscounts = new HashSet<BillingDiscount>();
            this.BillingExtras = new HashSet<BillingExtra>();
            this.Bookings = new HashSet<Booking>();
            this.BookingAudits = new HashSet<BookingAudit>();
            this.ChildDiscountHistoryLookups = new HashSet<ChildDiscountHistoryLookup>();
            this.CreditNotes = new HashSet<CreditNote>();
            this.DefaultBillingDiscounts = new HashSet<DefaultBillingDiscount>();
            this.Invoices = new HashSet<Invoice>();
            this.Payments = new HashSet<Payment>();
            this.XeroEditBookingQueues = new HashSet<XeroEditBookingQueue>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> PromoCodeId { get; set; }
        public Nullable<int> PaymentOptionId { get; set; }
        public Nullable<int> TermId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> OriginalCost { get; set; }
        public Nullable<decimal> EstimatedCost { get; set; }
        public Nullable<decimal> FinalCost { get; set; }
        public Nullable<decimal> EstimatedOscar { get; set; }
        public Nullable<bool> HasSentToXero { get; set; }
        public Nullable<decimal> PromoAmount { get; set; }
        public Nullable<decimal> PromoPercentage { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string Name { get; set; }
        public Nullable<int> BookingTemplateId { get; set; }
        public Nullable<decimal> TotalExtraInvLineAmount { get; set; }
        public string ExtraLineType { get; set; }
        public string ParentNotes { get; set; }
        public Nullable<bool> OscarIntended { get; set; }
        public Nullable<bool> IsMadeFromTemplate { get; set; }
        public Nullable<bool> IsQuickBooked { get; set; }
        public Nullable<bool> RollOverIntended { get; set; }
    
        public virtual BookingTemplate BookingTemplate { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Org Org { get; set; }
        public virtual PromoCode PromoCode { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingDiscount> BillingDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingExtra> BillingExtras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingAudit> BookingAudits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildDiscountHistoryLookup> ChildDiscountHistoryLookups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultBillingDiscount> DefaultBillingDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeroEditBookingQueue> XeroEditBookingQueues { get; set; }
    }
}
