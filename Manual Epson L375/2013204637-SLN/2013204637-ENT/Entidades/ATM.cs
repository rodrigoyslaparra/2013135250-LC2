using _2013204637_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class ATM
    {
        public int ATMId { get; set; }
        public string DescATM { get; set; }

        
        public List<Retiro> Retiros { get; set; }



        public ATM()
        {
            Retiros = new List<Retiro>();
        }

        

        
    }
}
