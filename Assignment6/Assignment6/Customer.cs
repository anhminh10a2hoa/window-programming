using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    interface ICustomer
    {
        string Name
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }
        string RoomNumber
        {
            get;
            set;
        }
        string ArrivalDate
        {
            get;
            set;
        }
        int StayDuration
        {
            get;
            set;
        }
    }

    public class Customer : ICustomer
    {
        private string name, address, roomNumber;
        string arrivalDate;
        int stayDuration;
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

        public string ArrivalDate
        {
            get
            {
                return this.arrivalDate;
            }
            set
            {
                this.arrivalDate = value;
            }
        }

        public int StayDuration
        {
            get
            {
                return this.stayDuration;
            }
            set
            {
                this.stayDuration = value;
            }
        }

        public Customer(string name, string address, string arrivalDate, string roomNumber, int stayDuration)
        {
            this.name = name;
            this.address = address;
            this.arrivalDate = arrivalDate;
            this.roomNumber = roomNumber;
            this.stayDuration = stayDuration;
        }

        public void WriteToFile(BinaryWriter binaryWriter)
        {
            try
            {
                binaryWriter.Write(name);
                binaryWriter.Write(address);
                binaryWriter.Write(roomNumber);
                binaryWriter.Write(arrivalDate);
                binaryWriter.Write(stayDuration);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }

        public override string ToString()
        {
            string res = "";
            res += "Customer name: " + this.name + "\n";
            res += "Address: " + this.address + "\n";
            res += "Room: " + this.roomNumber + "\n";
            res += "Arrival date: " + this.arrivalDate + "\n";
            res += "Length of stay: " + this.stayDuration + "\n";
            return res;
        }
    }
}
