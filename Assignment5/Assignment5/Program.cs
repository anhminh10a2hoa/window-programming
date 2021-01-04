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
            // Flight
            Flight flight1 = new Flight("VN1", "Vaasa", "Ha Noi", new DateTime(2020, 10, 10, 8, 30, 52));
            Flight flight11 = new Flight("VA1", "Vaasa", "Helsinki", new DateTime(2020, 10, 10, 8, 30, 52));
            Flight flight2 = new Flight("HCM1", "Ho Chi Minh", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52));
            Flight flight22 = new Flight("VA2", "Vaasa", "Paris", new DateTime(2020, 9, 9, 8, 30, 52));
            Flight flight3 = new Flight("Paris", "London", "Vaasa", new DateTime(2020, 9, 9, 8, 30, 52));
            Flight flight33 = new Flight("London", "Hanoi", "Paris", new DateTime(2020, 9, 9, 8, 30, 52));

            // Ticket
            Ticket ticket11 = new Ticket("T11", "AA1", 850.50, flight1);
            List<Ticket> ticket1 = new List<Ticket>();
            ticket1.Add(ticket11);
            ticket1.Add(new Ticket("T12", "AA1", 650.50, flight11));

            List<Ticket> ticket2 = new List<Ticket>();
            ticket2.Add(new Ticket("T21", "BB2", 750.50, flight2));
            ticket2.Add(new Ticket("T22", "BB2", 650.50, flight22));

            List<Ticket> ticket3 = new List<Ticket>();
            ticket3.Add(new Ticket("T21", "CC2", 750.50, flight3));
            ticket3.Add(new Ticket("T22", "CC2", 650.50, flight33));

            // Passenger
            EconomyPassenger eco1 = new EconomyPassenger("AA1", "Minh", "Hoang", "99999999", ticket1, 30.5);
            FirstClassPassenger first1 = new FirstClassPassenger("BB2", "Justin", "Bieber", "888888888", ticket2, 50, "pizza");
            Passenger pass1 = new Passenger("CC2", "Alan", "Walker", "777777777", ticket3);

            // lIST OF PASSENGERS
            List<Passenger> passengers = new List<Passenger>();
            passengers.Add(eco1);
            passengers.Add(first1);
            passengers.Add(pass1);

            Console.WriteLine("5.1: Flight Information");
            Console.WriteLine(flight1.FindFlight("VN1"));
            Console.WriteLine("\n5.2: Get the information of the flight and passenger");
            Console.WriteLine(ticket11.getInformationOfFlightAndPassenger(passengers));
            Console.WriteLine("\n5.3: Get Info");
            Console.WriteLine(pass1.GetInfo("CC2"));
            Console.WriteLine("\n5.4: Get Info for Economy Passenger");
            Console.WriteLine(eco1.GetInfo("AA1"));
            Console.WriteLine("\n5.5: Get Info for First Class Passenger");
            Console.WriteLine(first1.GetInfo("BB2"));
            Console.WriteLine("\nFind ticket by Id");
            Console.WriteLine(ticket11.FindTicket(ticket3, "T11"));
            Console.ReadLine();
        }
    }
}
