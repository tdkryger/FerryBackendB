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
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Reservation r = cbe.CreateCustomerReservation(
                UnitTest.TestHelpers.randomTrip(),
                UnitTest.TestHelpers.randomCustomer(),
                24.3,
                UnitTest.TestHelpers.GenerateRandomId(1, 10),
                UnitTest.TestHelpers.randomVehicle()
                );
            Assert.AreNotEqual(0, r.ReservationId);
        }

        [TestMethod()]
        public void GetAllCustomerReservationsTest()
        {
            int testNumber = 10;
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 1;
            cbe.CreateCustomer(c);

            for (int i=1;i< testNumber; i++)
            {
                cbe.CreateCustomerReservation(
                                UnitTest.TestHelpers.randomTrip(),
                                c,
                                24.3,
                                UnitTest.TestHelpers.GenerateRandomId(1, 10),
                                UnitTest.TestHelpers.randomVehicle()
                                );
            }

            List<Contract.dto.Reservation> l = cbe.GetAllCustomerReservations(c);
            Assert.AreEqual(testNumber, l.Count);
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            CustomerBE cbe = new CustomerBE();
            List<Contract.dto.Trip> l = cbe.GetAllTrips();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod()]
        public void GetCustomerByLoginTest()
        {
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 1;
            c.Mail = "anders@and.com";
            c.Password = "qwerty123456";
            cbe.CreateCustomer(c);

            Contract.dto.Customer c2 = cbe.GetCustomerByLogin(c.Mail, c.Password);

            Assert.AreEqual(c.CustomerId, c2.CustomerId);
        }

        [TestMethod()]
        public void CancelCustomerReservationTest()
        {
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Reservation r = cbe.CreateCustomerReservation(
                UnitTest.TestHelpers.randomTrip(),
                UnitTest.TestHelpers.randomCustomer(),
                24.3,
                UnitTest.TestHelpers.GenerateRandomId(1, 10),
                UnitTest.TestHelpers.randomVehicle()
                );

            Assert.IsTrue(cbe.CancelCustomerReservation(r.ReservationId));

        }

        [TestMethod()]
        public void GetAllRoutesTest()
        {
            int testNumber = 0; // No way to create routes...
            CustomerBE cbe = new CustomerBE();

            List<Contract.dto.Route> l = cbe.GetAllRoutes();
            Assert.AreEqual(testNumber, l.Count);
        }

        [TestMethod()]
        public void GetAllVehiclesTest()
        {
            int testNumber = 0; // No way to create vehicles...
            CustomerBE cbe = new CustomerBE();

            List<Contract.dto.Vehicle> l = cbe.GetAllVehicles();
            Assert.AreEqual(testNumber, l.Count);

        }
    }
}