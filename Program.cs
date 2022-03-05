using System;
namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.PrintName("Kasun");
            Console.WriteLine(p.ToString());

            Student student = new Student();
            student.Name = "Dirk";
            student.LastName = "Strauss";
            student.CourseCodes = new List<int> { 203, 202, 101 };
            p.OutputInformation(student);
            Professor prof = new Professor();
            prof.Name = "Reinhardt";
            prof.LastName = "Botha";
            prof.TeachesSubjects = new List<string> {
 "Mobile Development", "Cryptography" };
            p.OutputInformation(prof);
            p.OutputInformation(null);

        }

        /// <summary>
        /// It will print your name on the console
        /// </summary>
        /// <param name="name"></param>
        public void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public void OutputInformation(object person)
        {

            switch (person)
            {
                case Student student when (student.CourseCodes.Contains(203)):
                    Console.WriteLine($"Student {student.Name} {student.LastName}is enrolled for course 203.");
                    break;
                case Student student:
                    Console.WriteLine($"Student {student.Name} {student.LastName}is enrolled for courses { String.Join<int>(", ", student.CourseCodes)}");
                    break;
                case Professor prof:
                    Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches { String.Join<string>(",", prof.TeachesSubjects)} ");
                    break;
                case null:
                    Console.WriteLine($"Object {nameof(person)} is null");
                    break;
                default:
                    Console.WriteLine("Unknown object detected");
                    break;
            }

        }
    }

}
