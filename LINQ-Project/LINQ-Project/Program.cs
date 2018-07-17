using System;

namespace LINQ_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            FindStringInList findStringInList = new FindStringInList();
            Console.ReadKey();
            StringCompression.Program();
            Console.ReadKey();
            RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            Console.ReadKey();
        }
    }
}
