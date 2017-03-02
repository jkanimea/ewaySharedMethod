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
    
    public partial class OscarTracking
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public bool Intention { get; set; }
        public Nullable<System.DateTime> IntendedDate { get; set; }
        public string IntendedNote { get; set; }
        public string IntendedNoteBy { get; set; }
        public bool FormSent { get; set; }
        public Nullable<System.DateTime> FormSentDate { get; set; }
        public string FormSentNote { get; set; }
        public string FormSentNoteBy { get; set; }
        public bool FormRecieved { get; set; }
        public Nullable<System.DateTime> FormRecievedDate { get; set; }
        public string FormReceivedNote { get; set; }
        public string FormReceivedNoteBy { get; set; }
        public bool FormLodged { get; set; }
        public Nullable<System.DateTime> FormLodgedDate { get; set; }
        public string FormLodgeNote { get; set; }
        public string FormLodgeNoteBy { get; set; }
        public bool OscarApproved { get; set; }
        public Nullable<System.DateTime> OscarApprovedDate { get; set; }
        public string OscarApprovedNote { get; set; }
        public string OscarApproveNoteBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public bool IsCompleted { get; set; }
        public Nullable<bool> IsDeclined { get; set; }
        public Nullable<bool> Term1 { get; set; }
        public Nullable<bool> Term1Holiday { get; set; }
        public Nullable<bool> Term2 { get; set; }
        public Nullable<bool> Term2Holiday { get; set; }
        public Nullable<bool> Term3 { get; set; }
        public Nullable<bool> Term3Holiday { get; set; }
        public Nullable<bool> Term4 { get; set; }
        public Nullable<bool> Term4Holiday { get; set; }
        public Nullable<int> ChildId1 { get; set; }
        public Nullable<int> ChildId2 { get; set; }
        public Nullable<int> ChildId3 { get; set; }
        public Nullable<int> ChildId4 { get; set; }
        public Nullable<int> ChildId5 { get; set; }
        public Nullable<int> ChildId6 { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<bool> IsNewApplication { get; set; }
    
        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}