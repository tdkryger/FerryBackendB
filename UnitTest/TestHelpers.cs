using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    static class TestHelpers
    {
        #region helpers
        private static Random rnd = new Random(DateTime.Now.Millisecond);
        /// <summary>
        /// Generates a random id
        /// </summary>
        /// <returns> int between 1 and int.MaxValue</returns>
        public static int GenerateRandomId()
        {
            return rnd.Next(1, int.MaxValue);
        }

        public static int GenerateRandomId(int min, int max)
        {
            return rnd.Next(min, max);
        }

        public static string RandomWords(int num_letters)
        {
            // Make an array of the letters we will use.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Make a random number generator.
            Random rand = new Random();

            // Make the words.
            // Make a word.
            string word = string.Empty;
            for (int j = 1; j <= num_letters; j++)
            {
                // Pick a random number between 0 and 25
                // to select a letter from the letters array.
                int letter_num = rand.Next(0, letters.Length - 1);

                // Append the letter.
                word += letters[letter_num];
            }
            return word;
        }

        public static Contract.dto.Customer randomCustomer()
        {
            int free = GenerateRandomId(0, 10);
            return new Contract.dto.Customer()
            {
                AmountOfFreeRides = free,
                City = RandomWords(10),
                CustomerId = 0,
                Firstname = RandomWords(10),
                HouseNumber = GenerateRandomId(1, 300).ToString(),
                Lastname = RandomWords(10),
                Mail = RandomWords(10),
                Native = (free > 0),
                Password = RandomWords(10),
                Phone = "12345678",
                PostalCode = 1,
                Street = RandomWords(10)
            };
        }

        public static Contract.dto.Dock randomDock()
        {
            return new Contract.dto.Dock()
            {
                DockId = GenerateRandomId(),
                DockName = RandomWords(25),
                FerryCapacity = GenerateRandomId(1, 10)
            };
        }

        public static Contract.dto.Ferry randomFerry()
        {
            return new Contract.dto.Ferry()
            {
                Dock = randomDock(),
                FerryId = GenerateRandomId(),
                FerryName = RandomWords(10),
                FerrySize = RandomWords(10),
                Municipality = RandomWords(10),
                PassengerCapacity = GenerateRandomId(10, 500),
                VehicleCapacity = GenerateRandomId(10, 500),
            };

        }

        public static Contract.dto.Reservation randomReservation()
        {
            return new Contract.dto.Reservation()
            {
                Customer = randomCustomer(),
                NumberOfPeople = GenerateRandomId(1, 10),
                ReservationId = GenerateRandomId(),
                TotalPrice = (double)(GenerateRandomId(1000, 10000) / 10),
                Trip = randomTrip(),
                Vehicle = randomVehicle()
            };
        }

        public static Contract.dto.Route randomRoute()
        {
            return new Contract.dto.Route()
            {
                Depature = RandomWords(30),
                Destination = RandomWords(30),
                Duration = GenerateRandomId(10, 1000),
                RouteId = GenerateRandomId()
            };
        }

        public static Contract.dto.Trip randomTrip()
        {
            return new Contract.dto.Trip()
            {
                DepatureTime = DateTime.Now,
                Ferry = randomFerry(),
                Route = randomRoute(),
                TripId = GenerateRandomId(),
                TripPrice = (double)(GenerateRandomId(1000, 10000) / 10)
            };
        }

        public static Contract.dto.Vehicle randomVehicle()
        {
            return new Contract.dto.Vehicle()
            {
                VehicleId = GenerateRandomId(),
                VehiclePrice = (double)(GenerateRandomId(1000, 10000) / 10),
                VehicleSize = GenerateRandomId(1, 10),
                VehicleType = RandomWords(10)
            };
        }
        #endregion
    }
}
