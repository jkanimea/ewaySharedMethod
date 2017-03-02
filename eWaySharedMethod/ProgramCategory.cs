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
    
    public partial class ProgramCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramCategory()
        {
            this.Bookings = new HashSet<Booking>();
            this.ChildDiscounts = new HashSet<ChildDiscount>();
            this.DashboardViewHistories = new HashSet<DashboardViewHistory>();
            this.Programs = new HashSet<Program>();
            this.Site_Program_Term = new HashSet<Site_Program_Term>();
            this.SiteNotes = new HashSet<SiteNote>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> BookingTemplateId { get; set; }
        public string Code { get; set; }
        public Nullable<bool> IsApprovedByMinistrySocialDev { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> SignInStrategyId { get; set; }
        public Nullable<int> SignOutStrategyId { get; set; }
        public Nullable<int> SignInMethodId { get; set; }
        public Nullable<int> SignOutMethodId { get; set; }
        public Nullable<bool> AllowDriverPickup { get; set; }
        public Nullable<bool> AllowOnsitePickup { get; set; }
        public Nullable<bool> HasSession { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildDiscount> ChildDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DashboardViewHistory> DashboardViewHistories { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Lookup Lookup1 { get; set; }
        public virtual Lookup Lookup2 { get; set; }
        public virtual Lookup Lookup3 { get; set; }
        public virtual Lookup Lookup4 { get; set; }
        public virtual Lookup Lookup5 { get; set; }
        public virtual Org Org { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Programs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site_Program_Term> Site_Program_Term { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiteNote> SiteNotes { get; set; }
    }
}