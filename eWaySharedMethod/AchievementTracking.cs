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
    
    public partial class AchievementTracking
    {
        public int Id { get; set; }
        public Nullable<int> ChildId { get; set; }
        public int OrgId { get; set; }
        public bool Recruit { get; set; }
        public Nullable<System.DateTime> RecruitDate { get; set; }
        public string RecruitNote { get; set; }
        public bool Phase { get; set; }
        public Nullable<System.DateTime> PhaseDate { get; set; }
        public string PhaseNote { get; set; }
        public bool FieldPhase { get; set; }
        public Nullable<System.DateTime> FieldPhaseDate { get; set; }
        public string FieldPhaseNote { get; set; }
        public bool Navigation { get; set; }
        public Nullable<System.DateTime> NavigationDate { get; set; }
        public string NavigationNote { get; set; }
        public bool Ratel { get; set; }
        public Nullable<System.DateTime> RatelDate { get; set; }
        public string RatelNote { get; set; }
        public bool FirstAid { get; set; }
        public Nullable<System.DateTime> FirstAidDate { get; set; }
        public string FirstAidNote { get; set; }
        public bool JLc { get; set; }
        public Nullable<System.DateTime> JLcDate { get; set; }
        public string JLcNote { get; set; }
        public bool SLc { get; set; }
        public Nullable<System.DateTime> SLcDate { get; set; }
        public string SLcNote { get; set; }
        public bool UOJuniorLeaderCourse { get; set; }
        public Nullable<System.DateTime> UOJuniorLeaderCourseDate { get; set; }
        public string UOJuniorLeaderCourseNote { get; set; }
        public bool UOSeniorLeaderCourse { get; set; }
        public Nullable<System.DateTime> UOSeniorLeaderCourseDate { get; set; }
        public string UOSeniorLeaderCourseNote { get; set; }
        public bool UOUnderOfficer { get; set; }
        public Nullable<System.DateTime> UOUnderOfficerDate { get; set; }
        public string UOUnderOfficerNote { get; set; }
        public bool RifleSaftey { get; set; }
        public Nullable<System.DateTime> RifleSafteyDate { get; set; }
        public string RifleSafteyNote { get; set; }
        public bool CrossedRifles { get; set; }
        public Nullable<System.DateTime> CrossedRiflesDate { get; set; }
        public string CrossedRiflesNote { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string RecruitNote2 { get; set; }
        public string RecruitNote3 { get; set; }
        public bool RecruitCompleted { get; set; }
        public string PhaseNote2 { get; set; }
        public string PhaseNote3 { get; set; }
        public bool PhaseCompleted { get; set; }
        public string FieldPhaseNote2 { get; set; }
        public string FieldPhaseNote3 { get; set; }
        public bool FieldPhaseCompleted { get; set; }
        public string NavigationNote2 { get; set; }
        public string NavigationNote3 { get; set; }
        public bool NavigationCompleted { get; set; }
        public string RatelNote2 { get; set; }
        public string RatelNote3 { get; set; }
        public bool RatelCompleted { get; set; }
        public string FirstAidNote2 { get; set; }
        public string FirstAidNote3 { get; set; }
        public bool FirstAidCompleted { get; set; }
        public string JLcNote2 { get; set; }
        public string JLcNote3 { get; set; }
        public bool JLcCompleted { get; set; }
        public string SLcNote2 { get; set; }
        public string SLcNote3 { get; set; }
        public bool SLcCompleted { get; set; }
        public string UOJuniorLeaderCourseNote2 { get; set; }
        public string UOJuniorLeaderCourseNote3 { get; set; }
        public bool UOJuniorLeaderCourseCompleted { get; set; }
        public string UOSeniorLeaderCourseNote2 { get; set; }
        public string UOSeniorLeaderCourseNote3 { get; set; }
        public bool UOSeniorLeaderCourseCompleted { get; set; }
        public string UOUnderOfficerNote2 { get; set; }
        public string UOUnderOfficerNote3 { get; set; }
        public bool UOUnderOfficerCompleted { get; set; }
        public string RifleSafteyNote2 { get; set; }
        public string RifleSafteyNote3 { get; set; }
        public bool RifleSafteyCompleted { get; set; }
        public string CrossedRiflesNote2 { get; set; }
        public string CrossedRiflesNote3 { get; set; }
        public bool CrossedRiflesCompleted { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual Org Org { get; set; }
    }
}
