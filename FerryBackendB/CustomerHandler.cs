using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FerryBackendB
{
    static class CustomerHandler
    {
        public static Contract.dto.Customer random()
        {
            int free = MySQLConn.GenerateRandomId(0, 10);
            Contract.dto.Customer c = new Contract.dto.Customer()
            {
                AmountOfFreeRides = free,
                City = MySQLConn.RandomWords(10),
                CustomerId = MySQLConn.GenerateRandomId(),
                Firstname = MySQLConn.RandomWords(10),
                HouseNumber = MySQLConn.GenerateRandomId(1, 300).ToString(),
                Lastname = MySQLConn.RandomWords(10),
                Mail = MySQLConn.RandomWords(10),
                Native = (free > 0),
                Password = MySQLConn.RandomWords(10),
                Phone = "12345678",
                PostalCode = 1,
                Street = MySQLConn.RandomWords(10)
            };
            return c;
        }

        public static Contract.dto.Customer CreateCustomer(Contract.dto.Customer customer)
        {
            MySqlConnection connection = MySQLConn.Connection();
            MySqlCommand command;
            connection.Open();

            try
            {
                command = connection.CreateCommand();
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
            }
            catch (Exception e)
            {
                //Do something with the error
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return customer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">dunno where to put this.. Sticking it in email..</param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Contract.dto.Customer ReadCustomer(string username, string password)
        {
            int free = MySQLConn.GenerateRandomId(0, 10);
            return new Contract.dto.Customer()
            {
                AmountOfFreeRides = free,
                City = "Andeby",
                CustomerId = MySQLConn.GenerateRandomId(),
                Firstname = "Anders",
                HouseNumber = "111",
                Lastname = "And",
                Mail = username,
                Native = (free > 0),
                Password = password,
                Phone = "12345678",
                PostalCode = 1,
                Street = "Paradisæblevej"
            };
        }
        public static Contract.dto.Customer ReadCustomer(string mail)
        {
            int free = MySQLConn.GenerateRandomId(0, 10);
            return new Contract.dto.Customer()
            {
                AmountOfFreeRides = free,
                City = "Andeby",
                CustomerId = MySQLConn.GenerateRandomId(),
                Firstname = "Anders",
                HouseNumber = "111",
                Lastname = "And",
                Mail = mail,
                Native = (free > 0),
                Password = "",
                Phone = "12345678",
                PostalCode = 1,
                Street = "Paradisæblevej"
            };
        }
        /// <summary>
        /// Retuens a list of somewhat random customers
        /// </summary>
        /// <returns></returns>
        public static List<Contract.dto.Customer> ReadAllCustomer()
        {
            List<Contract.dto.Customer> ll = new List<Contract.dto.Customer>();
            int max = MySQLConn.GenerateRandomId(10, 10000);
            for (int i = 1; i < max; i++)
            {
                int free = MySQLConn.GenerateRandomId(0, 10);
                Contract.dto.Customer c = random();
                c.CustomerId = i;
                ll.Add(c);
            }

            return ll;
        }

        public static Contract.dto.Customer UpdateCustomer(Contract.dto.Customer customer)
        {
            return customer;
        }

        public static bool DeleteCustomer(Contract.dto.Customer customer)
        {
            return true;
        }
    }
}
