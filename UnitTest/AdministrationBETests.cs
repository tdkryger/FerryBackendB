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
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Trip item = UnitTest.TestHelpers.randomTrip();
            item = abe.CreateTrip(item);
            Assert.IsTrue(abe.DeleteTrip(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void DeleteVehicleTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Vehicle item = UnitTest.TestHelpers.randomVehicle();
            item = abe.CreateVehicle(item);
            Assert.IsTrue(abe.DeleteVehicle(item));
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllDocksTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Dock> l = abe.GetAllDocks();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllFerriesTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Ferry> l = abe.GetAllFerries();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllReservationsTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Reservation> l = abe.GetAllReservations();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllRoutesTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Route> l = abe.GetAllRoutes();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllTripsTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Trip> l = abe.GetAllTrips();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetAllVehiclesTest()
        {
            AdministrationBE abe = new AdministrationBE();
            List<Contract.dto.Vehicle> l = abe.GetAllVehicles();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetDockTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Dock newItem = UnitTest.TestHelpers.randomDock();
            newItem = abe.CreateDock(newItem);
            Contract.dto.Dock item = abe.GetDock(newItem.DockId);
            Assert.AreEqual(newItem.DockId, item.DockId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetFerryTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Ferry newItem = UnitTest.TestHelpers.randomFerry();
            newItem = abe.CreateFerry(newItem);
            Contract.dto.Ferry item = abe.GetFerry(newItem.FerryId);
            Assert.AreEqual(newItem.FerryId, item.FerryId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetReservationTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Reservation newItem = UnitTest.TestHelpers.randomReservation();
            newItem = abe.CreateReservation(newItem);
            Contract.dto.Reservation item = abe.GetReservation(newItem.ReservationId);
            Assert.AreEqual(newItem.ReservationId, item.ReservationId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetRouteTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Route newItem = UnitTest.TestHelpers.randomRoute();
            newItem = abe.CreateRoute(newItem);
            Contract.dto.Route item = abe.GetRoute(newItem.RouteId);
            Assert.AreEqual(newItem.RouteId, item.RouteId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetTripTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Trip newItem = UnitTest.TestHelpers.randomTrip();
            newItem = abe.CreateTrip(newItem);
            Contract.dto.Trip item = abe.GetTrip(newItem.TripId);
            Assert.AreEqual(newItem.TripId, item.TripId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void GetVehicleTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Vehicle newItem = UnitTest.TestHelpers.randomVehicle();
            newItem = abe.CreateVehicle(newItem);
            Contract.dto.Vehicle item = abe.GetVehicle(newItem.VehicleId);
            Assert.AreEqual(newItem.VehicleId, item.VehicleId);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateCustomerTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 0;
            c = abe.CreateCustomer(c);
            c.AmountOfFreeRides = int.MaxValue;
            c = abe.UpdateCustomer(c);
            
            Assert.AreEqual(int.MaxValue, c.AmountOfFreeRides);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateDockTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Dock item = UnitTest.TestHelpers.randomDock();
            item.DockId = 0;
            item = abe.CreateDock(item);
            item.DockName = "I HATE CRUD UNIT TESTING";
            item = abe.UpdateDock(item);
            Assert.AreEqual("I HATE CRUD UNIT TESTING", item.DockName);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateFerryTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Ferry item = UnitTest.TestHelpers.randomFerry();
            item.FerryId = 0;
            item = abe.CreateFerry(item);
            item.FerryName = "ANDERS AND";
            item = abe.UpdateFerry(item);

            Assert.AreEqual("ANDERS AND", item.FerryName);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateReservationTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Reservation item = UnitTest.TestHelpers.randomReservation();
            item.ReservationId = 0;
            item = abe.CreateReservation(item);
            item.TotalPrice = double.MaxValue;
            item = abe.UpdateReservation(item);

            Assert.AreEqual(double.MaxValue, item.TotalPrice);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateRouteTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Route item = UnitTest.TestHelpers.randomRoute();
            item.RouteId = 0;
            item = abe.CreateRoute(item);
            item.Duration = int.MaxValue;
            item = abe.UpdateRoute(item);

            Assert.AreEqual(int.MaxValue, item.Duration);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateTripTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Trip item = UnitTest.TestHelpers.randomTrip();
            item.TripId = 0;
            item = abe.CreateTrip(item);
            item.TripPrice = double.MaxValue;
            item = abe.UpdateTrip(item);

            Assert.AreEqual(double.MaxValue, item.TripPrice);
        }

        [TestMethod(), TestCategory("AdministrationBE")]
        public void UpdateVehicleTest()
        {
            AdministrationBE abe = new AdministrationBE();
            Contract.dto.Vehicle item = UnitTest.TestHelpers.randomVehicle();
            item.VehicleId = 0;
            item = abe.CreateVehicle(item);
            item.VehicleSize = int.MaxValue;
            item = abe.UpdateVehicle(item);
            Assert.AreEqual(int.MaxValue, item.VehicleSize);
        }
    }
}