using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course course1 = new Course("C_001", "python for beginners", "3 months", 10);
            //Console.WriteLine(course1.ToString());
            //Console.ReadLine();

            bool repeat=false;

            while (!repeat)
            {
                Console.WriteLine("Course Management System");
                Console.WriteLine("1.Add Course");
                Console.WriteLine("2.Read Course");
                Console.WriteLine("3.Edit Course");
                Console.WriteLine("4.Delete Course");
                Console.WriteLine("5.Exit");
                Console.Write("Choose an option");
                string option=Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCourse();
                        break;
                        case "2":
                        ReadCourse();
                        break;
                        case "3":
                        UpdateCourse();
                        break;
                        case "4":
                        DeleteCourse();
                        break;
                        case "5":
                        repeat= true;
                        break;
                        default:
                        Console.WriteLine("Invalid number");

                        
                }

            }
        }
    }
}
