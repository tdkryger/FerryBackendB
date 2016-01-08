using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// This class needs some attention. Departure and destination
    /// </summary>
    public static class RouteHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public static Route CreateRoute(Route route)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO routes (departure_dock_id, destination_dock_id, duration) VALUES (@departure_dock_id, @destination_dock_id, @duration);select last_insert_id();";

                command.Parameters.AddWithValue("departure_dock_id", route.Depature); //This WILL crash, it should be a reference to a dock, not just a string
                command.Parameters.AddWithValue("destination_dock_id", route.Destination); //This WILL crash, it should be a reference to a dock, not just a string
                command.Parameters.AddWithValue("duration", route.Duration);

                route.RouteId = Convert.ToInt32(command.ExecuteScalar());
            });

            return route;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeId"></param>
        /// <returns></returns>
        public static Route GetRoute(int routeId)
        {
            Route route = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM routes WHERE id = @id;";

                command.Parameters.AddWithValue("@id", routeId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        route = new Route()
                        {
                            Depature = DockHandler.GetDock(reader.GetInt32("departure_dock_id")).DockName, //This is stupid, it should be a dock object
                            Destination = DockHandler.GetDock(reader.GetInt32("destination_dock_id")).DockName, //This is stupid, it should be a dock object
                            Duration = reader.GetInt32("duration"),
                            RouteId = reader.GetInt32("id")
                        };
                    }
                }
            });

            return route;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Route> GetAllRoutes()
        {
            List<Route> routes = new List<Route>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM routes;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        routes.Add(new Route()
                        {
                            Depature = DockHandler.GetDock(reader.GetInt32("departure_dock_id")).DockName, //This is stupid, it should be a dock object
                            Destination = DockHandler.GetDock(reader.GetInt32("destination_dock_id")).DockName, //This is stupid, it should be a dock object
                            Duration = reader.GetInt32("duration"),
                            RouteId = reader.GetInt32("id")
                        });
                    }
                }
            });

            return routes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public static Route UpdateRoute(Route route)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE routes SET " +
                                          "departure_dock_id = @departure_dock_id, " +
                                          "destination_dock_id = @destination_dock_id, " +
                                          "duration = @duration " +
                                          "WHERE id = @id;";

                command.Parameters.AddWithValue("@departure_dock_id", route.Depature); //This WILL crash, it should be a reference to a dock, not just a string
                command.Parameters.AddWithValue("@destination_dock_id", route.Destination); //This WILL crash, it should be a reference to a dock, not just a string
                command.Parameters.AddWithValue("@duration", route.Duration);
                command.Parameters.AddWithValue("@id", route.RouteId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, dock is set to null
                if (rowsAffected != 1)
                {
                    route = null;
                }
            });

            return route;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public static bool DeleteRoute(Route route)
        {
            bool result = false;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM routes WHERE id = @id;";

                command.Parameters.AddWithValue("@id", route.RouteId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}