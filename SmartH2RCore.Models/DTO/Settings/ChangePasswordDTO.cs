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
    public class ChangePasswordDTO
    {

        [JqueryDataTableColumn(Order = 3)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "OldPassword")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "OldPassword")]
        [Sortable(EntityProperty = "OldPassword")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "NewPassword")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "NewPassword")]
        [Sortable(EntityProperty = "NewPassword")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "ConfirmPassword")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "ConfirmPassword")]
        [Sortable(EntityProperty = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        //public int? Id { get; set; }
        //[Required(ErrorMessage = "Old Password is require!")]
        //public string OldPassword { get; set; }
        //[Required(ErrorMessage = "New Password is require!")]
        //public string NewPassword { get; set; }
        //[Required(ErrorMessage = "Confirm Password is require!")]
        //public string ConfirmPassword { get; set; }
    }
}
