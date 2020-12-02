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

        public Ticket(string ticketID, string passengerID, double price, double extraTax, Flight flightObject)
        {
            this.ticketID = ticketID;
            this.passengerID = passengerID;
            this.price = price;
            this.extraTax = (int)this.flightObject.Date.DayOfWeek == 7 || ((int)this.flightObject.Date.DayOfWeek == 8) ? 7 : 5;
            this.flightObject = flightObject;
        }

        public double getFinalPrice(string ticketID)
        {
            return this.price * (100 + extraTax) / 100;
        }    
    }
}
