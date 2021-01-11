using System;
using System.Collections.Generic;
using System.IO;
// XML
using System.Xml;
using System.Xml.Serialization;
// Json
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment7
{
    [Serializable, XmlType("customer"), DataContract]
    public class Customer : ICustomer
    {
        private string name, address, roomNumber;
        string arrivalDate;
        int stayDuration;
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
        [XmlElement("roomNumber"), DataMember]
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
        [XmlElement("arrivalDate"), DataMember]
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
        [XmlElement("stayDuration"), DataMember]
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

        public Customer() { }

        public override string ToString()
        {
            string res = "";
            res += "\nCustomer name: " + this.name + "\n";
            res += "Address: " + this.address + "\n";
            res += "Room: " + this.roomNumber + "\n";
            res += "Arrival date: " + this.arrivalDate + "\n";
            res += "Length of stay: " + this.stayDuration + "\n";
            return res;
        }
    }
}