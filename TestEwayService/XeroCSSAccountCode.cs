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
    
    public partial class XeroCSSAccountCode
    {
        public int Id { get; set; }
        public System.Guid XeroTransactionId { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TaxRate { get; set; }
        public Nullable<System.DateTime> XeroLastUpdatedUTC { get; set; }
        public string XeroStatus { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool IsActive { get; set; }
    }
}
