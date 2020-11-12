using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
    }
}
