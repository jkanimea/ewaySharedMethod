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
    
    public partial class CssCreditCardAccessCode
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string AccessCode { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Org Org { get; set; }
    }
}
