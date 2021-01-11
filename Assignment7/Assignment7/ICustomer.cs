using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public interface ICustomer
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
}