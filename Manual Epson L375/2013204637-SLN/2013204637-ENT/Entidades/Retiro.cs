using _2013204637_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Retiro
    {
        public int RetiroId { get; set; }
        public decimal Monto { get; set; }
        public string DescRetiro { get; set; }
        public DateTime FechaRetiro { get; set; }
        public int ATMId { get; set; }
        public int CuentaId { get; set; }


        public ATM ATM { get; set; }
        public Cuenta Cuenta { get; set; }

        public Retiro()
        {

        }
        
    }
}
