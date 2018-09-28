using AccidentSystem.Domain.Dal.UnitOfWork;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
using AccidentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Services
{
    public class AccidentRecordServices
    {
        private readonly IUnitOfWork _unitofwork;

        public AccidentRecordServices(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }



        public bool AddAccidentRecord(AccidentRecords record, IEnumerable<VehicleEntries> vehiclesEntries, PedestrianEntries pedestrianEntries)
        {

            if (record == null)
                return false;

            if (vehiclesEntries.Count() <= 0 || pedestrianEntries == null)
                return false;

            if (vehiclesEntries.Count() > 0)
            {
                foreach (var vehicleEntry in vehiclesEntries)
                {
                    record.VehicleEntries.Add(vehicleEntry);
                    _unitofwork.VehicleEntries.addToCategory(vehicleEntry);
                }
            }

            if (pedestrianEntries != null)
            {
                record.PedestrianEntry = pedestrianEntries;
                _unitofwork.PedestrianEntries.addToCategory(record.PedestrianEntry);
            }
            

            _unitofwork.AccidentRecords.Add(record);

            if (_unitofwork.Save())
                return true;


            return false;


        }

        



    }
}
