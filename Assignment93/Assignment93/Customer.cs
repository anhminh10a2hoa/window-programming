using System.Collections.Generic;
using System.IO;
// JSON
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment93
{
    [DataContract]
    class Customer
    {
        private string id, name, flightId, phoneNumber;
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
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [DataMember]
        public string FlightId
        {
            get
            {
                return flightId;
            }
            set
            {
                flightId = value;
            }
        }
        [DataMember]
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public Customer(string id, string name, string flightId, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.flightId = flightId;
            this.phoneNumber = phoneNumber;
        }
        public Customer()
        {

        }
        public override string ToString()
        {
            string res = "";
            res += "Id: " + this.id
                    + "\nName: " + this.name
                    + "\nFlight id: " + this.flightId
                    + "\nPhone: " + this.phoneNumber + "\n";
            return res;
        }
        public static void WriteJson(string filePath, List<Customer> flightCollection)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, flightCollection);
            fileWriter.Close();
        }

        public static List<Customer> ReadJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string jsonData = reader.ReadToEnd();
                List<Customer> items = JsonConvert.DeserializeObject<List<Customer>>(jsonData);
                reader.Close();
                if (items == null)
                {
                    return new List<Customer>();
                }
                return items;
            }
            return new List<Customer>();
        }
    }
}