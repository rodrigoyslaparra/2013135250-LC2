using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IATMRepository ATMs { get; }
        ICuentaRepository Cuentas { get; }
        IRetiroRepository Retiros { get;  }
        IClienteRepository Clientes { get; set; }

        int SaveChanges();
    }
}
