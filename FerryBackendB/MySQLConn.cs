using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryBackendB
{
    static class MySQLConn
    {
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

        public static MySql.Data.MySqlClient.MySqlConnection Connection()
        {
            return new MySql.Data.MySqlClient.MySqlConnection(
                string.Format("Server = {0}; Database = {1}; Uid = {2}; Pwd = {3};",
                "hostname",
                "database",
                "username",
                "password"
                ));
        }
    }
}
