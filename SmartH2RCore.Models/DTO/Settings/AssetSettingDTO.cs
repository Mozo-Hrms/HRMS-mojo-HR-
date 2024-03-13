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
    public class AssetSettingDTO
    {
        [JqueryDataTableColumn(Order = 10)]
        public int? Id { get; set; }

        [Display(Name = "CompanyName")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "CompanyName")]
        [Sortable(EntityProperty = "CompanyName")]
        public string CompanyName { get; set; }
       
        [Display(Name = "WorkLocation")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "WorkLocation")]
        [Sortable(EntityProperty = "WorkLocation")]
        [Required(ErrorMessage = "WorkLocation is require!")]
        public string WorkLocation { get; set; }

        [Display(Name = "AssetName")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "AssetName")]
        [Sortable(EntityProperty = "AssetName")]
        [Required(ErrorMessage = "AssetName is require!")]
        public string AssetName { get; set; }

        [Display(Name = "SelectEmployee")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "SelectEmployee")]
        [Sortable(EntityProperty = "SelectEmployee")]
        [Required(ErrorMessage = "SelectEmployee is require!")]
        public string SelectEmployee { get; set; }

        [Display(Name = "IssuedDate")]
        [IncludeInReport(Order = 5)]
        [JqueryDataTableColumn(Order = 5)]
        [SearchableString(EntityProperty = "IssuedDate")]
        [Sortable(EntityProperty = "IssuedDate")]
        [Required(ErrorMessage = "IssuedDate is require!")]
        public string IssuedDate { get; set; }

        [Display(Name = "RecievedBy")]
        [IncludeInReport(Order = 6)]
        [JqueryDataTableColumn(Order = 6)]
        [SearchableString(EntityProperty = "RecievedBy")]
        [Sortable(EntityProperty = "RecievedBy")]
        [Required(ErrorMessage = "RecievedBy is require!")]
        public string RecievedBy { get; set; }

        [Display(Name = "ApprovedBy")]
        [IncludeInReport(Order = 7)]
        [JqueryDataTableColumn(Order = 7)]
        [SearchableString(EntityProperty = "ApprovedBy")]
        [Sortable(EntityProperty = "ApprovedBy")]
        [Required(ErrorMessage = "ApprovedBy is require!")]
        public string ApprovedBy { get; set; }

        [Display(Name = "AssetList")]
        [IncludeInReport(Order = 8)]
        [JqueryDataTableColumn(Order = 8)]
        [SearchableString(EntityProperty = "AssetList")]
        [Sortable(EntityProperty = "AssetList")]
        [Required(ErrorMessage = "AssetList is require!")]
        public string AssetList { get; set; }


        [Display(Name = "RecievedDate")]
        [IncludeInReport(Order = 9)]
        [JqueryDataTableColumn(Order = 9)]
        [SearchableString(EntityProperty = "RecievedDate")]
        [Sortable(EntityProperty = "RecievedDate")]
        [Required(ErrorMessage = "RecievedDate is require!")]
        public string RecievedDate { get; set; }


        [Display(Name = "HandOverBy")]
        [IncludeInReport(Order = 10)]
        [JqueryDataTableColumn(Order = 10)]
        [SearchableString(EntityProperty = "HandOverBy")]
        [Sortable(EntityProperty = "HandOverBy")]
        [Required(ErrorMessage = "HandOverBy is require!")]

        public string HandOverBy { get; set; }


    }
}
