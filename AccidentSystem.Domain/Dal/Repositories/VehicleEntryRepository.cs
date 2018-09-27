using AccidentSystem.Domain.Dal.Repositories.Interfaces;
using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.Repositories
{
    public class VehicleEntryRepository:Repository<VehicleEntries>, IVehicleEntryRepository
    {
        private readonly EfContext _context;

        public VehicleEntryRepository(EfContext context):base(context)
        {
            _context = context;
        }

        public void addToCategory(VehicleEntries vehicleentry)
        {

            //get the total on this type that have been invovled in an accident on the system
            var type = _context.Types.Find(vehicleentry.TypeId);

            type.Total += 1;


            //get the total the category that have been invovled in an accident on the system
            var category = _context.Categories.Find(type.CategoryId);

            category.Total += 1;


            //get the total driver that have been invovled in an accident on the system
            var driverCategory = _context.Categories.Find(type.DriversCategory);

            driverCategory.Total += vehicleentry.Driver;


            //get the total passagers that have been invovled in an accident on the system
            var passagersCategory = _context.Categories.Find(type.PassagersCategory);

            passagersCategory.Total += vehicleentry.Passagers;

        }



    }
}
