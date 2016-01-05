using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// 
    /// </summary>
    public static class DockHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dock"></param>
        /// <returns></returns>
        public static Dock CreateDock(Dock dock)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO dock (name, ferry_capacity) VALUES (@name, @ferry_capacity);select last_insert_id();";

                command.Parameters.AddWithValue("@name", dock.DockName);
                command.Parameters.AddWithValue("@ferry_capacity", dock.FerryCapacity);

                dock.DockId = Convert.ToInt32(command.ExecuteScalar());
            });

            return dock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Dock> GetAllDocks()
        {
            List<Dock> docks = new List<Dock>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM docks;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        docks.Add(new Dock()
                        {
                            DockId = reader.GetInt32("id"),
                            DockName = reader.GetString("name"),
                            FerryCapacity = reader.GetInt32("cferry_capacity")
                        });
                    }
                }
            });

            return docks;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dockId"></param>
        /// <returns></returns>
        public static Dock GetDock(int dockId)
        {
            Dock dock = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM docks WHERE id = @id;";

                command.Parameters.AddWithValue("@id", dockId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dock = new Dock()
                        {
                            DockId = reader.GetInt32("id"),
                            DockName = reader.GetString("name"),
                            FerryCapacity = reader.GetInt32("cferry_capacity")
                        };
                    }
                }
            });

            return dock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dock"></param>
        /// <returns></returns>
        public static Dock UpdateDock(Dock dock)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE docks SET " +
                                          "name = @name, " +
                                          "ferry_capacity = @ferry_capacity " +
                                          "WHERE id = @id;";

                command.Parameters.AddWithValue("@name", dock.DockName);
                command.Parameters.AddWithValue("@ferry_capacity", dock.FerryCapacity);
                command.Parameters.AddWithValue("@id", dock.DockId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    dock = null;
                }
            });

            return dock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dock"></param>
        /// <returns></returns>
        public static bool DeleteDock(Dock dock)
        {
            bool result = false; ;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM docks WHERE id = @id;";

                command.Parameters.AddWithValue("@id", dock.DockId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}