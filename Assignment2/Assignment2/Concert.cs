using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Concert
    {
        // title, location, date, time and price. 
        private string title;
        private string location;
        private DateTime date;
        private double price;

        public Concert(string title, string location, DateTime date, double price)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.price = price;
        }

        public string toString()
        {
            return "Title: " + this.title + "\nLocation: " + this.location + "\nDate: " + this.date + "\nPrice: " + this.price + " euro\n";
        }

        public static Concert operator ++(Concert c1)
        {
            c1.price += 5;
            return new Concert(c1.title, c1.location, c1.date, c1.price);
        }

        public static Concert operator --(Concert c1)
        {
            c1.price -= 5;
            return new Concert(c1.title, c1.location, c1.date, c1.price);
        }

        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.price < c2.price)
                return true;
            return false;
        }

        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.price > c2.price)
                return true;
            return false;
        }
    }
}
