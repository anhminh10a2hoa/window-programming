using System.Runtime.Serialization;

namespace Assignment9
{
    [DataContract]
    class Customer
    {
        private string id, firstName, lastName, phoneNumber;
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
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        [DataMember]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
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
        public Customer(string id, string firstName, string lastName, string phoneNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            string res = "";
            res += "Id: " + this.id
                    + "\nFirst name: " + this.firstName 
                    + "\nLast name: " + this.lastName
                    + "\nPhone: " + this.phoneNumber + "\n";
            return res;
        }
    }
}