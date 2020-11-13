using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string searchFlightId;

            AirlineCompany FlightCollection = new AirlineCompany("Minh Hoang Airline");

            FlightCollection[0] = new Flight("VN1", "Vaasa", "Ha Noi", new DateTime(2020, 10, 10, 8, 30, 52), 850.50);
            FlightCollection[1] = new Flight("HCM1", "Ho Chi Minh", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52), 750.50);
            FlightCollection[2] = new Flight("VA2", "Helsinki", "Vaasa", new DateTime(2020, 8, 8, 8, 30, 52), 100.65);
            FlightCollection[3] = new Flight("PA3", "Vaasa", "Paris", new DateTime(2020, 7, 7, 8, 30, 52), 250.70);

            while (true)
            {
                try
                {
                    Console.WriteLine("\n----------------List of options-----------------");
                    Console.WriteLine("1: Get all flight information");
                    Console.WriteLine("2: Search the flight id");
                    Console.WriteLine("exit: Exit the programming");
                    Console.WriteLine("----------------End of options-----------------\n");

                    Console.Write("Please choose your option: ");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Here is all the flight information of the " + FlightCollection.getName() + ": \n");
                            Console.WriteLine(FlightCollection.FindAllFlight());
                            break;

                        case "2":
                            Console.Write("Please type flight id: ");
                            searchFlightId = Console.ReadLine();
                            Console.WriteLine(FlightCollection.SearchFlight(searchFlightId));
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default: break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
