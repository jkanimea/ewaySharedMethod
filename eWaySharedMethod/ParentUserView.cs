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
    
    public partial class ParentUserView
    {
        public string OrgName { get; set; }
        public int Id { get; set; }
        public Nullable<long> EwayCustomerId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Nullable<int> ContactId { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public bool CanLogin { get; set; }
        public string EmailConfirmationToken { get; set; }
        public Nullable<bool> IsEmailConfirmationValid { get; set; }
        public string PasswordResetToken { get; set; }
        public Nullable<bool> IsPswResetTokenValid { get; set; }
        public bool IsAdmin { get; set; }
        public Nullable<System.DateTime> StaffPayrollLatSyncOn { get; set; }
        public Nullable<decimal> StaffCostPerHour { get; set; }
        public Nullable<int> TotalHoursToBeSync { get; set; }
        public string Colour { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string PinCode { get; set; }
        public bool IsOrgAdmin { get; set; }
        public Nullable<System.DateTime> WorkStartDate { get; set; }
        public Nullable<System.DateTime> WorkEndDate { get; set; }
        public Nullable<int> CurrentOrgId { get; set; }
        public Nullable<System.DateTime> LastLogedOn { get; set; }
        public Nullable<int> RetryAttempt { get; set; }
        public bool SysAdmin { get; set; }
        public int Expr1 { get; set; }
        public int OrgId { get; set; }
        public int UserId { get; set; }
        public System.DateTime Expr2 { get; set; }
        public string Expr3 { get; set; }
        public Nullable<bool> IsInSubsidy { get; set; }
        public bool Expr4 { get; set; }
        public int Expr5 { get; set; }
        public string Name { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> OldId { get; set; }
        public int InvRefSettingId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> TerritoryId { get; set; }
        public Nullable<int> Expr6 { get; set; }
        public Nullable<int> Decile { get; set; }
        public Nullable<int> Roll { get; set; }
        public Nullable<int> RollApproved { get; set; }
        public Nullable<System.DateTime> LeaseStart { get; set; }
        public Nullable<System.DateTime> LeaseEnd { get; set; }
        public string LeasorName { get; set; }
        public Nullable<decimal> LeaseCostFixed { get; set; }
        public string MeetingRoom { get; set; }
        public string BankAccNum { get; set; }
        public string MsdNum { get; set; }
        public string OscarNum { get; set; }
        public string Comments { get; set; }
        public string ExtraChargeType { get; set; }
        public Nullable<decimal> ExtraMinRate { get; set; }
        public Nullable<int> BeforeThreshold { get; set; }
        public Nullable<int> AfterThreshold { get; set; }
        public System.DateTime Expr7 { get; set; }
        public System.DateTime UpdateOn { get; set; }
        public string Expr8 { get; set; }
        public string Expr9 { get; set; }
        public bool Expr10 { get; set; }
        public bool HasSaved { get; set; }
        public byte[] Expr11 { get; set; }
        public Nullable<System.DateTime> LicenceStart { get; set; }
        public Nullable<System.DateTime> LicenceEnd { get; set; }
        public Nullable<decimal> WeeklyAdminCost { get; set; }
        public Nullable<decimal> WeeklyRentCost { get; set; }
        public Nullable<decimal> CurrentRevenue { get; set; }
        public Nullable<decimal> CurrentExpenses { get; set; }
        public Nullable<decimal> CurrentBalance { get; set; }
        public Nullable<decimal> CurrentOverdueAmt { get; set; }
        public string MasterPin { get; set; }
        public Nullable<bool> IsChildPhotoEnabled { get; set; }
        public Nullable<bool> IsAuthPhotoEnabled { get; set; }
        public Nullable<bool> IsStaffPhotoEnabled { get; set; }
        public Nullable<bool> IsFreeTrial { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string StaffClockMethod { get; set; }
        public Nullable<int> LeaseCostPercentage { get; set; }
        public Nullable<bool> IsPaymentGatewayEnabled { get; set; }
        public string SiteBankAccNum { get; set; }
        public Nullable<decimal> LicenceFee { get; set; }
        public Nullable<bool> IsDashboardMsgEnabled { get; set; }
        public Nullable<bool> IsEMailMsgEnabled { get; set; }
        public Nullable<bool> IsSMSMsgEnabled { get; set; }
        public string SiteContactPersone { get; set; }
        public string SiteContactPhone { get; set; }
        public string SiteContactEmail { get; set; }
        public bool InvoiceDateSetting { get; set; }
        public string HeadOfficeLogo { get; set; }
        public int Expr12 { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public byte[] SignatureImage { get; set; }
        public string Landline { get; set; }
        public string Office { get; set; }
        public string OfficeExtension { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Expr13 { get; set; }
        public string StreetNum { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string BillingStreetNum { get; set; }
        public string BillingAddress { get; set; }
        public string BillingSuburb { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingCountry { get; set; }
        public string Expr14 { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public string Relation { get; set; }
        public string HowHear { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public System.DateTime Expr15 { get; set; }
        public System.DateTime Expr16 { get; set; }
        public string Expr17 { get; set; }
        public string Expr18 { get; set; }
        public bool Expr19 { get; set; }
        public byte[] Expr20 { get; set; }
        public bool FirstAidCheck { get; set; }
        public Nullable<System.DateTime> FirstAidExpireyDate { get; set; }
        public bool PoliceCheck { get; set; }
        public Nullable<System.DateTime> PoliceCheckExprieyDate { get; set; }
        public string Notes { get; set; }
    }
}