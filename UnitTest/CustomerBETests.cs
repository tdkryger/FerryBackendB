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
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllCustomerReservationsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetCustomerByLoginTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CancelCustomerReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllRoutesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllVehiclesTest()
        {
            Assert.Inconclusive("not done");
        }
    }
}