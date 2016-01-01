using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class ReservationHandler
    {

        public static bool CancelCustomerReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        [Obsolete("Change in interface", true)]
        public static bool CancelCustomerReservation(Contract.dto.Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public static Contract.dto.Reservation CreateCustomerReservation(Contract.dto.Trip trip, Contract.dto.Customer customer, double totalPrice, int numberOfPeople, Contract.dto.Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public static Contract.dto.Reservation CreateReservation(Contract.dto.Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public static Contract.dto.Reservation ReadReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads of reservations in a few years..
        /// </summary>
        /// <returns></returns>
        public static List<Contract.dto.Reservation> ReadAllReservations()
        {
            throw new NotImplementedException();
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
