using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            EconomyPassenger eco1 = new EconomyPassenger("AA1", "Minh", "Hoang", "99999999", 30.5);
            FirstClassPassenger first1 = new FirstClassPassenger("BB2", "Justin", "Bieber", "888888888", 50, "pizza");

            Flight flight1 = new Flight("VN1", "Vaasa", "Ha Noi", new DateTime(2020, 10, 10, 8, 30, 52));
            Flight flight2 = new Flight("HCM1", "Ho Chi Minh", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52));
            //Ticket T1
            eco1[0] = new Ticket("T1", "AA1", 850.50, flight1);
            //Ticket T2
            first1[0] = new Ticket("T2", "BB2", 750.50, flight2);
            
            

            Console.WriteLine("5.1: Flight Information");
            Console.WriteLine(flight1.FindFlight("VN1"));
            Console.WriteLine("\n5.2: Flight Information");
            Console.WriteLine(eco1[0].GetPrice("T1"));
            Console.WriteLine("\n5.3: Get Info");
            Console.WriteLine(eco1.GetInfo("AA1"));
            Console.WriteLine("\n5.4: Get Info for Economy Passenger");
            Console.WriteLine(eco1.GetInfo("AA1"));
            Console.WriteLine("\n5.4: Get Info for First Class Passenger");
            Console.WriteLine(first1.GetInfo("BB2"));
            Console.ReadLine();
        }
    }
}
