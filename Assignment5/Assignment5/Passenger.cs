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

        public string GetInfo(string searchId)
        {
            string res = "";
            if (id.Equals(searchId))
            {
                for (int i = 0; i < this.collectionTicket.Count(); i++)
                {
                    if (searchId.Equals(this.collectionTicket[i].PassengerID))
                    {
                        res = "Id: " + this.id
                        + "\nName: " + this.firstName + this.lastName
                        + "\nPhone: " + this.phoneNumber
                        + "\nTicket information: "
                        + "\nTicket Id: " + this.collectionTicket[i].TicketID
                        + "\nPrice: " + this.collectionTicket[i].getFinalPrice(this.collectionTicket[i].TicketID)
                        + "\n" + this.collectionTicket[i].FlightObject.FindFlight(this.collectionTicket[i].FlightObject.Id)
                    }
                }
            }
            return res;
        }
    }
}
