using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Identity;

using System;

namespace SmartH2RCore.Models.Employee
{
    public class JobDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public Branch Branch { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeStatusId { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string OfficialMobileNo { get; set; }
        public string OfficialEmailId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeSubTypeId { get; set; }
        public string ExtNo { get; set; }
        public int? NoticePeriod { get; set; }
        public decimal CTCPerAnnum { get; set; }
        public string PFNo { get; set; }
        public string PanNumber { get; set; }
        public Int64 UanNumber { get; set; }
        public string EsiDispensary { get; set; }
        public string PfrEgionOffice { get; set; }
        public long? EsiNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddelName { get; set; }
        public string Suffix { get; set; }
        public string Alias { get; set; }
        public string EmployeeCode { get; set; }
        public string SystemsPayableNumber { get; set; }
        public string Salutation { get; set; }
    }
}
