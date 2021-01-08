using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment7
{
    [XmlRoot("hotel")]
    public class Hotel : IHotel
    {
        private string name, address, constructionDate;
        private int stars;
        private List<Room> roomList;
        private List<Customer> customerList;
        [XmlElement("name")]
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
        [XmlElement("constructionDate")]
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
        [XmlElement("address")]
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
        [XmlElement("stars")]
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
        [XmlArray("customerList")]
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
        [XmlArray("roomList")]
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
            catch (IOException){}
            finally
            {
                binaryReader.Close();
            }
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

        public static void WriteXML<T>(T type, string filePathName)
        {
            XmlSerializer serializer = new XmlSerializer(type.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(filePathName, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true

            });
            serializer.Serialize(xmlWriter, type);
            xmlWriter.Close();
        }
        //This generic method reeads and returns the content of the XML file
        //in a generic form
        public static T ReadXML<T>(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                T data = (T)serializer.Deserialize(stream);
                return data;
            }
        }
    }
}