using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Age = 35;
            person.Address = "Piippukatu 2";
            person.PhoneNumber = "020-12345678";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu 1";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-87654321";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Antti", "Ohjain", "N565");
            student.Address = "Aaltokatu 6";
            student.Age = 20;
            student.PhoneNumber = "014-23456789";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
