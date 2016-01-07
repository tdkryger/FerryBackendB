using Contract.dto;
using Contract.eto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    public static class ReservationHandler
    {
        /// <summary>
        /// Should this delete the reservation, or what should it do?
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public static bool CancelCustomerReservation(int reservationId)
        {
            throw new ReservationNotFoundException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trip"></param>
        /// <param name="customer"></param>
        /// <param name="totalPrice"></param>
        /// <param name="numberOfPeople"></param>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public static Reservation CreateCustomerReservation(
            Trip trip,
            Customer customer,
            double totalPrice,
            int numberOfPeople,
            Vehicle vehicle)
        {
            Reservation reservation = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO reservations (customer_id, trip_id, vehicle_id, total_price, number_of_people) VALUES (@customer_id, @trip_id, @vehicle_id, @total_price, @number_of_people);select last_insert_id();";

                command.Parameters.AddWithValue("@customer_id", customer.CustomerId);
                command.Parameters.AddWithValue("@trip_id", trip.TripId);
                command.Parameters.AddWithValue("@vehicle_id", vehicle.VehicleId);
                command.Parameters.AddWithValue("@total_price", totalPrice);
                command.Parameters.AddWithValue("@number_of_people", numberOfPeople);

                reservation = new Reservation()
                {
                    ReservationId = Convert.ToInt32(command.ExecuteScalar()),
                    Customer = customer,
                    NumberOfPeople = numberOfPeople,
                    TotalPrice = totalPrice,
                    Trip = trip,
                    Vehicle = vehicle
                };
            });

            return reservation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public static Reservation CreateReservation(Reservation reservation)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO reservations (customer_id, trip_id, vehicle_id, total_price, number_of_people) VALUES (@customer_id, @trip_id, @vehicle_id, @total_price, @number_of_people);select last_insert_id();";

                command.Parameters.AddWithValue("@customer_id", reservation.Customer.CustomerId);
                command.Parameters.AddWithValue("@trip_id", reservation.Trip.TripId); //Should this be inserted in the db here, or is this fine?
                command.Parameters.AddWithValue("@vehicle_id", reservation.Vehicle.VehicleId);
                command.Parameters.AddWithValue("@total_price", reservation.TotalPrice);
                command.Parameters.AddWithValue("@number_of_people", reservation.NumberOfPeople);

                reservation.ReservationId = Convert.ToInt32(command.ExecuteScalar());
            });

            return reservation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public static Reservation ReadReservation(int reservationId)
        {
            Reservation reservation = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM reservations WHERE id = @id;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reservation = new Reservation()
                        {
                            ReservationId = reader.GetInt32("id"),
                            Customer = CustomerHandler.GetCustomer(reader.GetInt32("customer_id")), //I made that method, is that okay?
                            NumberOfPeople = reader.GetInt32("number_of_people"),
                            TotalPrice = reader.GetInt32("total_price"),
                            Trip = TripHandler.GetTrip(reader.GetInt32("trip_id")),
                            Vehicle = VehicleHandler.GetVehicle(reader.GetInt32("vehicle_id"))
                        };
                    }
                }
            });

            return reservation;
        }

        /// <summary>
        /// Loads of reservations in a few years..
        /// </summary>
        /// <returns></returns>
        public static List<Reservation> ReadAllReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM reservations;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reservations.Add(new Reservation()
                        {
                            ReservationId = reader.GetInt32("id"),
                            Customer = CustomerHandler.GetCustomer(reader.GetInt32("customer_id")), //I made that method, is that okay?
                            NumberOfPeople = reader.GetInt32("number_of_people"),
                            TotalPrice = reader.GetInt32("total_price"),
                            Trip = TripHandler.GetTrip(reader.GetInt32("trip_id")),
                            Vehicle = VehicleHandler.GetVehicle(reader.GetInt32("vehicle_id"))
                        });
                    }
                }
            });

            return reservations;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static List<Reservation> ReadAllCustomerReservations(Customer customer)
        {
            List<Reservation> reservations = new List<Reservation>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM reservations WHERE customer_id = @customer_id;";

                command.Parameters.AddWithValue("@customer_id", customer.CustomerId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reservations.Add(new Reservation()
                        {
                            ReservationId = reader.GetInt32("id"),
                            Customer = CustomerHandler.GetCustomer(reader.GetInt32("customer_id")), //I made that method, is that okay?
                            NumberOfPeople = reader.GetInt32("number_of_people"),
                            TotalPrice = reader.GetInt32("total_price"),
                            Trip = TripHandler.GetTrip(reader.GetInt32("trip_id")),
                            Vehicle = VehicleHandler.GetVehicle(reader.GetInt32("vehicle_id"))
                        });
                    }
                }
            });

            return reservations;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public static Reservation UpdateReservation(Reservation reservation)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE reservations SET " +
                                      "customer_id = @customer_id, " +
                                      "trip_id = @trip_id, " +
                                      "vehicle_id = @vehicle_id " +
                                      "total_price = @total_price " +
                                      "number_of_people = @number_of_people " +
                                      "WHERE id = @id;";

                command.Parameters.AddWithValue("@customer_id", reservation.Customer.CustomerId);
                command.Parameters.AddWithValue("@trip_id", reservation.Trip.TripId); //Should this be inserted in the db here, or is this fine?
                command.Parameters.AddWithValue("@vehicle_id", reservation.Vehicle.VehicleId);
                command.Parameters.AddWithValue("@total_price", reservation.TotalPrice);
                command.Parameters.AddWithValue("@number_of_people", reservation.NumberOfPeople);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    reservation = null;
                }
            });

            return reservation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public static bool DeleteReservation(Reservation reservation)
        {
            bool result = false; ;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM reservations WHERE id = @id;";

                command.Parameters.AddWithValue("@id", reservation.ReservationId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}