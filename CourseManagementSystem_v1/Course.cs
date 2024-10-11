using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
         private string CourseId { get; set; }
         private string Title {  get; set; }
         private string Duration { get; set; }
         private decimal Price {  get; set; }


        public Course(string courseId,string title,string duration,decimal price)
        {
            CourseId = courseId;
            Title=title;
            Duration=duration;
            Price=price;
        }
        public override string ToString()
        {
            return $"CourseId:{CourseId},Title:{Title},Duration:{Duration},Price:{Price}";
        }
    }
}
