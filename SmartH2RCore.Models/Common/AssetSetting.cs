using SmartH2RCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.Common
{
    public class AssetSetting : ArchivableEntity<int>
    {
       
        public string CompanyName { get; set; }
        public string WorkLocation { get; set; }

        public string AssetName { get; set; }

        public string SelectEmployee {  get; set; }

        public string IssuedDate { get; set; }

        public string RecievedBy { get; set; }

        public string ApprovedBy { get; set; }

        public string AssetList { get; set; }
        public string RecievedDate { get; set; }
        public string HandOverBy { get; set; }
    
    

    }
}
