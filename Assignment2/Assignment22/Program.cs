using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            TextAnalyzer textAnalyzer = new TextAnalyzer(out text);
            Console.WriteLine("Initialization text: \n" + text + "\n");

            SortedList<char, int> sortedList = textAnalyzer.CreateSortedList();
            foreach (var character in sortedList)
            {
                Console.WriteLine("Character: " + character.Key + " appears " + character.Value + " times");
            }
            Console.ReadLine();
        }
    }
}
