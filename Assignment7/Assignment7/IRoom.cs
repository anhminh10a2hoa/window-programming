using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public interface IRoom
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
}