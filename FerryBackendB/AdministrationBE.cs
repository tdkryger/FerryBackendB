using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.contract;
using Contract.dto;

namespace FerryBackendB
{
    public class AdministrationBE : Contract.contract.AdminstrationContract
    {
        public Contract.dto.Customer CreateCustomer(Contract.dto.Customer customer)
        {
            return  CustomerHandler.CreateCustomer(customer);
        }

        public Dock CreateDock(Dock dock)
        {
            throw new NotImplementedException();
        }

        public Ferry CreateFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        public Reservation CreateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Route CreateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public Trip CreateTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Contract.dto.Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(CustomerBE customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDock(Dock dock)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public List<CustomerBE> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Dock> GetAllDocks()
        {
            throw new NotImplementedException();
        }

        public List<Ferry> GetAllFerries()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllReservations()
        {
            throw new NotImplementedException();
        }

        public List<Route> GetAllRoutes()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public CustomerBE GetCustomer(string mail)
        {
            throw new NotImplementedException();
        }

        public Dock GetDock(int dockId)
        {
            throw new NotImplementedException();
        }

        public Ferry GetFerry(int ferryId)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public Route GetRoute(int routeId)
        {
            throw new NotImplementedException();
        }

        public Trip GetTrip(int tripId)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Contract.dto.Customer UpdateCustomer(Contract.dto.Customer customer)
        {
            throw new NotImplementedException();
        }

        public CustomerBE UpdateCustomer(CustomerBE customer)
        {
            throw new NotImplementedException();
        }

        public Dock UpdateDock(Dock dock)
        {
            throw new NotImplementedException();
        }

        public Ferry UpdateFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Route UpdateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public Trip UpdateTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        List<Customer> AdminstrationContract.GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        Customer AdminstrationContract.GetCustomer(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
