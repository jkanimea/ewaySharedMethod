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
    
    public partial class ActivityInstance_Child
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ActivityInstanceId { get; set; }
        public string Comment { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual Child Child { get; set; }
    }
}