using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_practice_problems
{
  class Program
  {
    static void Main(string[] args)
    {
      /*********************************************************************** Problem 1 ***********************************************************************/
      /* var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
       var listOfWords = words.Where(w => w.Contains("th"));
       foreach (var word in listOfWords)
       {
         Console.WriteLine(word);
       }*/

      /*********************************************************************** Problem 2 ***********************************************************************/
      /*var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
      IEnumerable<string> distinctNames = names.Distinct();*/

      /*********************************************************************** Problem 3 ***********************************************************************/
      List<string> classGrades = new List<string>()
      {
        "80,100,92,89,65",
        "93,81,78,84,69",
        "73,88,83,99,64",
        "98,100,66,74,55"
       };

      double CalculateAverage2(List<string> grades)
      {
        List<double> AllAverages = new List<double>();

        foreach(string grade in grades)
        {
          // split string by comma, convert to List, convert list to ints
          string[] arrayOfGradesStr = new string[grade.Length];
          var listOfGrades = new List<int>();
          var minNumber = 0;

          arrayOfGradesStr = grade.Split(',');

          for (int i = 0; i < arrayOfGradesStr.Length; i++)
          {
            listOfGrades.Add(int.Parse(arrayOfGradesStr[i]));
          }

          // removes lowest grade
          minNumber = listOfGrades.Min();

          for (int i = 0; i < listOfGrades.Count; i++)
          {
            if (listOfGrades[i] == minNumber)
            {
              listOfGrades.RemoveAt(i);
            }
          }

          // averages the list
          double average;
          average = listOfGrades.Average();
          AllAverages.Add(average);
        }

        return AllAverages.Average();
      }

      Console.WriteLine(CalculateAverage2(classGrades));

      /********************************************************************************************************************************************************/
      Console.ReadLine();
    }
  }
}
