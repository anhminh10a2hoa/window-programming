using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class EconomyPassenger : Passenger
    {
        private double luggageWeight;
        public EconomyPassenger(string id, string firstName, string lastName, string phoneNumber, List<Ticket> tickets, double luggageWeight) : base(id, firstName, lastName, phoneNumber, tickets)
        {
            this.luggageWeight = luggageWeight;
        }

        public override string GetInfo(string searchId)
        {
            string res = "";
            if (base.ID.Equals(searchId))
            {
                res = base.GetInfo(searchId) + "\nLaggage weight: " + luggageWeight;
            }
            return res;
        }
    }
}
