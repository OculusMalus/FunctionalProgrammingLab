using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
    class Scores
    {
        static void Main()
        {
            string s = "90, 100, 82, 89, 55, 75, 88, 49, 32, 22,36,33";

            string[] words = s.Split(',');

            int[] scoreArray = words.Select(int.Parse).ToArray();

            List<int> scores = scoreArray.ToList();
          
            IEnumerable<int> scoreQuery = from score in scores
                                          orderby score
                                          select score;
           
            Console.Write("Here is your full list of scores:\n");

            scoreQuery.ToList().ForEach(i => Console.Write(i+" "));
           
            var scoresToGrade = scoreQuery.Skip(3);

            Console.Write("\n\nLet's drop the lowest three grades and calculate your average!\n\n");
            Console.WriteLine("Here is your new list of grades:");

            scoresToGrade.ToList().ForEach(i => Console.Write(i + " "));

            double average1 = scoresToGrade.Average();

            Console.WriteLine("\n\nYour average is: {0}", Math.Round(average1,2));
            Console.ReadLine();
        }
    }
}