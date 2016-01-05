using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// 
    /// </summary>
    public static class FerryHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferry"></param>
        /// <returns></returns>
        public static Ferry CreateFerry(Ferry ferry)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO ferries (name, size, passenger_capacity, vehicle_capacity, municipality, dock_id) VALUES (@name, @size, @passenger_capacity, @vehicle_capacity, @municipality, @dock_id);select last_insert_id();";

                command.Parameters.AddWithValue("@name", ferry.FerryName);
                command.Parameters.AddWithValue("@size", ferry.FerrySize);
                command.Parameters.AddWithValue("@passenger_capacity", ferry.PassengerCapacity);
                command.Parameters.AddWithValue("@vehicle_capacity", ferry.VehicleCapacity);
                command.Parameters.AddWithValue("@municipality", ferry.Municipality);
                command.Parameters.AddWithValue("@dock_id", ferry.Dock.DockId);

                ferry.FerryId = Convert.ToInt32(command.ExecuteScalar());
            });

            return ferry;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferryId"></param>
        /// <returns></returns>
        public static Ferry GetFerry(int ferryId)
        {
            Ferry ferry = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM ferries WHERE id = @id;";

                command.Parameters.AddWithValue("@id", ferryId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ferry = new Ferry()
                        {
                            FerryId = reader.GetInt32("id"),
                            FerryName = reader.GetString("name"),
                            FerrySize = reader.GetString("size"),
                            PassengerCapacity = reader.GetInt32("passenger_capacity"),
                            VehicleCapacity = reader.GetInt32("vehicle_capacity"),
                            Municipality = reader.GetString("municipality"),
                            Dock = DockHandler.GetDock(reader.GetInt32("dock_id"))
                        };
                    }
                }
            });

            return ferry;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Ferry> GetAllFerries()
        {
            List<Ferry> ferries = new List<Ferry>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM ferries;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ferries.Add(new Ferry()
                        {
                            FerryId = reader.GetInt32("id"),
                            FerryName = reader.GetString("name"),
                            FerrySize = reader.GetString("size"),
                            PassengerCapacity = reader.GetInt32("passenger_capacity"),
                            VehicleCapacity = reader.GetInt32("vehicle_capacity"),
                            Municipality = reader.GetString("municipality"),
                            Dock = DockHandler.GetDock(reader.GetInt32("dock_id"))
                        });
                    }
                }
            });

            return ferries;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferry"></param>
        /// <returns></returns>
        public static Ferry UpdateFerry(Ferry ferry)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE ferries SET " +
                                          "name = @name, " +
                                          "size = @size, " +
                                          "passenger_capacity = @passenger_capacity, " +
                                          "vehicle_capacity = @vehicle_capacity, " +
                                          "municipality = @municipality, " +
                                          "dock_id = @dock_id " +
                                          "WHERE id = @id;";

                command.Parameters.AddWithValue("@name", ferry.FerryName);
                command.Parameters.AddWithValue("@size", ferry.FerrySize);
                command.Parameters.AddWithValue("@passenger_capacity", ferry.PassengerCapacity);
                command.Parameters.AddWithValue("@vehicle_capacity", ferry.VehicleCapacity);
                command.Parameters.AddWithValue("@municipality", ferry.Municipality);
                command.Parameters.AddWithValue("@dock_id", ferry.Dock.DockId);
                command.Parameters.AddWithValue("@id", ferry.FerryId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    ferry = null;
                }
            });

            return ferry;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferry"></param>
        /// <returns></returns>
        public static bool DeleteFerry(Ferry ferry)
        {
            bool result = false; ;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM ferries WHERE id = @id;";

                command.Parameters.AddWithValue("@id", ferry.FerryId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}