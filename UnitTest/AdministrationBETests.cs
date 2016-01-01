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
        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateCustomerAdministrationTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 0;
            c = abe.CreateCustomer(c);
            Assert.AreNotEqual(0, c.CustomerId);
        }


        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateDockTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Dock item = UnitTest.TestHelpers.randomDock();
            item.DockId = 0;
            item = abe.CreateDock(item);
            Assert.AreNotEqual(0, item.DockId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateFerryTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Ferry item = UnitTest.TestHelpers.randomFerry();
            item.FerryId = 0;
            item = abe.CreateFerry(item);
            Assert.AreNotEqual(0, item.FerryId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateReservationTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Reservation item = UnitTest.TestHelpers.randomReservation();
            item.ReservationId = 0;
            item = abe.CreateReservation(item);
            Assert.AreNotEqual(0, item.ReservationId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateRouteTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Route item = UnitTest.TestHelpers.randomRoute();
            item.RouteId = 0;
            item = abe.CreateRoute(item);
            Assert.AreNotEqual(0, item.RouteId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateTripTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Trip item = UnitTest.TestHelpers.randomTrip();
            item.TripId = 0;
            item = abe.CreateTrip(item);
            Assert.AreNotEqual(0, item.TripId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void CreateVehicleTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Vehicle item = UnitTest.TestHelpers.randomVehicle();
            item.VehicleId = 0;
            item = abe.CreateVehicle(item);
            Assert.AreNotEqual(0, item.VehicleId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteCustomerTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 0;
            c = abe.CreateCustomer(c);
            Assert.IsTrue(abe.DeleteCustomer(c));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteDockTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Dock item = UnitTest.TestHelpers.randomDock();
            item.DockId = 0;
            item = abe.CreateDock(item);
            Assert.IsTrue(abe.DeleteDock(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteFerryTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Ferry item = UnitTest.TestHelpers.randomFerry();
            item.FerryId = 0;
            item = abe.CreateFerry(item);
            Assert.IsTrue(abe.DeleteFerry(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteReservationTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Reservation item = UnitTest.TestHelpers.randomReservation();
            item.ReservationId = 0;
            item = abe.CreateReservation(item);
            Assert.IsTrue(abe.DeleteReservation(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteRouteTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Route item = UnitTest.TestHelpers.randomRoute();
            item.RouteId = 0;
            item = abe.CreateRoute(item);
            Assert.IsTrue(abe.DeleteRoute(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteVehicleTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllDocksTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllFerriesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllReservationsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllRoutesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllTripsTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllVehiclesTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetDockTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetVehicleTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateCustomerTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateDockTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateFerryTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateReservationTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateRouteTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateTripTest()
        {
            Assert.Inconclusive("not done");
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateVehicleTest()
        {
            Assert.Inconclusive("not done");
        }
    }
}