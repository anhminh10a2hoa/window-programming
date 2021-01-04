using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    interface IHotel
    {
        string Name
        {
            get;
            set;
        }
        string ConstructionDate
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }
        int Stars
        {
            get;
            set;
        }
        List<Room> RoomList
        {
            get;
            set;
        }
        List<Customer> CustomerList
        {
            get;
            set;
        }
    }

    [Serializable]
    public class Hotel : IHotel
    {
        private string name, address, constructionDate;
        private int stars;
        private List<Room> roomList;
        private List<Customer> customerList;
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

        public void WriteToFile(string filePath)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));
                binaryWriter.Write(name);
                binaryWriter.Write(constructionDate);
                binaryWriter.Write(address);
                binaryWriter.Write(stars);
                binaryWriter.Write(roomList.Count);
                foreach (var room in roomList)
                {
                    room.WriteToFile(binaryWriter);
                }
                binaryWriter.Write(customerList.Count);
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

        public string ReadFromFile(string filePath)
        {
            string nameR, addressR, constructionDateR;
            int starsR;
            List<Room> roomListR;
            List<Customer> customerListR;
            //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            StringBuilder result = new StringBuilder();
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));

                //This is an infinite for loop-
                for (; ; )
                {
                    //Here we read an inventory entry.

                    nameR = binaryReader.ReadString();
                    addressR = binaryReader.ReadString();
                    constructionDateR = binaryReader.ReadString();
                    starsR = binaryReader.ReadInt32();
                    result.Append(string.Format(nameR + " " + addressR + " " + constructionDateR + " " + starsR));
                }
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");

            }
            catch (IOException)
            {
                result.Append("Error reading " + filePath);
            }
            finally
            {
                binaryReader.Close();
            }
            return result.ToString();
        }

        public override string ToString()
        {
            string res = "";
            res += "Hotel Name: " + this.name + "\n";
            res += "Construction date: " + this.constructionDate + "\n";
            res += "Address: " + this.address + "\n";
            res += "Stars: " + this.stars + "\n\n";
            res += "-----------\n";
            res += "Rooms list:\n";
            res += "-----------\n\n";
            foreach (var room in roomList)
            {
                res += room.ToString() + "\n";
                res += "\n";
            }
            res += "\n---------------\n";
            res += "Customers list:\n";
            res += "---------------\n\n";
            foreach (var customer in customerList)
            {
                res += customer.ToString() + "\n";
                res += "\n";
            }
            return res;
        }
    }
}
