using Contract.contract;
using Contract.dto;
using System.Collections.Generic;

namespace FerryBackendB
{
    public class AdministrationBE : AdminstrationContract
    {
        public Customer CreateCustomer(Customer customer)
        {
            return  CustomerHandler.CreateCustomer(customer);
        }

        public Dock CreateDock(Dock dock)
        {
            return DockHandler.CreateDock(dock);
        }

        public Ferry CreateFerry(Ferry ferry)
        {
            return FerryHandler.CreateFerry(ferry);
        }

        public Reservation CreateReservation(Reservation reservation)
        {
            return ReservationHandler.CreateReservation(reservation);
        }

        public Route CreateRoute(Route route)
        {
            return RouteHandler.CreateRoute(route);
        }

        public Trip CreateTrip(Trip trip)
        {
            return TripHandler.CreateTrip(trip);
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            return VehicleHandler.CreateVehicle(vehicle);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return CustomerHandler.DeleteCustomer(customer);
        }
        public bool DeleteDock(Dock dock)
        {
            return DockHandler.DeleteDock(dock);
        }

        public bool DeleteFerry(Ferry ferry)
        {
            return FerryHandler.DeleteFerry(ferry);
        }

        public bool DeleteReservation(Reservation reservation)
        {
            return ReservationHandler.DeleteReservation(reservation);
        }

        public bool DeleteRoute(Route route)
        {
            return RouteHandler.DeleteRoute(route);
        }

        public bool DeleteTrip(Trip trip)
        {
            return TripHandler.DeleteTrip(trip);
        }

        public bool DeleteVehicle(Vehicle vehicle)
        {
            return VehicleHandler.DeleteVehicle(vehicle);
        }

        public List<Dock> GetAllDocks()
        {
            return DockHandler.GetAllDocks(); // Weeee
        }

        public List<Ferry> GetAllFerries() // Weeee
        {
            return FerryHandler.GetAllFerries();
        }

        public List<Reservation> GetAllReservations() // Weeee
        {
            return ReservationHandler.ReadAllReservations();
        }

        public List<Route> GetAllRoutes() // Weeee
        {
            return RouteHandler.GetAllRoutes();
        }

        public List<Trip> GetAllTrips() // Weeee
        {
            return TripHandler.GetAllTrips();
        }

        public List<Vehicle> GetAllVehicles() // Weeee
        {
            return VehicleHandler.GetAllVehicles();
        }

        public Dock GetDock(int dockId)
        {
            return DockHandler.GetDock(dockId);
        }

        public Ferry GetFerry(int ferryId)
        {
            return FerryHandler.GetFerry(ferryId);
        }

        public Reservation GetReservation(int reservationId)
        {
            return ReservationHandler.ReadReservation(reservationId);
        }

        public Route GetRoute(int routeId)
        {
            return RouteHandler.GetRoute(routeId);
        }

        public Trip GetTrip(int tripId)
        {
            return TripHandler.GetTrip(tripId);
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            return VehicleHandler.GetVehicle(vehicleId);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return CustomerHandler.UpdateCustomer(customer);
        }

        public Dock UpdateDock(Dock dock)
        {
            return DockHandler.UpdateDock(dock);
        }

        public Ferry UpdateFerry(Ferry ferry)
        {
            return FerryHandler.UpdateFerry(ferry);
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            return ReservationHandler.UpdateReservation(reservation);
        }

        public Route UpdateRoute(Route route)
        {
            return RouteHandler.UpdateRoute(route);
        }

        public Trip UpdateTrip(Trip trip)
        {
            return TripHandler.UpdateTrip(trip);
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            return VehicleHandler.UpdateVehicle(vehicle);
        }

        List<Customer> AdminstrationContract.GetAllCustomer()
        {
            return CustomerHandler.ReadAllCustomer();
        }

        Customer AdminstrationContract.GetCustomer(string mail)
        {
            return CustomerHandler.ReadCustomer(mail);
        }
    }
}
