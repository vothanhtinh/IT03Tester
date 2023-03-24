using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnTiTyFramework.Models
{
     class SinhVien
    {
        [Key]
        public int StudentId { get; set; }
        [Required,StringLength(50),Display(Name="Ten Hoc Sinh")]
        public string Name { get; set; }
    }
}
