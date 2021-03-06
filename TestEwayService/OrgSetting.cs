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
    
    public partial class OrgSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgSetting()
        {
            this.DeletingInvoiceQueues = new HashSet<DeletingInvoiceQueue>();
        }
    
        public int OrgId { get; set; }
        public Nullable<decimal> ExtraMinRate { get; set; }
        public string XeroConsumerKey { get; set; }
        public Nullable<int> DefaultASCPTItemCodeId { get; set; }
        public Nullable<int> DefaultASCFTItemCodeId { get; set; }
        public Nullable<int> DefaultASCCItemCodeId { get; set; }
        public Nullable<int> DefaultBSCPTItemCodeId { get; set; }
        public Nullable<int> DefaultBSCFTItemCodeId { get; set; }
        public Nullable<int> DefaultBSCCItemCodeId { get; set; }
        public Nullable<int> DefaultHOLFItemCodeId { get; set; }
        public Nullable<int> DefaultSpecialItemCodeId { get; set; }
        public Nullable<int> DefaultASCTrackingId { get; set; }
        public Nullable<int> DefaultBSCTrackingId { get; set; }
        public Nullable<int> DefaultHolTrackingId { get; set; }
        public Nullable<int> DefaultSpecialTrackingId { get; set; }
        public Nullable<int> DefaultCCAccCodeId { get; set; }
        public Nullable<int> DefaultOPAccCodeId { get; set; }
        public Nullable<int> DefaultOSCARBankAccCodeId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public Nullable<int> DefaultHOLPAMItemCodeId { get; set; }
        public Nullable<int> DefaultHOLPPMItemCodeId { get; set; }
        public Nullable<int> DefaultHOLSItemCodeId { get; set; }
        public Nullable<int> DefaultHOLTItemCodeId { get; set; }
        public Nullable<int> InvoiceStatusTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeletingInvoiceQueue> DeletingInvoiceQueues { get; set; }
        public virtual Org Org { get; set; }
        public virtual XeroAccountCode XeroAccountCode { get; set; }
        public virtual XeroAccountCode XeroAccountCode1 { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
        public virtual XeroItemCode XeroItemCode1 { get; set; }
        public virtual XeroItemCode XeroItemCode2 { get; set; }
        public virtual XeroItemCode XeroItemCode3 { get; set; }
        public virtual XeroItemCode XeroItemCode4 { get; set; }
        public virtual XeroItemCode XeroItemCode5 { get; set; }
        public virtual XeroItemCode XeroItemCode6 { get; set; }
        public virtual XeroItemCode XeroItemCode7 { get; set; }
        public virtual XeroItemCode XeroItemCode8 { get; set; }
        public virtual XeroItemCode XeroItemCode9 { get; set; }
        public virtual XeroItemCode XeroItemCode10 { get; set; }
        public virtual XeroItemCode XeroItemCode11 { get; set; }
        public virtual XeroLookup XeroLookup { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption1 { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption2 { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCatOption3 { get; set; }
        public virtual XeroAccountCode XeroAccountCode2 { get; set; }
    }
}
