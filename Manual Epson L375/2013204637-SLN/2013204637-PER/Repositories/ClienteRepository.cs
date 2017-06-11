using _2013204637_ENT.Entidades;
using _2013204637_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2013204637_PER.Repositories
{
    class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ATMDbContext context) : base(context)
        {
        }
    }
}
