using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// 
    /// </summary>
    public static class TripHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        public static Trip CreateTrip(Trip trip)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO trips (departure_time, route_id, ferry_id, price) VALUES (@departure_time, @route_id, @ferry_id, @price);select last_insert_id();";

                command.Parameters.AddWithValue("@departure_time", trip.DepatureTime);
                command.Parameters.AddWithValue("@route_id", trip.Route.RouteId);
                command.Parameters.AddWithValue("@ferry_id", trip.Ferry.FerryId);
                command.Parameters.AddWithValue("@price", trip.TripPrice);

                trip.TripId = Convert.ToInt32(command.ExecuteScalar());
            });

            return trip;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tripId"></param>
        /// <returns></returns>
        public static Trip GetTrip(int tripId)
        {
            Trip trip = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM trips WHERE id = @id;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        trip = new Trip()
                        {
                            TripId = reader.GetInt32("id"),
                            DepatureTime = reader.GetDateTime("departure_time"),
                            Ferry = FerryHandler.GetFerry(reader.GetInt32("ferry_id")),
                            Route = RouteHandler.GetRoute(reader.GetInt32("route_id")),
                            TripPrice = reader.GetDouble("price") // Possible loss of precision, use decimal instead
                        };
                    }
                }
            });

            return trip;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Trip> GetAllTrips()
        {
            List<Trip> trips = new List<Trip>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM trips;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        trips.Add(new Trip()
                        {
                            TripId = reader.GetInt32("id"),
                            DepatureTime = reader.GetDateTime("departure_time"),
                            Ferry = FerryHandler.GetFerry(reader.GetInt32("ferry_id")),
                            Route = RouteHandler.GetRoute(reader.GetInt32("route_id")),
                            TripPrice = reader.GetDouble("price") // Possible loss of precision, use decimal instead
                        });
                    }
                }
            });

            return trips;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        public static Trip UpdateTrip(Trip trip)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE trips SET " +
                                      "departure_time = @departure_time, " +
                                      "route_id = @route_id, " +
                                      "ferry_id = @ferry_id, " +
                                      "price = @price " +
                                      "WHERE id = @id;";

                command.Parameters.AddWithValue("@departure_time", trip.DepatureTime);
                command.Parameters.AddWithValue("@route_id", trip.Route.RouteId);
                command.Parameters.AddWithValue("@ferry_id", trip.Ferry.FerryId);
                command.Parameters.AddWithValue("@price", trip.TripPrice); //Again, possible loss of precision
                command.Parameters.AddWithValue("@id", trip.TripId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    trip = null;
                }
            });

            return trip;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        public static bool DeleteTrip(Trip trip)
        {
            bool result = false; ;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM trips WHERE id = @id;";

                command.Parameters.AddWithValue("@id", trip.TripId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}