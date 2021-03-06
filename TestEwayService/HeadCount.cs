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
    
    public partial class HeadCount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeadCount()
        {
            this.HeadCountLines = new HashSet<HeadCountLine>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> SiteId { get; set; }
        public string ProgramName { get; set; }
        public string GroupName { get; set; }
        public string SessionName { get; set; }
        public Nullable<System.DateTime> Day { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Org Org { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeadCountLine> HeadCountLines { get; set; }
    }
}
