using Contract.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    /// <summary>
    /// 
    /// </summary>
    public static class CustomerHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static Customer CreateCustomer(Customer customer)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "INSERT INTO customers (first_name, last_name, mail, password, phone, postal_code, street, house_number, city, free_rides, native) VALUES (@first_name, @last_name, @mail, @password, @phone, @postal_code, @street, @house_number, @city, @free_rides, @native);select last_insert_id();";
                command.Parameters.AddWithValue("@first_name", customer.Firstname);
                command.Parameters.AddWithValue("@last_name", customer.Lastname);
                command.Parameters.AddWithValue("@mail", customer.Mail);
                command.Parameters.AddWithValue("@password", customer.Password);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@postal_code", customer.PostalCode);
                command.Parameters.AddWithValue("@street", customer.Street);
                command.Parameters.AddWithValue("@free_rides", customer.AmountOfFreeRides);
                command.Parameters.AddWithValue("@native", customer.Native);
                command.Parameters.AddWithValue("@city", customer.City);
                command.Parameters.AddWithValue("@house_number", customer.HouseNumber);

                customer.CustomerId = Convert.ToInt32(command.ExecuteScalar());
            });

            return customer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">dunno where to put this.. Sticking it in email..</param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Customer ReadCustomer(string username, string password)
        {
            Customer customer;

            customer = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM customers WHERE mail = @mail AND password = @password;";

                command.Parameters.AddWithValue("@mail", username);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer()
                        {
                            CustomerId = reader.GetInt32("id"),
                            Firstname = reader.GetString("first_name"),
                            Lastname = reader.GetString("last_name"),
                            Mail = reader.GetString("mail"),
                            Password = reader.GetString("password"),
                            Street = reader.GetString("street"),
                            HouseNumber = reader.GetString("house_number"),
                            PostalCode = reader.GetInt32("postal_code"),
                            City = reader.GetString("city"),
                            Phone = reader.GetString("phone"),
                            Native = reader.GetBoolean("native"),
                            AmountOfFreeRides = reader.GetInt32("free_rides")
                        };
                    }
                }
            });

            return customer;
        }

        /// <summary>
        /// Added because needed, not sure if we can do that?
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer GetCustomer(int id)
        {
            Customer customer;

            customer = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM customers WHERE id = @id;";

                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer()
                        {
                            CustomerId = reader.GetInt32("id"),
                            Firstname = reader.GetString("first_name"),
                            Lastname = reader.GetString("last_name"),
                            Mail = reader.GetString("mail"),
                            Password = reader.GetString("password"),
                            Street = reader.GetString("street"),
                            HouseNumber = reader.GetString("house_number"),
                            PostalCode = reader.GetInt32("postal_code"),
                            City = reader.GetString("city"),
                            Phone = reader.GetString("phone"),
                            Native = reader.GetBoolean("native"),
                            AmountOfFreeRides = reader.GetInt32("free_rides")
                        };
                    }
                }
            });

            return customer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static Customer ReadCustomer(string mail)
        {
            Customer customer;

            customer = null;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM customers WHERE mail = @mail;";

                command.Parameters.AddWithValue("@mail", mail);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer()
                        {
                            CustomerId = reader.GetInt32("id"),
                            Firstname = reader.GetString("first_name"),
                            Lastname = reader.GetString("last_name"),
                            Mail = reader.GetString("mail"),
                            Password = reader.GetString("password"),
                            Street = reader.GetString("street"),
                            HouseNumber = reader.GetString("house_number"),
                            PostalCode = reader.GetInt32("postal_code"),
                            City = reader.GetString("city"),
                            Phone = reader.GetString("phone"),
                            Native = reader.GetBoolean("native"),
                            AmountOfFreeRides = reader.GetInt32("free_rides")
                        };
                    }
                }
            });

            return customer;
        }

        /// <summary>
        /// Returns a list of all the customers
        /// </summary>
        /// <returns></returns>
        public static List<Customer> ReadAllCustomer()
        {
            List<Customer> customers = new List<Customer>();

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "SELECT * FROM customers;";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            CustomerId = reader.GetInt32("id"),
                            Firstname = reader.GetString("first_name"),
                            Lastname = reader.GetString("last_name"),
                            Mail = reader.GetString("mail"),
                            Password = reader.GetString("password"),
                            Street = reader.GetString("street"),
                            HouseNumber = reader.GetString("house_number"),
                            PostalCode = reader.GetInt32("postal_code"),
                            City = reader.GetString("city"),
                            Phone = reader.GetString("phone"),
                            Native = reader.GetBoolean("native"),
                            AmountOfFreeRides = reader.GetInt32("free_rides")
                        });
                    }
                }
            });

            return customers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static Customer UpdateCustomer(Customer customer)
        {
            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "UPDATE customers SET " +
                                          "first_name = @first_name, " +
                                          "last_name = @last_name, " +
                                          "phone = @phone, " +
                                          "mail = @mail, " +
                                          "password = @password, " +
                                          "house_number = @house_number, " +
                                          "postal_code = @postal_code, " +
                                          "city = @city, " +
                                          "native = @native, " +
                                          "free_rides = @free_rides " +
                                          "WHERE id = @id;";

                command.Parameters.AddWithValue("@first_name", customer.Firstname);
                command.Parameters.AddWithValue("@last_name", customer.Lastname);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@mail", customer.Mail);
                command.Parameters.AddWithValue("@password", customer.Password);
                command.Parameters.AddWithValue("@house_number", customer.HouseNumber);
                command.Parameters.AddWithValue("@postal_code", customer.PostalCode);
                command.Parameters.AddWithValue("@street", customer.Street);
                command.Parameters.AddWithValue("@city", customer.City);
                command.Parameters.AddWithValue("@native", customer.Native);
                command.Parameters.AddWithValue("@free_rides", customer.AmountOfFreeRides);
                command.Parameters.AddWithValue("@id", customer.CustomerId);

                int rowsAffected = command.ExecuteNonQuery();

                //If the update fails, customer is set to null
                if (rowsAffected != 1)
                {
                    customer = null;
                }
            });

            return customer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static bool DeleteCustomer(Customer customer)
        {
            bool result = false;

            DBUtility.HandleConnection((MySqlCommand command) =>
            {
                command.CommandText = "DELETE FROM customers WHERE id = @id;";

                command.Parameters.AddWithValue("@id", customer.CustomerId);

                result = command.ExecuteNonQuery() == 1;
            });

            return result;
        }
    }
}