using System;
using System.Linq;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                {"StdNum", "Name", "Math", "Science", "English"},
                {"1001", "Alice", "85", "90", "78"},
                {"1002", "Bob", "92", "88", "84"},
                {"1003", "Charlie", "79", "85", "88"},
                {"1004", "David", "94", "76", "92"},
                {"1005", "Eve", "72", "95", "89"}
            };
            // You can convert string to double by
            // double.Parse(str)

            int stdCount = data.GetLength(0) - 1;
            // ---------- TODO ----------
             double mathMax = 0, mathMin = 0, scienceMax = 0, scienceMin = 0, englishMax = 0, englishMin = 0;

            double[] totalScores = new double[stdCount];
            double[] students = new double[stdCount];
            string[] names = new string[stdCount];
            double mathScore = 0;
            Console.WriteLine("Average scores: ");
            for (int i = 1; i <= 5; i++)
            {
                names[i - 1] = data[i, 1];
                mathScore += double.Parse(data[i,2]);
                if (mathMax == 0 || mathMax < double.Parse(data[i,2]))
                {
                    mathMax = double.Parse(data[i,2]);
                }
                if (mathMin == 0 || mathMin > double.Parse(data[i,2]))
                {
                    mathMin = double.Parse(data[i,2]);
                }
                students[i - 1] += double.Parse(data[i,2]);
                
            }
            mathScore /= 5;
            Console.WriteLine("Math: " + mathScore);

            double scienceScore = 0;
            for (int i = 1; i <= 5; i++)
            {
                scienceScore += double.Parse(data[i,3]); 
                if (scienceMax == 0 || scienceMax < double.Parse(data[i,3]))
                {
                    scienceMax = double.Parse(data[i,3]);
                }
                if (scienceMin == 0 || scienceMin > double.Parse(data[i,3]))
                {
                    scienceMin = double.Parse(data[i,3]);
                }
                students[i - 1] += double.Parse(data[i,3]);
            }
            scienceScore /= 5;
            Console.WriteLine("Science: " + scienceScore);

            double englishScore = 0;
            for (int i = 1; i <= 5; i++)
            {
                englishScore += double.Parse(data[i,4]); 
                if (englishMax == 0 || englishMax < double.Parse(data[i,4]))
                {
                    englishMax = double.Parse(data[i,4]);
                }
                if (englishMin == 0 || englishMin > double.Parse(data[i,4]))
                {
                    englishMin = double.Parse(data[i,4]);
                }
                students[i - 1] += double.Parse(data[i,4]);
            }
            englishScore /= 5;
            Console.WriteLine("English: " + englishScore);

            Console.WriteLine("\nMax and min scores: ");
            Console.WriteLine("Math: (" + mathMax + ", " + mathMin + ")");
            Console.WriteLine("Science: (" + scienceMax + ", " + scienceMin + ")");
            Console.WriteLine("English: (" + englishMax + ", " + englishMin + ")");
            
            
            Console.WriteLine("\nStudents rank by total scores:");
            string[] studentnames = {"Alice", "Bob", "Charlie", "David", "Eve"};

            for(int i = 0; i < students.Length; i++){
                int j = 1;
                for(int k = 0; k < students.Length; k++){
                    if (students[k] > students[i])
                    {
                        j++;
                    }
                }
                if (j == 1)
                {
                    Console.WriteLine(studentnames[i] + ": " + j + "st");
                }
                else if (j == 2)
                {
                    Console.WriteLine(studentnames[i] + ": " + j + "nd");
                }
                else if (j == 3)
                {
                    Console.WriteLine(studentnames[i] + ": " + j + "rd");
                }
                else
                {
                    Console.WriteLine(studentnames[i] + ": " + j + "th");
                }

            }

            // --------------------
        }
    }
}

/* example output

Average Scores: 
Math: 84.40
Science: 86.80
English: 86.20

Max and min Scores: 
Math: (94, 72)
Science: (95, 76)
English: (92, 78)

Students rank by total scores:
Alice: 4th
Bob: 1st
Charlie: 5th
David: 2nd
Eve: 3rd

*/
