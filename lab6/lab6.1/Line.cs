using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6.1
{
    public class Line
    {
        public void RecursionString(string[] sts)
        {
            foreach (var item in sts)
            {
                if (sts != null)
                {
                    Console.WriteLine(item.Reverse().ToArray());
                }
                else Console.WriteLine("Error");
            }
        }
        public void RecursionString()
        {
            string word = "Play GTA V Online!";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }    
        }
    }
}
