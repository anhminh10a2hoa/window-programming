using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class AirlineCompany
    {
        private readonly string name;
        List<Flight> collectionFlight;

        public AirlineCompany(string name)
        {
            this.name = name;
            this.collectionFlight = new List<Flight>();
        }

        public string getName()
        {
            return this.name;
        }

        public int Count()
        {
            return this.collectionFlight.Count;
        }

        // Indexer
        public Flight this[int index]
        {
            set
            {
                this.collectionFlight.Insert(index, value);
            }
            get
            {
                return this.collectionFlight[index];
            }
        }

        public string FindAllFlight()
        {
            string res = "";
            for (int i = 0; i < this.collectionFlight.Count(); i++)
            {
                res += this.collectionFlight[i].ToString();
            }
            return res;
        }

        public string SearchFlight(string flightId)
        {
            string res = "";
            for (int i = 0; i < this.collectionFlight.Count(); i++)
            {
                res += this.collectionFlight[i].FindFlight(flightId);
            }
            return res;
        }

        public void GetFlightOriginAndDestination(Flight f)
        {
            Console.WriteLine("From: " + f.Origin + " to " + f.Destination + "\n");
        }

        // For delegate
        public void GetFlightByPrice(processFlightDelate processDelegate, double price)
        {
            foreach (Flight f in this.collectionFlight)
            {
                if (f.Price > price)
                    processDelegate.Invoke(f);
            }
        }

        // For action
        public void GetFlightByPriceAction(Action<Flight> actionFlight, double price)
        {
            foreach (Flight f in this.collectionFlight)
            {
                if (f.Price > price)
                    actionFlight.Invoke(f);
            }
        }

        public void GetFlightByPricePredicate(Predicate<Flight> predicateFlight)
        {
            int count = 0;
            foreach (Flight f in this.collectionFlight)
            {
                if (predicateFlight.Invoke(f))
                {
                    Console.WriteLine("From: " + f.Origin + " to " + f.Destination + "\n");
                    count++;
                }
                if(count == 1)
                {
                    break;
                }
            }
        }
    }
}