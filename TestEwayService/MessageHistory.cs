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
    
    public partial class MessageHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Recipients { get; set; }
        public string DeliveryMethod { get; set; }
        public string Subject { get; set; }
        public string Data { get; set; }
        public System.DateTime DateSent { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> SiteId { get; set; }
    
        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
