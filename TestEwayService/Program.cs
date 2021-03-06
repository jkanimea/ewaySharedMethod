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
    
    public partial class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program()
        {
            this.ChildDiscounts = new HashSet<ChildDiscount>();
            this.Program_Media = new HashSet<Program_Media>();
            this.Program1 = new HashSet<Program>();
            this.Program_Session = new HashSet<Program_Session>();
            this.Program_Tags = new HashSet<Program_Tags>();
            this.Site_Program_Term = new HashSet<Site_Program_Term>();
            this.Spt_Instance = new HashSet<Spt_Instance>();
        }
    
        public int Id { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeName1 { get; set; }
        public string TimeName2 { get; set; }
        public string TimeName3 { get; set; }
        public string TimeName4 { get; set; }
        public string TimeName5 { get; set; }
        public string TimeName6 { get; set; }
        public Nullable<System.TimeSpan> TimeStart1 { get; set; }
        public Nullable<System.TimeSpan> TimeStart2 { get; set; }
        public Nullable<System.TimeSpan> TimeStart3 { get; set; }
        public Nullable<System.TimeSpan> TimeStart4 { get; set; }
        public Nullable<System.TimeSpan> TimeStart5 { get; set; }
        public Nullable<System.TimeSpan> TimeStart6 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd1 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd2 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd3 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd4 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd5 { get; set; }
        public Nullable<System.TimeSpan> TimeEnd6 { get; set; }
        public string TimeDescription1 { get; set; }
        public string TimeDescription2 { get; set; }
        public string TimeDescription3 { get; set; }
        public string TimeDescription4 { get; set; }
        public string TimeDescription5 { get; set; }
        public string TimeDescription6 { get; set; }
        public Nullable<decimal> RateFullTime { get; set; }
        public Nullable<decimal> RatePartTime { get; set; }
        public Nullable<decimal> RateCasual { get; set; }
        public Nullable<decimal> Rate1 { get; set; }
        public Nullable<decimal> Rate2 { get; set; }
        public Nullable<decimal> Rate3 { get; set; }
        public Nullable<decimal> Rate4 { get; set; }
        public Nullable<decimal> Rate5 { get; set; }
        public Nullable<decimal> Rate6 { get; set; }
        public Nullable<int> MinAge { get; set; }
        public Nullable<int> MaxAge { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<int> Index { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public Nullable<int> HolFullTimeItemCodeId { get; set; }
        public Nullable<int> HolShortItemCodeId { get; set; }
        public Nullable<int> HolTripItemCodeId { get; set; }
        public Nullable<int> PartTimeItemCodeId { get; set; }
        public Nullable<int> SpecialCodeId { get; set; }
        public Nullable<int> HolPartTimeAMItemCodeId { get; set; }
        public Nullable<int> HolPartTimePMItemCodeId { get; set; }
        public Nullable<int> FullTimeItemCodeId { get; set; }
        public Nullable<int> CasualItemCodeId { get; set; }
        public Nullable<int> TrackingCatOptionId { get; set; }
        public Nullable<int> CostType { get; set; }
        public Nullable<bool> IsFullDay { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Color { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Tags { get; set; }
        public Nullable<int> ViewCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildDiscount> ChildDiscounts { get; set; }
        public virtual Org Org { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program_Media> Program_Media { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Program1 { get; set; }
        public virtual Program Program2 { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program_Session> Program_Session { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program_Tags> Program_Tags { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
        public virtual XeroItemCode XeroItemCode1 { get; set; }
        public virtual XeroItemCode XeroItemCode2 { get; set; }
        public virtual XeroItemCode XeroItemCode3 { get; set; }
        public virtual XeroItemCode XeroItemCode4 { get; set; }
        public virtual XeroItemCode XeroItemCode5 { get; set; }
        public virtual XeroItemCode XeroItemCode6 { get; set; }
        public virtual XeroItemCode XeroItemCode7 { get; set; }
        public virtual XeroItemCode XeroItemCode8 { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site_Program_Term> Site_Program_Term { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spt_Instance> Spt_Instance { get; set; }
    }
}
