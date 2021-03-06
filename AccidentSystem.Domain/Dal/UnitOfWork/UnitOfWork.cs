﻿using AccidentSystem.Domain.Dal.Repositories;
using AccidentSystem.Domain.Dal.Repositories.Interfaces;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
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

            AccidentRecords = new AccidentRecordRepository(context);

            VehicleEntries = new VehicleEntryRepository(context);

            PedestrianEntries = new PedestrianEntryRepository(context);

            Causes = new CauseRepository(context);

            Categories = new CategoryRepository(context);

            States = new StateRepository(context);

            Types = new TypeRepository(context);
        }



        public IAccidentRecordRepository AccidentRecords { get; set; }

        public IVehicleEntryRepository VehicleEntries { get; set; }

        public IPedestrianEntryRepository PedestrianEntries { get; set; }

        public ICauseRepository Causes { get; set; }

        public ICategoryRepository Categories { get; set; }

        public IStateRepository States { get; set; }

        public ITypeRepository Types { get; set; }

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
