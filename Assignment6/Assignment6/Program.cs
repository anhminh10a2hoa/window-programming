using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> room = new List<Room>();
            room.Add(new Room("1", 20, "Single bed", 50, "Good for 1 person"));
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer("Minh Hoang", "Vaasa, Finland", "04/01/2021", "1", 4));
            Hotel hotel = new Hotel("Minh Tower", "25/06/2020", "Ha Noi", 5, room, customer);

            hotel.WriteToFile("./hotel.txt");
            Console.WriteLine(hotel.ReadFromFile("./hotel.txt"));
            Console.ReadLine();
        }
    }
}
