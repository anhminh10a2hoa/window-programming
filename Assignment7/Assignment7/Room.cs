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
    [XmlRoot("room")]
    public class Room : IRoom
    {
        int area;
        string roomNumber, type, description;
        double price;
        [XmlElement("roomNumber")]
        public string RoomNumber
        {
            get
            {
                return this.roomNumber;
            }
            set
            {
                this.roomNumber = value;
            }
        }
        [XmlElement("area")]
        public int Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        [XmlElement("type")]
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        [XmlElement("description")]
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        [XmlElement("price")]
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public void WriteToFile(BinaryWriter binaryWriter)
        {
            try
            {
                binaryWriter.Write(roomNumber);
                binaryWriter.Write(area);
                binaryWriter.Write(type);
                binaryWriter.Write(price);
                binaryWriter.Write(description);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error writting");
            }
        }

        public void ReadFromFile(BinaryReader binaryReader)
        {
            try
            {
                roomNumber = binaryReader.ReadString();
                area = binaryReader.ReadInt32();
                type = binaryReader.ReadString();
                price = binaryReader.ReadDouble();
                description = binaryReader.ReadString();
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading");
            }
        }

        public Room(string roomNumber, int area, string type, double price, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.price = price;
            this.description = description;
        }

        public Room() { }

        public override string ToString()
        {
            string res = "";
            res += "\nRoom number: " + this.roomNumber + "\n";
            res += "Area: " + this.area + " m2\n";
            res += "Type: " + this.type + "\n";
            res += "Price: " + this.price + "\n";
            res += "Description: " + this.description + "\n";
            return res;
        }


    }
}