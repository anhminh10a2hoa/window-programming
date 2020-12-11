using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Flight
    {
        private string id, origin, destination;
        private DateTime date;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public Flight(string id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public override string ToString()
        {
            return "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date;
        }

        public string FindFlight(string searchId)
        {
            if (id.Equals(searchId))
            {
                return this.ToString();
            }
            return "";
        }
    }
}
