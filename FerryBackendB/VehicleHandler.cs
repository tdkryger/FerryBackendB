using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// Remember to update the db before using this size must be int
    /// </summary>
    public static class VehicleHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public static Vehicle CreateVehicle(Vehicle vehicle)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO vehicles (size, type, price) VALUES (@size, @type, @price);select last_insert_id();";

                command.Parameters.AddWithValue("@size", vehicle.VehicleSize);
                command.Parameters.AddWithValue("@type", vehicle.VehicleType);
                command.Parameters.AddWithValue("@price", vehicle.VehiclePrice);

                vehicle.VehicleId = Convert.ToInt32(command.ExecuteScalar());
            });

            return vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public static Vehicle GetVehicle(int vehicleId)
        {
            Vehicle vehicle = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM vehicles WHERE id = @id;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehicle = new Vehicle()
                        {
                            VehicleId = reader.GetInt32("id"),
                            VehiclePrice = reader.GetDouble("price"),
                            VehicleSize = reader.GetInt32("size"), // This was a string in the db, so this might fail, if it hasn't been updated yet
                            VehicleType = reader.GetString("type")
                        };
                    }
                }
            });

            return vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM vehicles;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehicles.Add(new Vehicle()
                        {
                            VehicleId = reader.GetInt32("id"),
                            VehiclePrice = reader.GetDouble("price"),
                            VehicleSize = reader.GetInt32("size"), // This was a string in the db, so this might fail, if it hasn't been updated yet
                            VehicleType = reader.GetString("type")
                        });
                    }
                }
            });

            return vehicles;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public static Vehicle UpdateVehicle(Vehicle vehicle)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE vehicles SET " +
                                      "size = @size, " +
                                      "type = @type, " +
                                      "price = @price " +
                                      "WHERE id = @id;";

                command.Parameters.AddWithValue("@size", vehicle.VehicleSize);
                command.Parameters.AddWithValue("@type", vehicle.VehicleType);
                command.Parameters.AddWithValue("@price", vehicle.VehiclePrice); //Again, possible loss of precision
                command.Parameters.AddWithValue("@id", vehicle.VehicleId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    vehicle = null;
                }
            });

            return vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public static bool DeleteVehicle(Contract.dto.Vehicle vehicle)
        {
            bool result = false; ;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM vehicles WHERE id = @id;";

                command.Parameters.AddWithValue("@id", vehicle.VehicleId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}
