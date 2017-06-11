using _2013204637_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ATMDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        

        public IATMRepository ATMs{get;private set; }
        public ICuentaRepository Cuentas{get;private set;}
        public IRetiroRepository Retiros { get; private set; }
        public IClienteRepository Clientes { get; set; }

        //ctores

        private UnityOfWork()
        {
            _Context = new ATMDbContext();
           
            ATMs = new ATMRepository(_Context);
            Cuentas = new CuentaRepository(_Context);
            Retiros = new RetiroRepository(_Context);
            Clientes = new ClienteRepository(_Context);
        }


        public static UnityOfWork Instance
        {
            get
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                    _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
