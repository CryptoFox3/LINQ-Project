using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Project
{

    public class FindStringInList
    {

        public FindStringInList()
        {
            IEnumerable<string> findString = words.Where(word => word.Contains("th"));
            foreach (string word in findString)
            {
                Console.WriteLine(word);
            }
        }

        
        List<string> words = new List<string>
        { "the", "bike", "this", "it", "tenth", "mathematics" };

        


    //var words.Where(str => str.Contains("th"))){

    //    }





}

}
