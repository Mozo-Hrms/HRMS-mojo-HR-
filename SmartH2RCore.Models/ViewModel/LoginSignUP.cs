using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace SmartH2RCore.Models.ViewModel
{
    public class LoginSignUP
    {
        public string UserCode { get; set; }
        public string UserNo { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public List<Company> Company { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime? UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int? UpdatedBy { get; set; }
    }
}
