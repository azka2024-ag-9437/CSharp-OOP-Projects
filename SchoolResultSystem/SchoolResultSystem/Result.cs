using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolResultSystem
{
    internal class Result : Student
    {
        private int[] marks = new int[3];

        public void SetMarks(int m1, int m2, int m3)
        {
            marks[0] = m1;
            marks[1] = m2;
            marks[2] = m3;
        }

        public int GetTotal()
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];
            return total;
        }

        public double GetPercentage()
        {
            return GetTotal() / 3.0;
        }

        public string GetGrade()
        {
            double p = GetPercentage();

            if (p >= 80) return "A";
            else if (p >= 60) return "B";
            else if (p >= 40) return "C";
            else return "Fail";
        }

        public void DisplayResult()
        {
            Console.WriteLine("Roll No: " + GetRollNo());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Total Marks: " + GetTotal());
            Console.WriteLine("Percentage: " + GetPercentage());
            Console.WriteLine("Grade: " + GetGrade());
            Console.WriteLine("-------------------------");
        }
    }

}
