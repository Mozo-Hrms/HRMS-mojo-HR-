using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.DTO.Settings
{
    public class LocalizatonSettingDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Default Country is require!")]
        public string DefaultCountry { get; set; }
        [Required(ErrorMessage = "Date Format is require!")]
        public string DateFormat { get; set; }
        [Required(ErrorMessage = "Timezone is require!")]
        public string Timezone { get; set; }
        [Required(ErrorMessage = "Default Language is require!")]
        public int DefaultLanguage { get; set; }
        [Required(ErrorMessage = "Security is require!")]
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
