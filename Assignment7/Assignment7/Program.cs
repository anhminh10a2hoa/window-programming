using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> room = new List<Room>();
            room.Add(new Room("1", 20, "Single bed", 50, "Good for 1 person"));
            room.Add(new Room("2", 40, "Double bed", 100, "Good for a couple"));
            room.Add(new Room("3", 60, "Double bed with bancony", 150, "Good for all"));
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer("Minh Hoang", "Vaasa, Finland", "04/01/2021", "1", 4));
            customer.Add(new Customer("Toan", "Vaasa, Finland", "05/01/2021", "2", 4));
            customer.Add(new Customer("Tien Doan", "Vaasa, Finland", "05/01/2021", "2", 4));
            Hotel hotel = new Hotel("Minh Tower", "25/06/2020", "Ha Noi", 5, room, customer);

            // Read and Write Binary
            hotel.WriteToFile(@"d:\temp\assignment7.txt");
            var hotelAfterRead = new Hotel();
            hotelAfterRead.ReadFromFile(@"d:\temp\assignment7.txt");
            Console.WriteLine(hotelAfterRead.ToString());

            // Read and Write with XML format
            Console.WriteLine("\nRead and Write with XML format\n");
            Hotel.WriteXML(hotel, @"d:\temp\ass7xml.txt");
            var hotelAfterReadFromXMLFile = Hotel.ReadXML<Hotel>(@"d:\temp\ass7xml.txt");
            Console.WriteLine(hotelAfterReadFromXMLFile);
            Console.ReadLine();
        }
    }
}