using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    //put static in program class
    static class Program
    {
        /*9.	Extension method
         * In a separate Project create a program and write an extension method.  
         * The extension method should count the number of words in a sentence.  
         * Test that this works using several sentences of text.
         */

        static void Main(string[] args)
        {
            string s = "Hello World";
            string x = "Hello World 2";
            Console.WriteLine(s.WordCount());
            Console.WriteLine(x.WordCount());

        }

        public static int WordCount(this string text)
        {
            //split text into words you can put into an array split by a space
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
