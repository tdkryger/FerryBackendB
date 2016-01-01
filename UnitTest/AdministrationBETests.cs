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
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CreateFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CreateReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CreateRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CreateTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void CreateVehicleTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteCustomerTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteDockTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void DeleteVehicleTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllDocksTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllFerriesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllReservationsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllRoutesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetAllVehiclesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetDockTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void GetVehicleTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateDockTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod()]
        public void UpdateVehicleTest()
        {
            Assert.Inconclusive("not done");
        }
    }
}