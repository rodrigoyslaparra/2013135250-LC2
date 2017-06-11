using _2013204637;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_ENT.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public int EdadCliente { get; set; }

        public List<Cuenta> Cuentas { get; set; }




        public Cliente()
        {
            Cuentas = new List<Cuenta>();
        }
    }
}
