using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal  abstract class Person
    {
        private int id;           // Encapsulation
        private string name;

        public void SetData(int i, string n)
        {
            id = i;
            name = n;
        }

        public int GetId() => id;
        public string GetName() => name;

        public abstract void DisplayInfo(); // Abstraction
    }
}

