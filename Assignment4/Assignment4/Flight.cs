using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Flight
    {
        private string id, origin, destination;
        private DateTime date;
        private double price;

        public string Id
        {
            get
            {
                return id;
            }
        }
        public string Origin
        {
            get
            {
                return origin;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public Flight(string id, string origin, string destination, DateTime date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }

        public override string ToString()
        {
            return "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date
                + "\nPrice: " + this.price + " euro\n\n";
        }

        public string FindFlight(string searchId)
        {
            string res = "";
            if (id.Equals(searchId))
            {
                res = "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date
                + "\nPrice: " + this.price + " euro\n";
            }
            return res;
        }
    }
}