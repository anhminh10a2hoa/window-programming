using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Flight
    {
        //These are data members
        string id;
        string origin;
        string destination;
        DateTime date;
        //This is the constructor
        public Flight(string id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }
        //This is an ordinary function
        public string GetId()
        {
            return this.id;
        }
        //This is an ordinary function
        public bool GetOrigin(int origin)
        {
            return origin.Equals(this.origin);
        }
        //This is an ordinary function
        public bool GetDestination(int destination)
        {
            return destination.Equals(this.destination);
        }
        public bool GetDate(DateTime date)
        {
            return date.Equals(this.date);
        }
        public override string ToString()
        {
            return "Id: " + id + ", From: " + origin + ", To: " + destination + ", Date: " + date;
        }
    }
}
