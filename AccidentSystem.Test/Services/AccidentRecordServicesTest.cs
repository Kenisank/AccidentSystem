using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
using Moq;
using AccidentSystem.Domain.Models;
using System.Collections.ObjectModel;
using System.Linq;
using AccidentSystem.Domain.Services.Interfaces;
using AccidentSystem.Domain.Services;

namespace AccidentSystem.Test.Services
{
    /// <summary>
    /// Summary description for AccidentRecordServices
    /// </summary>
    [TestClass]
    public class AccidentRecordServicesTest
    {


        private Mock<IUnitOfWork> _unitofwork;
        private Mock<IAccidentRecordServices> _accidentrecordservices;



        [TestInitialize]
        public void Initialize()
        {
            _unitofwork = new Mock<IUnitOfWork>();
            _accidentrecordservices = new Mock<IAccidentRecordServices>();
        }


        [TestMethod]
        public void AddNewAccidentRecord()
        {
            //Arrange

            var record = new AccidentRecords
            {
                Address = "Atani Opp Bishop Court",
                Causes = new List<Causes>
                {
                    new Causes {Id=1, Name="Weather" },
                    new Causes {Id=2, Name="Reckless driving" }
                },

                Evidences = new Evidences { Image = "njhi", Description = "bhjhh" },
                Withnesses = new Persons { Name = "nkhih", Number = "ugugu" },
                OtherWithnesses = new Persons { Name = "bjjgjb", Number = "bhhg" },
                State = new States { Id = 1, Name = "Anambra" },
                StateId = 1,
            };

            var vEntries = new List<VehicleEntries>
            {
                new VehicleEntries {Model="Honda", PlateNo="12345", Colour="Red", DeadFemale=2, DeadMale=1, HurtFemale=2, HurtMale=5, State="destroied", SurviedFemale=1, SurviedMale=4,  },
                new VehicleEntries {Model="Honda", PlateNo="12345", Colour="yellow", DeadFemale=2, DeadMale=1, HurtFemale=9, HurtMale=5, State="destroied", SurviedFemale=1, SurviedMale=3,  },
                new VehicleEntries {Model="Honda", PlateNo="12345", Colour="blue", DeadFemale=2, DeadMale=1, HurtFemale=2, HurtMale=6, State="destroied", SurviedFemale=10, SurviedMale=5,  }
            };

            var categories = new List<Categories>
            {
                new Categories {Id=1, Name="Motor", Total=9, Types= new List<Types>
                {
                    new Types {Id=1, Total=3, DriversCategory=4, Name="Van", CategoryId=1, PassagersCategory=5 },
                    new Types {Id=2, Total=6, DriversCategory=4, Name="Bus", CategoryId=1, PassagersCategory=5 },

                }
                },

                 new Categories {Id=2, Name="Bike", Total=13, Types= new List<Types>
                {
                    new Types {Id=3, Total=7, DriversCategory=4, Name="boxer", CategoryId=1, PassagersCategory=5 },
                    new Types {Id=4, Total=6, DriversCategory=4, Name="chen", CategoryId=1, PassagersCategory=5 },

                }
                },

                 new Categories {Id=3, Name="Pedestrians", Total=10 },

                 new Categories {Id=4, Name="Drivers", Total=15 },

                 new Categories {Id=5, Name="Passager", Total=18 }






            };




            vEntries[0].TypeId = categories.ToList()[0].Types.ToList()[0].Id;
            vEntries[1].TypeId = categories.ToList()[1].Types.ToList()[1].Id;
            vEntries[2].TypeId = categories.ToList()[1].Types.ToList()[0].Id;


            var pEntry = new PedestrianEntries
            {
                SurviedFemale=2, SurviedMale=3, HurtMale=4, HurtFemale=5, DeadMale=8, DeadFemale=9, CategoryId=3,  
            };


            //Act
            _accidentrecordservices.Setup(a => a.AddAccidentRecord(It.IsAny<AccidentRecords>(), It.IsAny<IEnumerable<VehicleEntries>>(), It.IsAny<PedestrianEntries>())).Returns(true);
            _unitofwork.Setup(a => a.VehicleEntries.addToCategory(It.IsAny<VehicleEntries>()));
            _unitofwork.Setup(a => a.AccidentRecords.Add(record)).Callback(() => record.Id = It.IsAny<int>());
            _unitofwork.Setup(a => a.PedestrianEntries.addToCategory(It.IsAny<PedestrianEntries>()));
            _unitofwork.Setup(a => a.Save()).Returns(true);


            //Assert
            var accidentrecordservice = new AccidentRecordServices(_unitofwork.Object);

            var actual = accidentrecordservice.AddAccidentRecord(record, vEntries, pEntry); 

            Assert.IsTrue(actual);
          


        }


        
    }
}
