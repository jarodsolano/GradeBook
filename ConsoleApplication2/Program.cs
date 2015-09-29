using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            double avgGrade = 0;
            // Find the average of the three grades.
            avgGrade = (s1 + s2 + s3) / 3;
            // Find the grade letter and return said grade letter.
            if (90 <= avgGrade && avgGrade <= 100)
            {
                return 'A';
            } 
            else if (80 <= avgGrade && avgGrade < 90)
            {
                return 'B';
            }
            else if (70 <= avgGrade && avgGrade < 80){
                return 'C';
            }
            else if (60 <= avgGrade && avgGrade < 70){
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
    class Caller
    {
        public static void Main(string[] args)
        {
            Debug.WriteLine(Program.GetGrade(3, 6, 9));
        }
    }
}
