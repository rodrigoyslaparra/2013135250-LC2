using _2013204637;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.EntitiesConfigurations
{
    public class ATMConfiguration : EntityTypeConfiguration<ATM>
    {
        public ATMConfiguration() 
        {
            ToTable("ATM");
            HasKey(a => a.ATMId);
            Property(x => x.DescATM).IsRequired();
            

        }
    }
}
