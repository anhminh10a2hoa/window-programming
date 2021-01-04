using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FirstClassPassenger : EconomyPassenger
    {
        private readonly double bonus = 0;
        private string mealMenu;

        public string MealMenu
        {
            get
            {
                return mealMenu;
            }
        }

        public double Bonus
        {
            get
            {
                return bonus;
            }
        }
        public FirstClassPassenger(string id, string firstName, string lastName, string phoneNumber, List<Ticket> tickets, double luggageWeight, string mealMenu) : base(id, firstName, lastName, phoneNumber, tickets, luggageWeight)
        {
            this.mealMenu = mealMenu;
            foreach(Ticket ticket in tickets)
            {
                bonus += ticket.Price * 0.02;
            }
        }
        public override string GetInfo(string searchId)
        {
            string res = "";
            if (base.ID.Equals(searchId))
            {
                res = base.GetInfo(searchId) + "\nBonus: " + this.bonus + "\nMeal: " + this.mealMenu;
            }
            return res;
        }
    }
}
