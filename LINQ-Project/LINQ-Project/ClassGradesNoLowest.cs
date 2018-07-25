using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Project
{
    //CURRENTLY NOT FINISHED
    public class ClassGradesNoLowest
    {
        
        public static List<string> classGrades = new List<string>
        {
            
            "80,100,92,89,65", 
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"

        };

        
        public void SplitListStrings()
        {
            var splitStrings = classGrades.Select(s => s.Split(','));
        }
        
        public void FindAverageClassGrade()
        {

        }



        public void ConvertListStringToDouble()
        {
            var stringToDouble = classGrades.Select(g => g.Cast<double>());
        }


    }
}
//IEnumerable<int> grades = classGrades.Cast<int>();
//string[] splitStrings = classGrades.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);