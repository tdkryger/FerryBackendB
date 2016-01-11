using MySql.Data.MySqlClient;
using System;
using System.Reflection;
using System.Text;

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

        public static T ReturnObjectFromReader<T>(MySqlDataReader reader)
        {
            T instanceOfT;

            instanceOfT = default(T);

            // For each entry (column) in the reader
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);

                foreach (PropertyInfo property in typeof(T).GetProperties())
                {
                    StringBuilder propertyName;

                    propertyName = new StringBuilder();

                    for (int j = 0; j < reader.GetName(i).Length; j++)
                    {
                        if (j == 0)
                            propertyName.Append(Char.ToUpper(reader.GetName(i)[j]));
                        else
                            if (reader.GetName(i)[j].Equals('_'))
                        {
                            j++;
                            propertyName.Append(Char.ToUpper(reader.GetName(i)[j]));
                        }
                        else
                            propertyName.Append(reader.GetName(i)[j]);
                    }
                    if (property.Name.Equals(columnName.ToString()))
                    {
                        Type type;
                        object value;

                        type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                        value = Convert.ChangeType(reader[i], type);

                        property.SetValue(instanceOfT, value);
                        break;
                    }
                }
            }

            return instanceOfT;
        }
    }
}