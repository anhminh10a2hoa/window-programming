using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    interface IRoom
    {
        string RoomNumber
        {
            get;
            set;
        }
        int Area
        {
            get;
            set;
        }
        string Type
        {
            get;
            set;
        }
        string Description
        {
            get;
            set;
        }
        double Price
        {
            get;
            set;
        }
    }

    public class Room : IRoom
    {
        private int area;
        private string roomNumber, type, description;
        private double price;

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
                Console.WriteLine(e.Message + "\n");
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
    }
}
       
