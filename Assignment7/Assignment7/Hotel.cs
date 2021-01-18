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
using System.Text;

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
        // Write Serializ
        public void WriteBinarySerialize(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, this);
            fileStream.Flush();
            fileStream.Close();
        }
        // Read Serialize
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
        // Write XML
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
        // Read XML
        public Hotel ReadXML(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(Hotel));
                Hotel data = (Hotel)serializer.Deserialize(stream);
                return data;
            }
        }
        // Write JSON
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
        // Read JSON
        public Hotel ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            Hotel items = JsonConvert.DeserializeObject<Hotel>(jsonData);
            reader.Close();
            return items;
        }
        // Write by using WriteBinary
        public void WriteToFile(string filePath)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Create));
                binaryWriter.Write(name);
                binaryWriter.Write(constructionDate);
                binaryWriter.Write(address);
                binaryWriter.Write(stars);
                binaryWriter.Write(roomList.Count);
                binaryWriter.Write(customerList.Count);
                foreach (var room in roomList)
                {
                    room.WriteToFile(binaryWriter);
                }
                foreach (var customer in customerList)
                {
                    customer.WriteToFile(binaryWriter);
                }
                binaryWriter.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(filePath + " not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("Error writing to file: " + filePath);
            }

        }
        // Read by using ReadBinary
        public void ReadFromFile(string filePath)
        {
            //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));

                //Here we read an inventory entry.
                for (; ; )
                {
                    int roomCount, customerCount;
                    name = binaryReader.ReadString();
                    address = binaryReader.ReadString();
                    constructionDate = binaryReader.ReadString();
                    stars = binaryReader.ReadInt32();
                    roomCount = binaryReader.ReadInt32();
                    customerCount = binaryReader.ReadInt32();
                    for (var i = 0; i < roomCount; i++)
                    {
                        var room = new Room();
                        room.ReadFromFile(binaryReader);
                        roomList.Add(room);
                    }
                    for (var i = 0; i < customerCount; i++)
                    {
                        var customer = new Customer();
                        customer.ReadFromFile(binaryReader);
                        customerList.Add(customer);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(filePath + " not found!");

            }
            catch (IOException)
            {
                Console.WriteLine("Error reading");
            }
            finally
            {
                binaryReader.Close();
            }
        }

        public string WriteTextToFile(string filePath)
        {
            string res = "";
            try
            {
                TextWriter textWriter = new StreamWriter(filePath, append: true);
                res += this.ToStringg();
                foreach (var room in roomList)
                {
                    res += room.ToString();
                }
                foreach (var customer in customerList)
                {
                    res += customer.ToString();
                }
                textWriter.WriteLine(res);
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                res = filePath + " not found!";
            }
            catch (IOException)
            {
                res = "Error writing to file: " + filePath;
            }
            return res;
        }

        public string ReadTextFromFile(string filePath)
        {
            //Here we declare the binary writer and reader objects
            TextReader textReader = null;
            string res = "";
            string output = null;
            //Here we open the file for reading.
            try
            {
                textReader = new StreamReader(filePath);
                // Read an inventory entry.
                while ((output = textReader.ReadLine()) != null)
                {
                    res = output;
                }
            }
            catch (FileNotFoundException)
            {
                res = filePath + " not found!";

            }

            catch (IOException)
            {
                res = "Error reading " + filePath;
            }
            finally
            {
                textReader.Close();
            }
            return res;
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
        public string ToStringg()
        {
            string res = "";
            res += "Hotel Name: " + this.name + "\n";
            res += "Construction date: " + this.constructionDate + "\n";
            res += "Address: " + this.address + "\n";
            res += "Stars: " + this.stars + "\n";
            return res;
        }
    }
}