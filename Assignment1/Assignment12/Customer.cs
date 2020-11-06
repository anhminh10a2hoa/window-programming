using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Customer
    {
        //These are data members
        string name;
        int id;
        string flightId;
        //This is the constructor
        public Customer(string name, int id, string flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }
        //This is an ordinary function
        public bool GetName(string name)
        {
            return name.Equals(this.name);
        }
        //This is an ordinary function
        public bool GetId(int id)
        {
            return (id == this.id);
        }
        //This is an ordinary function
        public string GetFlightId()
        {
            return this.flightId;
        }

        public string GetFlightIdValue()
        {
            return this.flightId;
        }
        public override string ToString()
        {
            return "Id: " + id + ", Name: " + name + ", Flight id: " + flightId + "\n";
        }
    }
}
