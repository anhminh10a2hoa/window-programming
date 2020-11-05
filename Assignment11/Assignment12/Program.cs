using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment12;
namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchFlightId;
            string searchCustomerName;
            string option;
            string customerName;
            string flightId;
            int index = 7;
            const int max_length = 400;

            Service_handler Service_handler = new Service_handler();
            Customer[] customerArray = new Customer[max_length];
            customerArray[0] = new Customer("Anh Minh", 0, "VN1");
            customerArray[1] = new Customer("Chieu Trang", 1, "VN1");
            customerArray[2] = new Customer("Tien Doan", 2, "HCM1");
            customerArray[3] = new Customer("Ha Toan", 3, "HCM1");
            customerArray[4] = new Customer("Minh Hoang", 4, "VN1");
            customerArray[5] = new Customer("Thanh Binh", 5, "VA2");
            customerArray[6] = new Customer("Giao Phung", 6, "VA3");

            Flight[] flightArray = new Flight[4];
            flightArray[0] = new Flight("VN1", "Vaasa", "Ha Noi", new DateTime(2020, 10, 10, 8, 30, 52));
            flightArray[1] = new Flight("HCM1", "Ho Chi Minh", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52));
            flightArray[2] = new Flight("VA2", "Bien Hoa", "Vaasa", new DateTime(2020, 8, 8, 8, 30, 52));
            flightArray[3] = new Flight("VA3", "Binh Duong", "Vaasa", new DateTime(2020, 7, 7, 8, 30, 52));


            while (true)
            {
                try
                {
                    Console.WriteLine("\n----------------List of options-----------------");
                    Console.WriteLine("1: Create the customer");
                    Console.WriteLine("2: Search the customer name");
                    Console.WriteLine("3: Search the flight id");
                    Console.WriteLine("4: Get all flight information");
                    Console.WriteLine("exit: Exit the programming");
                    Console.WriteLine("----------------End of options-----------------\n");

                    Console.Write("Please choose your option: ");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.Write("Please type customer name: ");
                            customerName = Console.ReadLine();
                            Console.Write("Please type customer flight Id: ");
                            flightId = Console.ReadLine();
                            Service_handler.CreateCustomer(customerName, flightId, index, customerArray, flightArray);
                            index++;
                            break;

                        case "2":
                            Console.Write("Please type customer name: ");
                            searchCustomerName = Console.ReadLine();
                            Console.WriteLine(Service_handler.FindCustomer(searchCustomerName, index, customerArray));
                            break;

                        case "3":
                            Console.Write("Please type flight id: ");
                            searchFlightId = Console.ReadLine();
                            Console.WriteLine(Service_handler.FindFlight(searchFlightId, index, customerArray, flightArray));
                            break;

                        case "4":
                            Console.WriteLine(Service_handler.FindAllFlight(flightArray));
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
