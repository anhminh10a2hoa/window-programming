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
        public TextAnalyzer(string text)
        {
            this.text = text;
        }
        public string getText()
        {
            return this.text;
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
