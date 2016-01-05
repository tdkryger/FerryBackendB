using MySql.Data.MySqlClient;
using System;

namespace FerryBackendB
{
    public static class DBUtility
    {
        public static void HandleConnection(Action<MySqlCommand> method)
        {
            MySqlConnection connection;

            connection = new MySqlConnection();

            connection.ConnectionString = string.Format("Server = {0}; Database = {1}; Uid = {2}; Pwd = {3};",
                                                        "77.66.48.115",
                                                        "cluster_b",
                                                        "cluster_b",
                                                        "password");
            try {
                connection.Open();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    method(command);
                }

            } catch (Exception e) {
                Console.Out.WriteLine(e.Message);
            } finally {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}