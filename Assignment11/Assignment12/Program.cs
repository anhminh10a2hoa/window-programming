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
            int count;
            int index = 7;

            Customer[] customerArray = new Customer[index];
            customerArray[0] = new Customer("Anh Minh", 1, "VN1");
            customerArray[1] = new Customer("Chieu Trang", 2, "VN1");
            customerArray[2] = new Customer("Tien Doan", 3, "HCM1");
            customerArray[3] = new Customer("Ha Toan", 4, "HCM1");
            customerArray[4] = new Customer("Minh Hoang", 5, "VN1");
            customerArray[5] = new Customer("Thanh Binh", 6, "VA2");
            customerArray[6] = new Customer("Giao Phung", 7, "VA3");

            Flight[] flightArray = new Flight[4];
            flightArray[0] = new Flight("VN1", "Vaasa", "Ha Noi", new DateTime(2020, 10, 10, 8, 30, 52));
            flightArray[1] = new Flight("HCM1", "Ho Chi Minh", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52));
            flightArray[2] = new Flight("VA2", "Bien Hoa", "Vaasa", new DateTime(2020, 8, 8, 8, 30, 52));
            flightArray[3] = new Flight("VA3", "Binh Duong", "Vaasa", new DateTime(2020, 7, 7, 8, 30, 52));


            while (true)
            {
                try
                {
                    Console.WriteLine("----------------List of options-----------------");
                    Console.WriteLine("1: Create the customer");
                    Console.WriteLine("2: Search the customer name");
                    Console.WriteLine("3: Search the flight id");
                    Console.WriteLine("4: Get all flight information");


                    Console.WriteLine("Please choose your option: ");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.Write("Please type customer name: ");
                            customerName = Console.ReadLine();
                            Console.Write("Please type customer flight Id: ");
                            flightId = Console.ReadLine();
                            for (int i = 0; i < flightArray.Length; i++)
                            {
                                if (flightArray[i].GetId() == flightId)
                                {
                                    index++;
                                    customerArray = new Customer[index];
                                    break;
                                } else
                                {
                                    Console.WriteLine("Can not find this flight Id, TRY AGAIN");
                                    break;
                                }
                            }
                            break;

                        case "2":
                            Console.Write("Please type customer name: ");
                            searchCustomerName = Console.ReadLine();
                            count = 0;
                            for (int i =0; i < customerArray.Length; i++)
                            {
                                if (customerArray[i].GetName(searchCustomerName))
                                {
                                    Console.WriteLine(customerArray[i].ToString());
                                    count++;
                                }
                            }
                            if(count == 0)
                            {
                                Console.WriteLine("Can not find the customer name ", searchCustomerName);
                            }
                            break;

                        case "3":
                            Console.Write("Please type flight id: ");
                            searchFlightId = Console.ReadLine();
                            count = 0;
                            for (int i = 0; i < flightArray.Length; i++)
                            {
                                if (flightArray[i].GetId() == searchFlightId)
                                {
                                    Console.WriteLine(flightArray[i].ToString());
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                Console.WriteLine("Can not find the flight ID ", searchFlightId);
                            }
                            Console.WriteLine("The customer in this flight id: ", searchFlightId);
                            for (int i = 0; i < customerArray.Length; i++)
                            {
                                if (customerArray[i].GetFlightId() == searchFlightId)
                                {
                                    Console.WriteLine(customerArray[i].ToString());
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                Console.WriteLine("No customer in this flight id ", searchFlightId);
                            }
                            break;

                        case "4":
                            for (int i = 0; i < flightArray.Length; i++)
                            {
                                Console.WriteLine(flightArray[i].ToString());
                            }
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
