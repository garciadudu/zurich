using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using Seguros.Zurich.Domain.Entities.Dominio;
using Seguros.Zurich.Infraestrutura.Repository.Base.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros.Zurich.Infraestrutura.Repository.Base.EF
{
    public class ZurichDbContext : DbContext
    {
        public ZurichDbContext()
        {

        }

        public ZurichDbContext(DbContextOptions<ZurichDbContext> options) : base(options) { }

        public DbSet<Seguro> Seguro { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConfigurationSeguro());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
            OracleConfiguration.TraceFileLocation = @"C:\oraclexe\traces";
            OracleConfiguration.TraceLevel = 7;
            OracleConfiguration.TnsAdmin = @"C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN";
            optionsBuilder.UseOracle(@"User Id=sysadmin;Password=sysadmin;Data Source=XE;");
        }
    }
}
