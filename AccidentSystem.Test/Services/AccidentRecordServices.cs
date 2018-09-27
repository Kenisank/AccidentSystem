using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
using Moq;

namespace AccidentSystem.Test.Services
{
    /// <summary>
    /// Summary description for AccidentRecordServices
    /// </summary>
    [TestClass]
    public class AccidentRecordServices
    {


        private Mock<IUnitOfWork> _unitofwork;
       

     
     [TestInitialize]
     public void Initialize()
        {

        }


        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
