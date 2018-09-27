using AccidentSystem.Domain.Dal.Repositories.Interfaces;
using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.Repositories
{
    public class AccidentRecordRepository:Repository<AccidentRecords>, IAccidentRecordRepository
    {

        private readonly EfContext _context;

        public AccidentRecordRepository(EfContext context):base(context)
        {
            _context = context;
        }


    }
}
