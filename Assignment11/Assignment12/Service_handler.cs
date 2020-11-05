using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Service_handler
    {

        public static string CreateCustomer(string name, string flightId, int index, Customer[] customerArray, Flight[] flightArray)
        {
            for (int i = 0; i < flightArray.Length; i++)
            {
                if (flightArray[i].GetId() == flightId)
                {
                    customerArray[index] = new Customer(name, index, flightId);
                }
                else
                {
                   return("Can not find this flight Id, TRY AGAIN");
                }
            }
            return customerArray[index].ToString();
        }
        public static string FindCustomer(string name, int index, Customer[] customerArray)
        {
            int count = 0;
            string res = "";
            for (int i = 0; i < index; i++)
            {
                if (customerArray[i].GetName(name))
                {
                    res += customerArray[i].ToString();
                    count++;
                }
            }
            if (count == 0)
            {
                return ("Can not find the customer name " + name);
            }
            return res;
        }

        public static string FindFlight(string searchFlightId, int index, Customer[] customerArray, Flight[] flightArray)
        {
            int count = 0;
            int count1 = 0;
            string res = "";
            for (int i = 0; i < flightArray.Length; i++)
            {
                if (flightArray[i].GetId() == searchFlightId)
                {
                    res += flightArray[i].ToString();
                    count++;
                }
            }
            if (count == 0)
            {
                return("Can not find the flight ID " + searchFlightId);
            }
            res += "The customer in this flight id: " + searchFlightId + "\n";
            for (int i = 0; i < index; i++)
            {
                if (customerArray[i].GetFlightId() == searchFlightId)
                {
                    res += customerArray[i].ToString();
                    count1++;
                }
            }
            if (count1 == 0)
            {
                return("No customer in this flight id " + searchFlightId);
            }
            return res;
        }

        public static string FindAllFlight(Flight[] flightArray)
        {
            string res = "";
            for (int i = 0; i < flightArray.Length; i++)
            {
                res += flightArray[i].ToString();
            }
            
            return res;
        }
    }
}
