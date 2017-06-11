using _2013204637_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public int NumeroCuenta { get; set; }
        public string DescCuenta { get; set; }
        public decimal Saldo { get; set; }
        public int Pin { get; set; }


        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public List<Retiro> Retiros { get; set; }

        public Cuenta()
        {
            Retiros = new List<Retiro>();
        }


    
    }
}
