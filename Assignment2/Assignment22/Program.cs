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
            string text = "";

            // Random 50 characters and create initialization text
            char[] characters = new char[50];
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                int num = rand.Next(0, chars.Length - 1);
                characters[i] = chars[num];
            }

            Console.WriteLine("Initialization text: \n" + new string(characters));

            Array.Sort(characters);
            text = new string(characters);
            TextAnalyzer textAnalyzer = new TextAnalyzer(text);

            Console.WriteLine("After sorting: \n" + textAnalyzer.getText());

            SortedList<char, int> sortedList = textAnalyzer.CreateSortedList();
            foreach (var character in sortedList)
            {
                Console.WriteLine("Character: " + character.Key + " appears " + character.Value + " times");
            }
            Console.ReadLine();
        }
    }
}
