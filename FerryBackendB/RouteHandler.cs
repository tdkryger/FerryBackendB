using System;
using System.Collections.Generic;

namespace FerryBackendB
{
    static class RouteHandler
    {
        public static Contract.dto.Route random()
        {
            return new Contract.dto.Route()
            {
                Depature = MySQLConn.RandomWords(30),
                Destination = MySQLConn.RandomWords(30),
                Duration = MySQLConn.GenerateRandomId(10, 1000),
                RouteId = MySQLConn.GenerateRandomId()
            };
        }

        public static Contract.dto.Route CreateRoute(Contract.dto.Route route)
        {
            route.RouteId = MySQLConn.GenerateRandomId();
            return route;
        }

        public static Contract.dto.Route GetRoute(int routeId)
        {
            Contract.dto.Route r = random();
            r.RouteId = routeId;
            return r;
        }

        public static List<Contract.dto.Route> GetAllRoutes() // Stupids
        {
            List<Contract.dto.Route> l = new List<Contract.dto.Route>();
            int max = MySQLConn.GenerateRandomId(10, 10000);
            for(int i=1; i<=max;i++)
            {
                Contract.dto.Route r = random();
                r.RouteId = i;
                l.Add(r);
            }
            return l;
        }

        public static Contract.dto.Route UpdateRoute(Contract.dto.Route route)
        {
            return route;
        }

        public static bool DeleteRoute(Contract.dto.Route route)
        {
            return true;
        }
    }
}
