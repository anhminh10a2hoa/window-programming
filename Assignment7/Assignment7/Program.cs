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

            // Read and Write Serialize
            Console.WriteLine("\nRead and Write with Serialize\n");
            hotel.WriteBinarySerialize(@"d:\temp\ass7serialize.dat");
            var hotelAfterReadFromSerializeFile = Hotel.ReadBinarySerialize(@"d:\temp\ass7serialize.dat");
            Console.WriteLine(hotelAfterReadFromSerializeFile);

            // Read and Write with XML format
            Console.WriteLine("\nRead and Write with XML format\n");
            hotel.WriteXML(@"d:\temp\ass7xml.xml");
            var hotelAfterReadFromXMLFile = hotel.ReadXML(@"d:\temp\ass7xml.xml");
            Console.WriteLine(hotelAfterReadFromXMLFile);

            // Read and Write with JSON format
            Console.WriteLine("\nRead and Write with JSON format\n");
            hotel.WriteJson(@"d:\temp\ass7json.json");
            var hotelAfterReadFromJSONFile = hotel.ReadJson(@"d:\temp\ass7json.json");
            Console.WriteLine(hotelAfterReadFromJSONFile);

            // ReadBinary and WriteBinary
            Console.WriteLine("\nRead and Write with Binary format\n");
            hotel.WriteToFile(@"d:\temp\ass7binary.txt");
            var hotelAfterRead = new Hotel();
            hotelAfterRead.ReadFromFile(@"d:\temp\ass7binary.txt");
            Console.WriteLine(hotelAfterRead.ToString());

            // ReadText and WriteText
            Console.WriteLine("\nRead and Write with Text format\n");
            hotel.WriteTextToFile(@"d:\temp\ass7text.txt");
            var hotelAfterReadFromText = new Hotel();
            hotelAfterReadFromText.ReadTextFromFile(@"d:\temp\ass7binary.txt");
            Console.WriteLine(hotelAfterReadFromText);

            Console.ReadLine();
        }
    }
}