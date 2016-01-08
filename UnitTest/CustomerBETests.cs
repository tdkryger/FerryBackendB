using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FerryBackendB.Tests
{
    [TestClass()]
    public class CustomerBETests
    {
        [TestMethod(), TestCategory("CustomerBE")]
        public void CreateCustomerTest()
        {
            CustomerBE cbe = new CustomerBE();
            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 0;

            Assert.IsTrue(cbe.CreateCustomer(c));
        }


        [TestMethod(), TestCategory("CustomerBE")]
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

        [TestMethod(), TestCategory("CustomerBE")]
        public void GetAllCustomerReservationsTest()
        {
            int testNumber = 10;
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 1;
            cbe.CreateCustomer(c);

            for (int i=0;i< testNumber; i++)
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

        [TestMethod(), TestCategory("CustomerBE")]
        public void GetAllTripsTest()
        {
            CustomerBE cbe = new CustomerBE();
            List<Contract.dto.Trip> l = cbe.GetAllTrips();
            Assert.AreNotEqual(0, l.Count);
        }

        [TestMethod(), TestCategory("CustomerBE")]
        public void GetCustomerByLoginTest()
        {
            CustomerBE cbe = new CustomerBE();

            Contract.dto.Customer c = UnitTest.TestHelpers.randomCustomer();
            c.CustomerId = 1;
            c.Mail = UnitTest.TestHelpers.RandomWords(UnitTest.TestHelpers.GenerateRandomId(5, 15));
            c.Password = UnitTest.TestHelpers.RandomWords(UnitTest.TestHelpers.GenerateRandomId(5, 15));
            cbe.CreateCustomer(c);

            Contract.dto.Customer c2 = cbe.GetCustomerByLogin(c.Mail, c.Password);

            /// This might work, but because we use random mail and password, it only works sometimes (Most of the time)
            Assert.AreEqual(c.CustomerId, c2.CustomerId);
        }

        [TestMethod(), TestCategory("CustomerBE")]
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

        [TestMethod(), TestCategory("CustomerBE")]
        public void GetAllRoutesTest()
        {
            CustomerBE cbe = new CustomerBE();

            List<Contract.dto.Route> l = cbe.GetAllRoutes();
            Assert.IsTrue(l.Count >= 1);
        }

        [TestMethod(), TestCategory("CustomerBE")]
        public void GetAllVehiclesTest()
        {
            CustomerBE cbe = new CustomerBE();

            List<Contract.dto.Vehicle> l = cbe.GetAllVehicles();
            Assert.IsTrue(l.Count >= 1);
        }
    }
}