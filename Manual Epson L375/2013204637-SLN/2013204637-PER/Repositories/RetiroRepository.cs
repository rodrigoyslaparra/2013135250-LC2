using _2013204637;
using _2013204637_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.Repositories
{
    public class RetiroRepository : Repository<Retiro> ,IRetiroRepository
    {
        //private readonly _2013204637_SLNDbContext _Context;

        public RetiroRepository(ATMDbContext context) : base(context)
        {
            // TODO: Complete member initialization
            //this._Context = context;
        }

        //private RetiroRepository()
        //{

        //}
    }
}
