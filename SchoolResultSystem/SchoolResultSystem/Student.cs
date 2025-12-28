using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolResultSystem
{
    internal class Student
    {
        private int rollNo;
        private string name;

        public void SetStudent(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public int GetRollNo() => rollNo;
        public string GetName() => name;
    }
}
