using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Thuctap01.Models
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        //public DbSet<Bangchamcongmodel> Bangchamcongmodels { get; set; }
        public DbSet<LichsunghiphepModel> LichsunghiphepModels { get; set; }
        public DbSet<QuanlyluongModel> QuanlyluongModels { get; set; }
        public DbSet<GiangvienModel> GiangvienModels { get; set; }
        public DbSet<HethongModels> HethongModelss { get; set; }
        public DbSet<hethonguudaimodel> Hethonguudaimodels { get; set; }
        public DbSet<MuchocphiModel> MuchocphiModels { get; set; }
        public DbSet<QuanlyhocphiModel> QuanyhocphiModels { get; set; }
        public DbSet<ThongbaoModel> ThongbaoModels { get; set; }
        //public DbSet<ThongbaodaguiModels> ThongbaodaguiModels { get; set; }
        //public DbSet<ThongbaoluutamModels> ThongbaoluutamModels { get; set; }
        //public DbSet<DangnhapModel> DangnhapModels { get; set; }
    }
}
