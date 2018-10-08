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



        public bool AddAccidentRecord(AccidentRecords record, IEnumerable<int> causesIds,  IEnumerable<VehicleEntries> vehiclesEntries, PedestrianEntries pedestrianEntries)
        {

            if (record == null)
                return false;

            if ((vehiclesEntries.Count() <= 0 || pedestrianEntries == null) && causesIds.Count()>0)
                return false;

            if (vehiclesEntries.Count() > 0 || vehiclesEntries!=null)
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

            if (causesIds!=null || causesIds.Count() > 0)
            {
                


                foreach(var causeId in causesIds)
                {
                   var cause = _unitofwork.Causes.Get(causeId);

                    if (cause != null)
                        record.Causes.Add(cause);
                }

               
            }

            

            _unitofwork.AccidentRecords.Add(record);

            if (_unitofwork.Save())
                return true;


            return false;


        }

        



    }
}
