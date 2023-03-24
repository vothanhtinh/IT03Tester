using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnTiTyFramework.Models
{
     class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required, StringLength(50), Display(Name = "Ten Lop Hoc")]
        public string ClassName { get; set; }
    }
}
