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
    public class AdministrationBETests
    {
        [TestMethod()]
        public void CreateCustomerTest()
        {
            AdministrationBE a = new AdministrationBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c = a.CreateCustomer(c);
            Assert.AreNotEqual(0, c.CustomerId);
        }


        [TestMethod()]
        public void CreateDockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateFerryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateRouteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTripTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateVehicleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteDockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFerryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteRouteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTripTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteVehicleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllDocksTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllFerriesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllReservationsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllRoutesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllVehiclesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetFerryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRouteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTripTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetVehicleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateDockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateFerryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateReservationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateRouteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTripTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateVehicleTest()
        {
            Assert.Fail();
        }
    }
}