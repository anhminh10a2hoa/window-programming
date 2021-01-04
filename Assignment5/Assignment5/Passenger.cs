using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Passenger
    {
        private string id, firstName, lastName, phoneNumber;
        private List<Ticket> tickets;
        public Passenger(string id, string firstName, string lastName, string phoneNumber, List<Ticket> tickets)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.tickets = tickets;
        }

        public string ID
        {
            get { return id; }
        }
        public override string ToString()
        {
            string res = "";
            res += "Id: " + this.id
                    + "\nName: " + this.firstName + this.lastName
                    + "\nPhone: " + this.phoneNumber + "\n";
            return res;
        }

        public virtual string GetInfo(string searchId)
        {
            string res = "";
            if (id.Equals(searchId))
            {
                res += this.ToString();
                res += "List of tickets: \n";
                foreach (Ticket ticket in tickets)
                {
                    res += ticket.ToString() + "\n";
                }
            }
            return res;
        }
    }
}
