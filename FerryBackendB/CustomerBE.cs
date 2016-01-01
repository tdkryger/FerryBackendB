using Contract.dto;
using System.Collections.Generic;
using System;

namespace FerryBackendB
{
    public class CustomerBE : Contract.contract.CustomerContract
    {

        public bool CreateCustomer(Customer customer)
        {
            return (CustomerHandler.CreateCustomer(customer).CustomerId != 0);
        }

        public Reservation CreateCustomerReservation(Trip trip, Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle)
        {
            return ReservationHandler.CreateCustomerReservation(trip, customer, totalPrice, numberOfPeople, vehicle);
        }

        public List<Reservation> GetAllCustomerReservations(Customer customer)
        {
            return ReservationHandler.ReadAllCustomerReservations(customer);
        }

        public List<Trip> GetAllTrips()
        {
            return TripHandler.GetAllTrips();
        }

        public Contract.dto.Customer GetCustomerByLogin(string username, string password)
        {
            return CustomerHandler.ReadCustomer(username, password);
        }

        public bool CancelCustomerReservation(int reservationId)
        {
            return ReservationHandler.CancelCustomerReservation(reservationId);
        }

        public List<Route> GetAllRoutes()
        {
            return RouteHandler.GetAllRoutes();
        }

        public List<Vehicle> GetAllVehicles()
        {
            return VehicleHandler.GetAllVehicles();
        }
    }
}
