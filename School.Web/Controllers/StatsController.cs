using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Services;
using School.Entities;
using School.Web.Models;

namespace School.Web.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            StatsViewModel vm = new StatsViewModel();

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            int courseCount = courses.Count();
            vm.CoursesCount = courseCount;

            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();
            int trainerCount = trainers.Count();
            vm.TrainersCount = trainerCount;

            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignments = assignmentRepository.GetAll();
            int assignmentCount = assignments.Count();
            vm.AssignmentsCount = assignmentCount;

            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();
            int studentCount = students.Count();
            vm.StudentsCount = studentCount;

            vm.CourseTable = courses; 

            return View(vm);
        }
    }
}