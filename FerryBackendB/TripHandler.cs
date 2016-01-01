using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class TripHandler
    {
        public static Contract.dto.Trip random()
        {
            return new Contract.dto.Trip()
            {
                DepatureTime = DateTime.Now,
                Ferry = FerryHandler.random(),
                Route = RouteHandler.random(),
                TripId = MySQLConn.GenerateRandomId(),
                TripPrice = (double)(MySQLConn.GenerateRandomId(1000, 10000) / 10)
            };
        }

        public static Contract.dto.Trip CreateTrip(Contract.dto.Trip trip)
        {
            trip.TripId = MySQLConn.GenerateRandomId();
            return trip;
        }

        public static Contract.dto.Trip GetTrip(int tripId)
        {
            Contract.dto.Trip trip = random();
            trip.TripId = MySQLConn.GenerateRandomId();
            return trip;
        }

        public static List<Contract.dto.Trip> GetAllTrips()
        {
            List<Contract.dto.Trip> l = new List<Contract.dto.Trip>();
            int max = MySQLConn.GenerateRandomId(10, 10000);
            for (int i = 1; i <= max; i++)
            {
                Contract.dto.Trip r = random();
                r.TripId = i;
                l.Add(r);
            }
            return l;
        }

        public static Contract.dto.Trip UpdateTrip(Contract.dto.Trip trip)
        {
            return trip;
        }


        public static bool DeleteTrip(Contract.dto.Trip trip)
        {
            return true;
        }
    }
}
