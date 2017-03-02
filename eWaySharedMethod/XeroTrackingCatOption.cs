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
    
    public partial class XeroTrackingCatOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XeroTrackingCatOption()
        {
            this.BillingExtras = new HashSet<BillingExtra>();
            this.Bookings = new HashSet<Booking>();
            this.Booking_Spt = new HashSet<Booking_Spt>();
            this.InvoiceLines = new HashSet<InvoiceLine>();
            this.OrgSettings = new HashSet<OrgSetting>();
            this.OrgSettings1 = new HashSet<OrgSetting>();
            this.OrgSettings2 = new HashSet<OrgSetting>();
            this.OrgSettings3 = new HashSet<OrgSetting>();
            this.Programs = new HashSet<Program>();
            this.Site_Program_Term = new HashSet<Site_Program_Term>();
        }
    
        public int Id { get; set; }
        public int TrackingCatId { get; set; }
        public Nullable<System.Guid> XeroTrackingCatOptId { get; set; }
        public string CatOptName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingExtra> BillingExtras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Spt> Booking_Spt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgSetting> OrgSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgSetting> OrgSettings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgSetting> OrgSettings2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgSetting> OrgSettings3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Programs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site_Program_Term> Site_Program_Term { get; set; }
        public virtual XeroTrackingCategory XeroTrackingCategory { get; set; }
    }
}