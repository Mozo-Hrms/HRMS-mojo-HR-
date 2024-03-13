using SmartH2RCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.Common
{
    public class LocalizationSetting : ArchivableEntity<int>
    {
        public string DefaultCountry { get; set; }

        public string DateFormat { get; set; }
        public string Timezone {  get; set; }

        public string DefaultLanguage { get; set; }

        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
