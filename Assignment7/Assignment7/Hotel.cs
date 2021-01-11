using System;
using System.Collections.Generic;
using System.IO;
//Serialize
using System.Runtime.Serialization.Formatters.Binary;
//XML
using System.Xml;
using System.Xml.Serialization;
// Json
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment7
{
    [Serializable, XmlRoot("hotel"), DataContract]
    public class Hotel : IHotel
    {
        private string name, address, constructionDate;
        private int stars;
        private List<Room> roomList;
        private List<Customer> customerList;
        [XmlElement("name"), DataMember]
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        [XmlElement("constructionDate"), DataMember]
        public string ConstructionDate
        {
            get
            {
                return this.constructionDate;
            }
            set
            {
                this.constructionDate = value;
            }
        }
        [XmlElement("address"), DataMember]
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        [XmlElement("stars"), DataMember]
        public int Stars
        {
            get
            {
                return this.stars;
            }
            set
            {
                this.stars = value;
            }
        }
        [XmlArray("customerList"), XmlArrayItem("customer"), DataMember]
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
        [XmlArray("roomList"), XmlArrayItem("room"), DataMember]
        public List<Room> RoomList
        {
            get
            {
                return this.roomList;
            }
            set
            {
                this.roomList = value;
            }
        }

        public Hotel(string name, string constructionDate, string address, int stars, List<Room> roomList, List<Customer> customerList)
        {
            this.name = name;
            this.constructionDate = constructionDate;
            this.address = address;
            this.stars = stars;
            this.roomList = roomList;
            this.customerList = customerList;
        }
        public Hotel()
        {
            this.roomList = new List<Room>();
            this.customerList = new List<Customer>();
        }

        public override string ToString()
        {
            string res = "";
            res += "Hotel Name: " + this.name + "\n";
            res += "Construction date: " + this.constructionDate + "\n";
            res += "Address: " + this.address + "\n";
            res += "Stars: " + this.stars + "\n";
            res += "\nList of rooms \n";
            foreach (var room in roomList)
            {
                res += room.ToString();
            }
            res += "\nList of customers \n";
            foreach (var customer in customerList)
            {
                res += customer.ToString();
            }
            return res;
        }

        public void WriteBinarySerialize(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, this);
            fileStream.Flush();
            fileStream.Close();
        }

        public static Hotel ReadBinarySerialize(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = null;
            try
            {
                obj = binaryFormatter.Deserialize(fileStream);
                if(obj is Hotel)
                {
                    Hotel hotel = (Hotel)obj;
                    fileStream.Close();
                    return hotel;
                }
                return null;
            }
            catch(EndOfStreamException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        
        public void WriteXML(string filePathName)
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(filePathName, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true

            });
            serializer.Serialize(xmlWriter, this);
            xmlWriter.Close();
        }
        //This generic method reeads and returns the content of the XML file
        //in a generic form
        public Hotel ReadXML(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(Hotel));
                Hotel data = (Hotel)serializer.Deserialize(stream);
                return data;
            }
        }

        public void WriteJson(string filePath)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Hotel), serializingSettings);
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, this);
            fileWriter.Close();
        }

        public string ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            reader.Close();
            return jsonData;
        }
    }
}