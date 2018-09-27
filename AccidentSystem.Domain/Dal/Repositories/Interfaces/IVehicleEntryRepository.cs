using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.Repositories.Interfaces
{
    public interface IVehicleEntryRepository:IRepository<VehicleEntries>
    {

        void addToCategory(VehicleEntries vehicleentry);
    }
}
