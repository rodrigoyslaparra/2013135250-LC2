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
    public class RetiroConfiguration : EntityTypeConfiguration<Retiro>
    {
        public RetiroConfiguration()
        {
            ToTable("Retiro");
            HasKey(a => a.RetiroId);
            Property(z => z.DescRetiro)
                .IsRequired();
            Property(s => s.FechaRetiro)
                .IsRequired();
            Property(b => b.Monto)
                .IsRequired();
            HasRequired<ATM>(m => m.ATM)
                .WithMany(h => h.Retiros);
            HasRequired<Cuenta>(m => m.Cuenta).
                WithMany(g => g.Retiros);

        //    public int RetiroId { get; set; }
        //public decimal Monto { get; set; }
        //public string DescRetiro { get; set; }
        //public DateTime FechaRetiro { get; set; }
            
        }
    }
}
