using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FirstClassPassenger : EconomyPassenger
    {
        private readonly double bonus;
        private string mealMenu;
        public FirstClassPassenger(string id, string firstName, string lastName, string phoneNumber, double luggageWeight, string mealMenu) : base(id, firstName, lastName, phoneNumber, luggageWeight)
        {
            bonus = 2;
            this.mealMenu = mealMenu;
        }
        public override string GetInfo(string searchId)
        {
            string res = "";
            if (base.ID.Equals(searchId))
            {
                res = base.GetInfo(searchId) + "\nBonus: " + base.GetPrice(searchId) * bonus / 100 + "\nMeal: " + this.mealMenu;
            }
            return res;
        }
    }
}
