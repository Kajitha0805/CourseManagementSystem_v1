using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        List<Course> courses=new List<Course>();
        //Course course=new Course();

        public void CreateCourse(Course course)
        {

            courses.Add(course);
            Console.WriteLine("Successfully added");
        }
        public void ReadCourse()
        {
            if(courses.Count == 0)
            {
                Console.WriteLine("Courses not found");
            }else
            {
                foreach(var course in courses)
                {
                    Console.WriteLine(course);
                }
            }
        }
        public void UpdateCourse(string courseId,string title,string duration,decimal price)
        {

            var updateCourse = courses.SingleOrDefault(x => x.Equals(courseId));
            if (updateCourse == null)
            {
                Console.WriteLine("Course not found");
            }else
            {
                courses.Remove(updateCourse);   
                Course newCourse=new Course(courseId,title,duration,price);
                courses.Add(newCourse);
                Console.WriteLine("Course update successfully");
            }
        }
        public void DeleteCourse(string courseId)
        {
            var course = courses.SingleOrDefault(x => x.Equals(courseId));
            if (course == null)
            {
                Console.WriteLine("Course not found");
            }
            else
            {
                courses.Remove(course);
                Console.WriteLine("Deleted successfully");
            }
            
        }
        public decimal ValidateCoursePrice

    }
}
