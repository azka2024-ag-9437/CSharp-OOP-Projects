namespace SchoolResultSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Result r1 = new Result();
                r1.SetStudent(101, "Ahmed");
                r1.SetMarks(75, 80, 70);

                Result r2 = new Result();
                r2.SetStudent(102, "Ayesha");
                r2.SetMarks(85, 90, 88);

                Console.WriteLine(" School Result System\n");

                r1.DisplayResult();
                r2.DisplayResult();
            }
        }
    }

