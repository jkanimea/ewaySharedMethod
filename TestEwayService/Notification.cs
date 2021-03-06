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
    
    public partial class Notification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notification()
        {
            this.Notification_User = new HashSet<Notification_User>();
            this.NotificationInstances = new HashSet<NotificationInstance>();
        }
    
        public int Id { get; set; }
        public int Type_id { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string Role { get; set; }
        public Nullable<bool> AllowChange { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification_User> Notification_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInstance> NotificationInstances { get; set; }
    }
}
