using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definiera text
            //string text = "The quick brown fox jumps over the lazy dog";
            string text = "aabcd";

            //Räkna ord
            int wordCount = CountWords(text);
            Console.WriteLine("Antal ord: " + wordCount);
            
            //Räkna tecken
            int charCount = CountChars(text);
            Console.WriteLine("Antal unika tecken: " + charCount);
        }

        private static int CountChars(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (!result.Contains(text[i]))
                    result += text[i];
            }

            return result.Length;
        }

        private static int CountWords(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
                if (text[i] == ' ') counter++;

            if (text.Length > 0)
                counter++;

            return counter;
        }
    }
}
