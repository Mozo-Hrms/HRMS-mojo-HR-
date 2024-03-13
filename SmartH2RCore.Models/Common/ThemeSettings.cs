using SmartH2RCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.Common
{
    public class ThemeSettings : ArchivableEntity<int>
    {
        public String CompanyName { get; set; }

        public String CompanyLogo { get; set; }

        public String LoginLogo { get; set; }
    }
}
