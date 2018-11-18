using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcCore.Models
{
    public class Course
    {
        public Course()
        {
                
        }

        public Course( string courseName,string courseCode,string trainer,string time)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            Trainer = trainer;
            Time = time;
        }
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Trainer { get; set; }
        public string Time { get; set; }
    }
}
