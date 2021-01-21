using System.Collections.Generic;
using System.IO;
// JSON
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment9
{
    [DataContract]
    class Flight
    {
        private string id, origin, destination;
        private string date;
        private List<Customer> customerList;
        [DataMember]
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        [DataMember]
        public string Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }
        [DataMember]
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        [DataMember]
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        [DataMember]
        public List<Customer> CustomerList
        {
            get
            {
                return this.customerList;
            }
            set
            {
                this.customerList = value;
            }
        }

        public Flight(string id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.customerList = new List<Customer>();
        }

        public Flight()
        {
            this.customerList = new List<Customer>();
        }

        public override string ToString()
        {
            string res = "";
            res += "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date;
            res += "\nList of customers \n";
            foreach (var customer in customerList)
            {
                res += customer.ToString();
            }
            return res;
        }

        public string InformationOfFlight()
        {
            string res = "";
            res += "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date;
            return res;
        }
    }
}