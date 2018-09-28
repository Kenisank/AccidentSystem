using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Services.Interfaces
{
    public interface IAccidentRecordServices
    {
        bool AddAccidentRecord(AccidentRecords record, IEnumerable<VehicleEntries> vehiclesEntries, PedestrianEntries pedestrianEntries);

    }
}
