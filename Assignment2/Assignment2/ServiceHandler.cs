using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Assignment2
{
    class ServiceHandler
    {
        public static string GetAllConcerts(Hashtable concerts)
        {
            string res = "";
            foreach (DictionaryEntry item in concerts)
            {
                res += "Key: " + item.Key + "\n" + ((Concert)item.Value).toString() + "\n";
            }
            return res;
        }

        public static string CompareTwoConcerts(string firstConcert, string secondConcert, Hashtable concerts)
        {
            Concert c1 = (Concert)concerts[firstConcert];
            Concert c2 = (Concert)concerts[secondConcert];
            if (c1 > c2)
            {
                return "The " + firstConcert + " concert is more expensive than " + secondConcert;
            }
            else
            {
                return "The " + secondConcert + " concert is more expensive than " + firstConcert;
            }
        }

        public static string GetConcert(string concertKey, Hashtable concerts)
        {
            int count = 0;
            string res = "";
            foreach (DictionaryEntry item in concerts)
            {
                if (item.Key.Equals(concertKey))
                {
                    count++;
                    res = "Key: " + item.Key + "\n" + ((Concert)item.Value).toString() + "\n";
                }
            }
            if(count == 0)
            {
                return "Can not find the concert with key: " + concertKey;
            }
            return res;
        }

        public static string OperatorPrice(string concert, string o, Hashtable concerts)
        {
            Concert c3 = (Concert)concerts[concert];
            string res = "";
            if (o.Equals("increase"))
            {
                c3++;
                res = c3.toString();
            }
            else if (o.Equals("decrease"))
            {
                c3--;
                res = c3.toString();
            }
            else
            {
                res = "Undefined operator";
            }
            return res;
        }
    }
}
