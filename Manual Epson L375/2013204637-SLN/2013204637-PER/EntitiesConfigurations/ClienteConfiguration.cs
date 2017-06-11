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
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");
            HasKey(a => a.ClienteId);
            Property(x => x.NombreCliente).IsRequired();
            
            

        }
        
    }
}
