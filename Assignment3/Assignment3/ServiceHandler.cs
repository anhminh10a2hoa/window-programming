using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ServiceHandler
    {
        public static string FindAllFlights(AirlineCompany FlightCollection)
        {
            string res = "";
            res += "Here is all of the information flight: \n";
            for (int i = 0; i < FlightCollection.Count(); i++)
            {
                res += FlightCollection[i].GetFlight();
            }
            return res;
        }

        public static string SearchFlight(string flightId, AirlineCompany FlightCollection)
        {
            string res = "";
            for (int i = 0; i < FlightCollection.Count(); i++)
            {
                res += FlightCollection[i].FindFlight(flightId);
            }
            return res;
        }
    }
}
