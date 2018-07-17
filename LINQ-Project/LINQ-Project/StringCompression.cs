using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Project
{
    class StringCompression
    {

        //public StringCompression()
        //{
        //    public str CharArray[];
        //}

        public static void Program()
        {
            Console.WriteLine("Please enter a word to compress: ");
            string word = Console.ReadLine();
            GetCharCount(word);
            SplitToArray(word);

        }


        public static void SplitToArray(string word)
        {
            string[] charArray = word.Split();


            foreach (var c in charArray)
            {
            Console.WriteLine(", " + c);
            
            }

            Console.ReadKey();
        }

        public static int GetCharCount(string word)
        {
            int count = word.Count(f => f == '/');
            Console.WriteLine("count: " + count);
            return count;
        }



    }

   
}
