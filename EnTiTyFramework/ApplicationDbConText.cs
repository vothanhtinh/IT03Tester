using EnTiTyFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnTiTyFramework
{
    class ApplicationDbConText :DbContext
    {
        //Ket noi class den database
        public ApplicationDbConText() : base("cnStr")
        {

        }
        //Tao 2 bang
        public DbSet<SinhVien> SinhVien { get;set; }
        public DbSet<Class> Class { get;set; }
    }
}
