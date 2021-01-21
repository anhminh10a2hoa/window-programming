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

        public void WriteJson(string filePath)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Flight), serializingSettings);
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, this);
            fileWriter.Close();
        }
        // Read JSON
        public Flight ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            Flight items = JsonConvert.DeserializeObject<Flight>(jsonData);
            reader.Close();
            return items;
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

        public string FindFlight(string searchId)
        {
            if (id.Equals(searchId))
            {
                return this.ToString();
            }
            return "";
        }
    }
}