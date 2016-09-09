using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
    class LINQQueryExpressions
    {
        static void Main()
        {  
            string s = "90, 100, 82, 89, 55, 75, 88, 49, 32";

            string[] words = s.Split(',');

            int length = words.Length;

            int[] scores = new int[words.Length];

            for (int i=0; i< words.Length; i++)
            {
                int number = Int32.Parse(words[i]);
                scores[i] = number;
            }
            
            // Define the query expression.
            IEnumerable<int> scoreQuery = from score in scores
                                          orderby score 
                                          //where score > 50
                                          select score;

            // Execute the query.
            Console.Write("Here is a full list of scores:\n");
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}