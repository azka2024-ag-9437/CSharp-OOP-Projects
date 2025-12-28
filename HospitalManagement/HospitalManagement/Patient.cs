using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Patient : Person, IPerson
    {
        private string disease;

        public Patient(string d)
        {
            disease = d;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Patient ID: " + GetId());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Disease: " + disease);
            Console.WriteLine("------------------------");
        }
    }
    
}
