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
    
    public partial class CreditNote_LineItem
    {
        public int Id { get; set; }
        public int CreditNoteId { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<int> OldInvoiceId { get; set; }
        public Nullable<int> XeroItemCodeId { get; set; }
        public string Description { get; set; }
        public decimal AppliedAmount { get; set; }
        public System.DateTime AppliedDate { get; set; }
        public string XeroAccCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    
        public virtual CreditNote CreditNote { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
        public virtual Invoice Invoice1 { get; set; }
    }
}
