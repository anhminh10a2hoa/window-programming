using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class IHotel
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
}