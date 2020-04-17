using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using School.Entities;

namespace School.Web.Models
{
    public class StatsViewModel
    {
        public int CoursesCount { get; set; }
        public int TrainersCount { get; set; }
        public int StudentsCount { get; set; }
        public int AssignmentsCount { get; set; }


        public IEnumerable<Course> CourseTable { get; set; }
    }
}