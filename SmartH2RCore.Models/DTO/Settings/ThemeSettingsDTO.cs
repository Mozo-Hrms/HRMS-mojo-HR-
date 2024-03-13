using Fingers10.ExcelExport.Attributes;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.DTO.Settings
{
    public class ThemeSettingsDTO
    {
        [JqueryDataTableColumn(Order = 3)]
        public int? Id { get; set; }

        [Display(Name = "CompanyName")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "CompanyName")]
        [Sortable(EntityProperty = "CompanyName")]
        public String CompanyName { get; set; }



        [Display(Name = "CompanyLogo")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "CompanyLogo")]
        [Sortable(EntityProperty = "CompanyLogo")]
        public String CompanyLogo { get; set; }


        [Display(Name = "LoginLogo")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "LoginLogo")]
        [Sortable(EntityProperty = "LoginLogo")]

        public String LoginLogo { get; set; }

        public string CompanyLogoUrl { get; set; }
        public string LoginLogoUrl { get; set; }
    }
}
