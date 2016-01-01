using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class FerryHandler
    {
        public static Contract.dto.Ferry random()
        {
            return new Contract.dto.Ferry()
            {
                Dock = DockHandler.random(),
                FerryId = MySQLConn.GenerateRandomId(),
                FerryName = MySQLConn.RandomWords(10),
                FerrySize = MySQLConn.RandomWords(10),
                Municipality = MySQLConn.RandomWords(10),
                PassengerCapacity = MySQLConn.GenerateRandomId(10, 500),
                VehicleCapacity = MySQLConn.GenerateRandomId(10, 500),
            };

        }

        public static Contract.dto.Ferry CreateFerry(Contract.dto.Ferry ferry)
        {
            ferry.FerryId = MySQLConn.GenerateRandomId();
            return ferry;
        }

        public static Contract.dto.Ferry GetFerry(int ferryId)
        {
            Contract.dto.Ferry f = random();
            f.FerryId = ferryId;
            return f;
        }

        public static List<Contract.dto.Ferry> GetAllFerries()
        {
            List<Contract.dto.Ferry> l = new List<Contract.dto.Ferry>();

            int max = MySQLConn.GenerateRandomId(2, 10000);
            for(int i=1; i<max;i++)
            {
                Contract.dto.Ferry f = random();
                f.FerryId = i;
                l.Add(f);
            }

            return l;

        }

        public static Contract.dto.Ferry UpdateFerry(Contract.dto.Ferry ferry)
        {
            return ferry;
        }

        public static bool DeleteFerry(Contract.dto.Ferry ferry)
        {
            return true;
        }
    }
}
