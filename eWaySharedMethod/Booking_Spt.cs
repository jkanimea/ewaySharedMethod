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
    
    public partial class Booking_Spt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking_Spt()
        {
            this.AppliedDiscounts = new HashSet<AppliedDiscount>();
            this.Attendances = new HashSet<Attendance>();
            this.InvoiceLines = new HashSet<InvoiceLine>();
            this.SiteGroup_Booking_Spt = new HashSet<SiteGroup_Booking_Spt>();
        }
    
        public int Id { get; set; }
        public Nullable<int> BookingId { get; set; }
        public Nullable<int> SptId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> ItemCodeId { get; set; }
        public Nullable<int> TrackingCodeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppliedDiscount> AppliedDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Site_Program_Term Site_Program_Term { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiteGroup_Booking_Spt> SiteGroup_Booking_Spt { get; set; }
    }
}
