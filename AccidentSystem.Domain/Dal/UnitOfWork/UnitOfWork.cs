using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly EfContext _context;

        public UnitOfWork(EfContext context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
