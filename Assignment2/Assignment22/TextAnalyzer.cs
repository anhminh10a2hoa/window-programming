using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    class TextAnalyzer
    {
        private string text;
        public TextAnalyzer(out string text)
        {
            initializeText(out text);
            this.text = text;
        }
        public string getText()
        {
            return this.text;
        }

        public void initializeText(out string text)
        {
            char[] characters = new char[50];
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                int num = rand.Next(0, chars.Length - 1);
                characters[i] = chars[num];
            }
            text = new string(characters);
        }
        public SortedList<char, int> CreateSortedList()
        {
            SortedList<char, int> charCharacters = new SortedList<char, int>();

            foreach (char character in this.text)
            {
                if (charCharacters.ContainsKey(character))
                    charCharacters[character]++;
                else
                    charCharacters[character] = 1;
            }

            return charCharacters;
        }
    }
}
