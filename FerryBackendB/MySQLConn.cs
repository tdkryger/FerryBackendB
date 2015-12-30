using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryBackendB
{
    static class MySQLConn
    {
        public static MySql.Data.MySqlClient.MySqlConnection Connection()
        {
            return new MySql.Data.MySqlClient.MySqlConnection( 
                string.Format("Server = {0}; Database = {1}; Uid = {2}; Pwd = {3};",
                "hostname",
                "database",
                "username",
                "password"
                ) );
        }
    }
}
