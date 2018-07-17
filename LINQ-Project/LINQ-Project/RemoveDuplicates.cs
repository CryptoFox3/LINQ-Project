using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    class RemoveDuplicates
    {

       public static void DisplayNamesNoDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            var uniqueNames = names.Select(n => n).Distinct().ToList();
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }





    }
}
