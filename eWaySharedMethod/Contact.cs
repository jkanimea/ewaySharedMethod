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
    
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            this.Children = new HashSet<Child>();
            this.Children1 = new HashSet<Child>();
            this.Children2 = new HashSet<Child>();
            this.Child_Contact = new HashSet<Child_Contact>();
            this.Guardian_Child = new HashSet<Guardian_Child>();
            this.Orgs = new HashSet<Org>();
            this.Org_Contact = new HashSet<Org_Contact>();
            this.School_Contact = new HashSet<School_Contact>();
            this.SignoutSignatures = new HashSet<SignoutSignature>();
            this.Users = new HashSet<User>();
            this.User_Contact = new HashSet<User_Contact>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public byte[] SignatureImage { get; set; }
        public string Landline { get; set; }
        public string Office { get; set; }
        public string OfficeExtension { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string StreetNum { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string BillingStreetNum { get; set; }
        public string BillingAddress { get; set; }
        public string BillingSuburb { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingCountry { get; set; }
        public string OscarNum { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public string Relation { get; set; }
        public string HowHear { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public bool FirstAidCheck { get; set; }
        public Nullable<System.DateTime> FirstAidExpireyDate { get; set; }
        public bool PoliceCheck { get; set; }
        public Nullable<System.DateTime> PoliceCheckExprieyDate { get; set; }
        public string Notes { get; set; }
        public string DriverLicence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child> Children { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child> Children1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child> Children2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child_Contact> Child_Contact { get; set; }
        public virtual Lookup Lookup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guardian_Child> Guardian_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org> Orgs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Contact> Org_Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<School_Contact> School_Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SignoutSignature> SignoutSignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Contact> User_Contact { get; set; }
    }
}
