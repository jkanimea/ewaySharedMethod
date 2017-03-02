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
    
    public partial class Child
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Child()
        {
            this.AchievementTrackings = new HashSet<AchievementTracking>();
            this.ActivityInstance_Child = new HashSet<ActivityInstance_Child>();
            this.Attendances = new HashSet<Attendance>();
            this.Attendance_Portfolio = new HashSet<Attendance_Portfolio>();
            this.Bookings = new HashSet<Booking>();
            this.BookingTemplateQueue_Child = new HashSet<BookingTemplateQueue_Child>();
            this.Child_Condition = new HashSet<Child_Condition>();
            this.Child_Contact = new HashSet<Child_Contact>();
            this.Child_Media = new HashSet<Child_Media>();
            this.Child_Timeline = new HashSet<Child_Timeline>();
            this.ChildDiscounts = new HashSet<ChildDiscount>();
            this.ChildNotes = new HashSet<ChildNote>();
            this.Guardian_Child = new HashSet<Guardian_Child>();
            this.Org_Child = new HashSet<Org_Child>();
            this.OscarDeclarations = new HashSet<OscarDeclaration>();
            this.OscarDelaration_Child = new HashSet<OscarDelaration_Child>();
            this.OscarTracking_Child = new HashSet<OscarTracking_Child>();
            this.RollCallQueues = new HashSet<RollCallQueue>();
            this.Subsidies = new HashSet<Subsidy>();
            this.User_Child = new HashSet<User_Child>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ContactId { get; set; }
        public string Name { get; set; }
        public string KnownName { get; set; }
        public Nullable<int> EmergencyContact1Id { get; set; }
        public Nullable<int> EmergencyContact2Id { get; set; }
        public Nullable<int> YearEnrolled { get; set; }
        public string Ethnicity { get; set; }
        public string LanguageSpoken { get; set; }
        public Nullable<bool> CustodyDispute { get; set; }
        public string CustodyDisputeDescription { get; set; }
        public Nullable<bool> WearsGlasses { get; set; }
        public Nullable<bool> HearingAid { get; set; }
        public string Instructions { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<bool> AllowPhotoTag { get; set; }
        public string ClassRoom { get; set; }
        public string TeacherName { get; set; }
        public Nullable<bool> CYF { get; set; }
        public string CYFDescription { get; set; }
        public Nullable<bool> IsVegererian { get; set; }
        public Nullable<bool> GlutenFree { get; set; }
        public string Notes { get; set; }
        public string ChildDoctorName { get; set; }
        public string ChildDoctorContact { get; set; }
        public Nullable<bool> IsTetanusImmunised { get; set; }
        public string SwimmingCompetency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AchievementTracking> AchievementTrackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityInstance_Child> ActivityInstance_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance_Portfolio> Attendance_Portfolio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingTemplateQueue_Child> BookingTemplateQueue_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child_Condition> Child_Condition { get; set; }
        public virtual Contact Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child_Contact> Child_Contact { get; set; }
        public virtual Contact Contact1 { get; set; }
        public virtual Contact Contact2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child_Media> Child_Media { get; set; }
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child_Timeline> Child_Timeline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildDiscount> ChildDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildNote> ChildNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guardian_Child> Guardian_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Child> Org_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OscarDeclaration> OscarDeclarations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OscarDelaration_Child> OscarDelaration_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OscarTracking_Child> OscarTracking_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RollCallQueue> RollCallQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subsidy> Subsidies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Child> User_Child { get; set; }
    }
}
