using Microsoft.EntityFrameworkCore;
using ProcesoTramasRecaudo.Infrastructure.Database.Entities;
using ProcesoTramasRecaudo.Infrastructure.Database.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoTramasRecaudo.Infrastructure.Database
{
    public class Context : DbContext
    {
        public DbSet<Archivo> Archivo { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Recaudo> Recaudo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
            if (Environment.GetEnvironmentVariable("DB_CONN") != null)
            {
                optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONN"), sqlServerOptionsAction: option =>
                {
                    option.EnableRetryOnFailure(2, TimeSpan.FromSeconds(5), null);
                });
            }
            else
                optionsBuilder.UseInMemoryDatabase("RecaudoInMemory");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArchivoMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new RecaudoMap());
        }
    }
}
