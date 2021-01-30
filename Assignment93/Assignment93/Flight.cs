using System.Collections.Generic;
using System.IO;
// JSON
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment93
{
    [DataContract]
    class Flight
    {
        private string id, origin, destination;
        private string date;
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

        public Flight(string id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public Flight()
        {

        }

        public override string ToString()
        {
            string res = "";
            res += "Id: " + this.id
                + "\nOrigin: " + this.origin
                + "\nDestination: " + this.destination
                + "\nDate: " + this.date;
            return res;
        }

        public static void WriteJson(string filePath, List<Flight> flightCollection)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Flight>), serializingSettings);
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, flightCollection);
            fileWriter.Close();
        }

        public static List<Flight> ReadJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string jsonData = reader.ReadToEnd();
                List<Flight> items = JsonConvert.DeserializeObject<List<Flight>>(jsonData);
                reader.Close();
                if (items == null)
                {
                    return new List<Flight>();
                }
                return items;
            }
            return new List<Flight>();
        }
    }
}