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
    
    public partial class OrgNotificationSetting
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int NotificationType { get; set; }
        public bool IsActive { get; set; }
        public bool AllowNotification { get; set; }
        public Nullable<int> FirstDeliveryRule { get; set; }
        public Nullable<int> SecondDeliveryRule { get; set; }
        public Nullable<int> ThirdDeliveryRule { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual Org Org { get; set; }
    }
}
