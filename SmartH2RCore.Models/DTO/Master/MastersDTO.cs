using Fingers10.ExcelExport.Attributes;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.DTO.Master
{
    public class MastersDTO
    {
        [JqueryDataTableColumn(Order = 18)]
        public int Id { get; set; }

        [Display(Name = "Masters")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Masters.Masters")]
        [Sortable(EntityProperty = "Masters.Masters")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Department Type is require!")]
        public int MastersId { get; set; }

        [Required(ErrorMessage = "Department Type is require!")]
        [Display(Name = "Department Type")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Department Type")]
        [Sortable(EntityProperty = "Department Type")]
        public string DepartmentType { get; set; }

        [Display(Name = "Sub Department")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "Sub Department")]
        [Sortable(EntityProperty = "Sub Department")]
        public string SubDepartment { get; set; }
       
      

        [Display(Name = "Designation")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "Designation")]
        [Sortable(EntityProperty = "Designation")]
        public string Designation { get; set; }

        [Display(Name = "Employee Type")]
        [IncludeInReport(Order = 5)]
        [JqueryDataTableColumn(Order = 5)]
        [SearchableString(EntityProperty = "Employee Type")]
        [Sortable(EntityProperty = "Employee Type")]
        public string EmployeeType { get; set; }

        [Display(Name = "Employee Sub Type")]
        [IncludeInReport(Order = 6)]
        [JqueryDataTableColumn(Order = 6)]
        [SearchableString(EntityProperty = "Employee Sub Type")]
        [Sortable(EntityProperty = "Employee Sub Type")]
        public string EmployeeSubType { get; set; }

        [Display(Name = "Employee Status")]
        [IncludeInReport(Order = 7)]
        [JqueryDataTableColumn(Order = 7)]
        [SearchableString(EntityProperty = "Employee Status")]
        [Sortable(EntityProperty = "Employee Status")]
        public string EmployeeStatus { get; set; }

       

        [Display(Name = "Role")]
        [IncludeInReport(Order = 8)]
        [JqueryDataTableColumn(Order = 8)]
        [SearchableString(EntityProperty = "Role")]
        [Sortable(EntityProperty = "Role")]
        public string Role { get; set; }

        [Display(Name = "Grade")]
        [IncludeInReport(Order = 9)]
        [JqueryDataTableColumn(Order = 9)]
        [SearchableString(EntityProperty = "Grade")]
        [Sortable(EntityProperty = "Grade")]
        public string Grade { get; set; }

        [Display(Name = "Currency Code")]
        [IncludeInReport(Order = 10)]
        [JqueryDataTableColumn(Order = 10)]
        [SearchableString(EntityProperty = "Currency Code")]
        [Sortable(EntityProperty = "Currency Code")]
        public string CurrencyCode { get; set; }

        [Display(Name = "Bank")]
        [IncludeInReport(Order = 11)]
        [JqueryDataTableColumn(Order = 12)]
        [SearchableString(EntityProperty = "Bank")]
        [Sortable(EntityProperty = "Bank")]
        public string Bank { get; set; }

        [Display(Name = "Country")]
        [IncludeInReport(Order = 13)]
        [JqueryDataTableColumn(Order = 13)]
        [SearchableString(EntityProperty = "Country")]
        [Sortable(EntityProperty = "Country")]
        public string Country { get; set; }

        [Display(Name = "State")]
        [IncludeInReport(Order = 14)]
        [JqueryDataTableColumn(Order = 14)]
        [SearchableString(EntityProperty = "State")]
        [Sortable(EntityProperty = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        [IncludeInReport(Order = 15)]
        [JqueryDataTableColumn(Order = 15)]
        [SearchableString(EntityProperty = "City")]
        [Sortable(EntityProperty = "City")]
        public string City { get; set; }

        [Display(Name = "Parent Query Type")]
        [IncludeInReport(Order = 16)]
        [JqueryDataTableColumn(Order = 16)]
        [SearchableString(EntityProperty = "Parent Query Type")]
        [Sortable(EntityProperty = "Parent Query Type")]
        public string ParentQueryType { get; set; }

        [Display(Name = "Query Type")]
        [IncludeInReport(Order = 17)]
        [JqueryDataTableColumn(Order = 17)]
        [SearchableString(EntityProperty = "Query Type")]
        [Sortable(EntityProperty = "Query Type")]
        public string  QueryType { get; set; }

    }
}

