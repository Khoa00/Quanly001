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
        public DbSet<GiangvienModel> GiangvienModels { get; set; }

        public DbSet<MuchocphiModel> MuchocphiModels { get; set; }
        public DbSet<QuanlyhocphiModel> QuanyhocphiModelss { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<DangnhapModel> DangnhapModels { get; set; }
    }
}
