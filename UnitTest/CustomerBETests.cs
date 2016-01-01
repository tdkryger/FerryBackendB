using Microsoft.VisualStudio.TestTools.UnitTesting;
using FerryBackendB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryBackendB.Tests
{
    [TestClass()]
    public class CustomerBETests
    {
        [TestMethod()]
        public void CreateCustomerTest()
        {
            CustomerBE cbe = new CustomerBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            Assert.IsTrue(cbe.CreateCustomer(c));
        }


        [TestMethod()]
        public void CreateCustomerReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllCustomerReservationsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCustomerByLoginTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CancelCustomerReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllRoutesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllVehiclesTest()
        {
            Assert.Fail();
        }
    }
}