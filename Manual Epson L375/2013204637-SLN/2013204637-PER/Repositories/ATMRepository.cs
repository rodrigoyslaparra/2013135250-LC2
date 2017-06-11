using _2013204637;
using _2013204637_ENT.IRepositories;
using _2013204637_PER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.Repositories
{
    public class ATMRepository : Repository<ATM> , IATMRepository
    {
        //private readonly _2013204637_SLNDbContext _Context;

        //private ATMRepository()
        //{

        //}

        public ATMRepository(ATMDbContext context)  : base(context)
        {
            //_Context = context;
        }
    }
}
