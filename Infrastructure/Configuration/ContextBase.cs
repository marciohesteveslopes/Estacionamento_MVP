using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Estacionamento> Estacionamento { get; set; }
        //public DbSet<Pagamento> Pagamento { get; set; }
        //public DbSet<Tarifa> Tarifa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ParkingMapping());
            //modelBuilder.ApplyConfiguration(new TariffMapping());
            base.OnModelCreating(modelBuilder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Server=tcp:estudos-marcio-br.database.windows.net,1433;Initial Catalog=Estacionamento_MVP;Persist Security Info=False;User ID=marcioh120;Password=f@bd4bee;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return strCon;
        }
    }
}
