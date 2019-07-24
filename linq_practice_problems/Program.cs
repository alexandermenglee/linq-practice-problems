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
      /************************************** Problem 1 **************************************/
      /* var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
       var listOfWords = words.Where(w => w.Contains("th"));
       foreach (var word in listOfWords)
       {
         Console.WriteLine(word);
       }*/

      /************************************** Problem 2 **************************************/
      /*var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
      IEnumerable<string> distinctNames = names.Distinct();*/

      /************************************** Problem 2 **************************************/
      List<string> classGrades = new List<string>()
      {
        "80,100,92,89,65",
        "93,81,78,84,69",
        "73,88,83,99,64",
        "98,100,66,74,55"
       };

      Func<List<string>, double> stringToDouble;

      stringToDouble = CalculateAverage;


      double CalculateAverage(List<string> grades)
      {
        List<double> AllAverages = new List<double>();

        foreach (string grade in grades)
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

          // [89, 45, 23, 53, 67, 69]

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

          // push to AllAverage List
          AllAverages.Add(average);
        }

        return AllAverages.Average();
      }

      Console.WriteLine(stringToDouble(classGrades));

      /************************************** Problem 4 **************************************/
      string ConvertStringToList(string value)
      {
        List<string> stringList = new List<string>();
        List<int> distinctNumbers = new List<int>();
        List<int> letterFrequency = new List<int>();
        List<string> distinctLetters = new List<string>();
        string result = "";

        // Adds each letter from value into stringList
        for (int i = 0; i < value.Length; i++)
        {
          stringList.Add(value[i].ToString());
        }

        //  This list will put the characters in the list in alphabetical order and filter out the duplicates
        distinctLetters = stringList.OrderBy(x => x).Distinct().ToList();

        // This foreach loop goes through the distinctLetters list and compares each character of the distinctLetters to the original    StringList, then goes and find the frequency of each character in the stringList
        foreach (var letter in distinctLetters) 
        {
          letterFrequency.Add(stringList.Where(x => x.Equals(letter)).Count());
        }

        // This for loop is used to output a string that concatenates together the chars of distinctLetters and letterFrequency lists
        for (int i = 0; i < distinctLetters.Count; i++) 
        {
          result += distinctLetters[i];
          result += letterFrequency[i];
        }

        Console.WriteLine(result);
        return result;
      }

      ConvertStringToList("teeth");

      /*******************************************************************************/
      Console.ReadLine();
    }
  }
}
