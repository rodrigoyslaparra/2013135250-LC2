using _2013204637;
using _2013204637_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.EntitiesConfigurations
{
    public class CuentaConfiguration : EntityTypeConfiguration<Cuenta>
    {
        public CuentaConfiguration()
        {
            ToTable("Cuenta");
            HasKey(a => a.CuentaId);
            Property(v => v.Saldo)
                .IsRequired();
            Property(v => v.NumeroCuenta)
                .IsRequired();
            Property(v => v.Pin)
                .IsRequired();
            Property(x => x.DescCuenta)
                .IsRequired();
            Property(b => b.ClienteId).
                IsRequired();
            HasRequired<Cliente>(a => a.Cliente).
                WithMany(z => z.Cuentas);
            
            
            //    public int CuentaId { get; set; }
            //public int NumeroCuenta { get; set; }
            //public string DescCuenta { get; set; }
            //public decimal Saldo { get; set; }
            //public int Pin { get; set; }
        }
    }
}
