namespace HospitalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient[] patients = new Patient[2];

            patients[0] = new Patient("Flu");
            patients[0].SetData(1, "Ali");

            patients[1] = new Patient("Fever");
            patients[1].SetData(2, "Sara");

            Console.WriteLine(" Hospital Patient Records\n");

            foreach (Patient p in patients)
            {
                p.DisplayInfo();
            }

            Console.WriteLine("Total Patients: " + patients.Length);
        }
    }
}
        
