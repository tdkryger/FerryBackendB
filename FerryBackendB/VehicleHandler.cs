using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class VehicleHandler
    {
        public static Contract.dto.Vehicle random()
        {
            return new Contract.dto.Vehicle()
            {
                VehicleId = MySQLConn.GenerateRandomId(),
                VehiclePrice = (double)(MySQLConn.GenerateRandomId(1000, 10000) / 10),
                VehicleSize = MySQLConn.GenerateRandomId(1, 10),
                VehicleType = MySQLConn.RandomWords(10)
            };
        }

        public static Contract.dto.Vehicle CreateVehicle(Contract.dto.Vehicle vehicle)
        {
            vehicle.VehicleId = MySQLConn.GenerateRandomId();
            return vehicle;
        }

        public static Contract.dto.Vehicle GetVehicle(int vehicleId)
        {
            Contract.dto.Vehicle v = random();
            v.VehicleId = vehicleId;
            return v;
        }

        public static List<Contract.dto.Vehicle> GetAllVehicles() // Fools
        {
            List<Contract.dto.Vehicle> l = new List<Contract.dto.Vehicle>();
            int max = MySQLConn.GenerateRandomId(10000, 1000000);
            for (int i = 1; i <= max; i++)
            {
                Contract.dto.Vehicle r = random();
                r.VehicleId = i;
                l.Add(r);
            }
            return l;
        }

        public static Contract.dto.Vehicle UpdateVehicle(Contract.dto.Vehicle vehicle)
        {
            return vehicle;
        }

        public static bool DeleteVehicle(Contract.dto.Vehicle vehicle)
        {
            return true;
        }
    }
}
