using _2013204637;
using _2013204637_ENT.Entidades;
using _2013204637_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER
{
    public class ATMDbContext : DbContext
    {
        public DbSet<ATM> ATMs { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Retiro> Retiros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public ATMDbContext() : base("ATM")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ATMConfiguration());
            modelBuilder.Configurations.Add(new CuentaConfiguration());
            modelBuilder.Configurations.Add(new RetiroConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        
    }
}
