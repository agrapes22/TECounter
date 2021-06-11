using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECounter
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "";

            int count = 0;

            //read all text to a single string
            text = File.ReadAllText("test.txt");
            
            //split at spaces
            String[] words = text.Split(' ');

            //check each word's last character
            for (int i = 0; i < words.Length; i++)
            {
                Char[] w = words[i].ToCharArray();
                if (w[w.Length - 1] == 'T' || w[w.Length - 1] == 't')
                {
                    count++;
                }

                if (w[w.Length - 1] == 'E' || w[w.Length - 1] == 'e')
                {
                    count++;
                }
            }


            Console.WriteLine("There are " + count + " words that end in t or e");
        }
    }
}
