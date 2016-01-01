using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class DockHandler
    {
        public static Contract.dto.Dock random()
        {
            return new Contract.dto.Dock()
            {
                DockId = MySQLConn.GenerateRandomId(),
                DockName = MySQLConn.RandomWords(25),
                FerryCapacity = MySQLConn.GenerateRandomId(1, 10)
            };
        }

        public static Contract.dto.Dock CreateDock(Contract.dto.Dock dock)
        {
            dock.DockId = MySQLConn.GenerateRandomId();
            return dock;
        }

        public static List<Contract.dto.Dock> GetAllDocks() // silly ppl
        {
            List<Contract.dto.Dock> l = new List<Contract.dto.Dock>();
            int max = MySQLConn.GenerateRandomId(2, 10000);
            for (int i = 1; i < max; i++)
            {
                Contract.dto.Dock d = random();
                d.DockId = i;
                l.Add(d);
            }
            return l;
        }

        public static Contract.dto.Dock GetDock(int dockId)
        {
            Contract.dto.Dock d = random();
            d.DockId = dockId;
            return d;
        }

        public static Contract.dto.Dock UpdateDock(Contract.dto.Dock dock)
        {
            return dock;
        }


        public static bool DeleteDock(Contract.dto.Dock dock)
        {
            return true;
        }
    }
}
