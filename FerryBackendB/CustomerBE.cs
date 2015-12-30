using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.dto;

namespace FerryBackendB
{
    public class CustomerBE : Contract.contract.CustomerContract
    {

        public bool CancelCustomerReservation(Reservation reservation)
        {
            ReservationHandler.CancelCustomerReservation(reservation);
            throw new NotImplementedException();
        }

        public bool CreateCustomer(Contract.dto.Customer customer)
        {
            Customer c = CustomerHandler.CreateCustomer(customer);
            return (c.CustomerId != 0);
        }

        public Reservation CreateCustomerReservation(Trip trip, Contract.dto.Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle)
        {
            return ReservationHandler.CreateCustomerReservation(trip, customer, totalPrice, numberOfPeople, vehicle);
        }

        public List<Reservation> GetAllCustomerReservations(Contract.dto.Customer customer)
        {
            return ReservationHandler.ReadAllCustomerReservations(customer);
        }

        public List<Trip> GetAllTrips()
        {
            //´Holy shit. In a few years thats a big list....
            // Let's make this! And return a million trips....
            return TripHandler.GetAllTrips();
        }

        public Contract.dto.Customer GetCustomerByLogin(string username, string password)
        {
            return CustomerHandler.ReadCustomerByLogin(username, password);
        }
    }
}
