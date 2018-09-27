using AccidentSystem.Domain.Dal.Repositories.Interfaces;
using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.Repositories
{
   public class PedestrianEntryRepository:Repository<PedestrianEntries>, IPedestrianEntryRepository
    {

        private readonly EfContext _context;
        public PedestrianEntryRepository(EfContext context):base(context)
        {
            _context = context;
        }

        public void addToCategory(PedestrianEntries pedestrianentry)
        {

            var category = _context.Categories.Find(pedestrianentry.CategoryId);

            category.Total += pedestrianentry.Total;

        }
    }
}
