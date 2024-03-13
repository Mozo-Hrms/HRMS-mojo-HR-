using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.DTO.EmployeeDTO
{
    public class JobDetailsDTO
    {
        [JqueryDataTableColumn(Order = 16)]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public string LocationName { get; set; }
        public string FirstName { get; set; }
        public string Suffix { get; set; }
        public User Employee { get; set; }
        public int BranchId { get; set; }
        public string MiddelName { get; set; }
        public string Alias { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string Salutation { get; set; }
        public string LastName { get; set; }
        public string EmployeeCode { get; set; }
        public string SystemsPayableNumber { get; set; }



        // This start column Work Information (primary)
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeStatusId { get; set; }
        //public int RoleId { get; set; }  //naku doubt uvndhi
        //public string Grade {  get; set; } this column table is not there,but view part column is there how add this column DTO & Tabl ?



        // This start Column Work Information (Secoundary)
        public string OfficialEmailId { get; set; }
        public string OfficialMobileNo { get; set; }
        public string ExtNo { get; set; }
        public string PanNumber { get; set; }
        public Int64 UanNumber { get; set; }
    }
}
