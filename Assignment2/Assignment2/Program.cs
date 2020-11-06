using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Assignment2;

namespace Hw2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string firstConcert;
            string secondConcert;
            string keyOfConcert;
            string concertInput;
            string o;

            Function Function = new Function();
            Hashtable concerts = new Hashtable();
            concerts.Add("MP2017", new Concert("Modena Park 2017", "Modena", new DateTime(2017, 7, 1, 8, 00, 00), 125.00));
            concerts.Add("FSL1980", new Concert("Frank Sinatra Live", "Rio de Janeiro", new DateTime(1980, 1, 26, 8, 00, 00), 110.00));
            concerts.Add("TLET2005", new Concert("Tunnel of Love Express Tour", "Berlin", new DateTime(2005, 7, 19, 8, 00, 00), 85.00));
            concerts.Add("ZC2017", new Concert("Zócalo Concert", "Mexico City", new DateTime(2017, 11, 25, 8, 00, 00), 150.00));
            concerts.Add("TCRAT2014", new Concert("The Cowboy Rides Away Tour", "Arlington", new DateTime(2014, 6, 7, 8, 00, 00), 200.00));

            while (true)
            {
                try
                {
                    Console.WriteLine("\n----------------List of options-----------------");
                    Console.WriteLine("1: Get all concerts information");
                    Console.WriteLine("2: Compare the price of 2 concerts");
                    Console.WriteLine("3: Search the key of concerts");
                    Console.WriteLine("4: Increase/decrease the price of the concert by 5 euro");
                    Console.WriteLine("exit: Exit the programming");
                    Console.WriteLine("----------------End of options-----------------\n");

                    Console.Write("Please choose your option: ");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("-----------List of the five highest concerts in the world------------\n");
                            Console.WriteLine(Function.GetAllConcerts(concerts));
                            break;

                        case "2":
                            Console.Write("Please type the first concert: ");
                            firstConcert = Console.ReadLine();
                            Console.Write("Please type the second concert: ");
                            secondConcert = Console.ReadLine();
                            Console.WriteLine(Function.CompareTwoConcerts(firstConcert, secondConcert, concerts));
                            break;

                        case "3":
                            Console.Write("Please type the key of the concert: ");
                            keyOfConcert = Console.ReadLine();
                            Console.WriteLine(Function.GetConcert(keyOfConcert, concerts));
                            break;

                        case "4":
                            Console.Write("Please type the concert you want to (increase/decrease) the price: ");
                            concertInput = Console.ReadLine();
                            Console.Write("Choose increase or decrease: ");
                            o = Console.ReadLine();
                            Console.WriteLine(Function.OperatorPrice(concertInput, o, concerts));
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default: break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
                }
            }
            
            Console.ReadLine();
        }
    }
}