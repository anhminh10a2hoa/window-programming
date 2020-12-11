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
        List<Ticket> collectionTicket;
        public Passenger(string id, string firstName, string lastName, string phoneNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.collectionTicket = new List<Ticket>();
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public Ticket this[int index]
        {
            set
            {
                this.collectionTicket.Insert(index, value);
            }
            get
            {
                return this.collectionTicket[index];
            }
        }

        public override string ToString()
        {
            return "Id: " + this.id
                    + "\nName: " + this.firstName + this.lastName
                    + "\nPhone: " + this.phoneNumber;
        }

        public virtual string GetInfo(string searchId)
        {
            string res = "";
            if (id.Equals(searchId))
            {
                for (int i = 0; i < this.collectionTicket.Count(); i++)
                {
                    if (searchId.Equals(this.collectionTicket[i].PassengerID))
                    {
                        res = this.ToString() + "\n" + this.collectionTicket[i].ToString();
                    }
                }
            }
            return res;
        }

        public double GetPrice(string searchId)
        {
            if (id.Equals(searchId))
            {
                for (int i = 0; i < this.collectionTicket.Count(); i++)
                {
                    if (searchId.Equals(this.collectionTicket[i].PassengerID))
                    {
                        return this.collectionTicket[i].GetPrice(this.collectionTicket[i].TicketID);
                    }
                }
            }
            return 0;
        }
    }
}
