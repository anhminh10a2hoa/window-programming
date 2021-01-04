using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Ticket
    {
        private string ticketID, passengerID;
        Flight flightObject;
        private double price;
        private readonly double extraTax;

        public string TicketID
        {
            get
            {
                return ticketID;
            }
        }
        public string PassengerID
        {
            get
            {
                return passengerID;
            }
        }

        public Flight FlightObject
        {
            get
            {
                return flightObject;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public Ticket(string ticketID, string passengerID, double price, Flight flightObject)
        {
            this.ticketID = ticketID;
            this.passengerID = passengerID;
            this.price = price;
            this.flightObject = flightObject;
            extraTax = (flightObject.Date.Equals(DayOfWeek.Saturday) || flightObject.Date.Equals(DayOfWeek.Sunday)) ? 7 : 5;
        }

        public double GetPrice(string searchTicketID)
        {
            if (ticketID.Equals(searchTicketID))
            {
                return this.price * (100 + extraTax) / 100; ;
            }  
            return 0;
        }

        public string getInformationOfFlightAndPassenger(List<Passenger> passengers)
        {
            string res = "";
            res += "+ Flight Information\n" + flightObject.ToString();
            foreach(Passenger p in passengers)
            {
                if (this.passengerID.Equals(p.ID))
                {
                    res += "\n+ Passenger Information: \n" + p.GetInfo(passengerID);
                }
            }
            return res;
        }

        public override string ToString()
        {
            return "\nTicket Id: " + this.ticketID
                + "\nPrice: " + this.GetPrice(this.ticketID)
                + "\nTax: " + this.extraTax
                + "\n Flight Information: " + flightObject.ToString();
        }

        public string FindTicket(List<Ticket> tickets, string ticketId)
        {
            string res = "";
            foreach (Ticket ticket in tickets)
            {
                if (ticketID.Equals(ticketId))
                {
                    res += "\nTicket Id: " + this.ticketID
                    + "\nPrice: " + this.GetPrice(this.ticketID)
                    + "\nTax: " + this.extraTax
                    + "\n Flight Information: " + flightObject.ToString();
                }
            }
            return res;
        }

    }
}
