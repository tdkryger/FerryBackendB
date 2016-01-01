using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class ReservationHandler
    {
        public static Contract.dto.Reservation random()
        {
            return new Contract.dto.Reservation()
            {
                Customer = CustomerHandler.random(),
                NumberOfPeople = MySQLConn.GenerateRandomId(1, 10),
                ReservationId = MySQLConn.GenerateRandomId(),
                TotalPrice = (double)(MySQLConn.GenerateRandomId(1000, 10000) / 10),
                Trip = TripHandler.random(),
                Vehicle = VehicleHandler.random()
            };
        }


        public static bool CancelCustomerReservation(int reservationId)
        {
            return true;
        }

        [Obsolete("Change in interface", true)]
        public static bool CancelCustomerReservation(Contract.dto.Reservation reservation)
        {
            return true;
        }

        public static Contract.dto.Reservation CreateCustomerReservation(
            Contract.dto.Trip trip, 
            Contract.dto.Customer customer, 
            double totalPrice, 
            int numberOfPeople, 
            Contract.dto.Vehicle vehicle)
        {
            Contract.dto.Reservation r = new Contract.dto.Reservation()
            {
                Customer = customer,
                NumberOfPeople = numberOfPeople,
                ReservationId = MySQLConn.GenerateRandomId(),
                TotalPrice = totalPrice,
                Trip = trip,
                Vehicle = vehicle,                
            };

            return r;
        }

        public static Contract.dto.Reservation CreateReservation(Contract.dto.Reservation reservation)
        {
            reservation.ReservationId = MySQLConn.GenerateRandomId();
            return reservation;
        }

        public static Contract.dto.Reservation ReadReservation(int reservationId)
        {
            Contract.dto.Reservation r = random();
            r.ReservationId = reservationId;
            return r;
        }

        /// <summary>
        /// Loads of reservations in a few years..
        /// </summary>
        /// <returns></returns>
        public static List<Contract.dto.Reservation> ReadAllReservations()
        {
            List<Contract.dto.Reservation> l = new List<Contract.dto.Reservation>();
            int max = MySQLConn.GenerateRandomId(1000, int.MaxValue);
            for(int i=1; i < max;i++)
            {
                l.Add(ReadReservation(i));
            }
            return l;
        }

        public static List<Contract.dto.Reservation> ReadAllCustomerReservations(Contract.dto.Customer customer)
        {
            throw new NotImplementedException();
        }


        public static Contract.dto.Reservation UpdateReservation(Contract.dto.Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public static bool DeleteReservation(Contract.dto.Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
