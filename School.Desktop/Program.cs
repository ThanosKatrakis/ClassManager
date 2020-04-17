using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Database;
using School.Entities;
using School.Services;

namespace School.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            ToConsole.AllCourses();
            Console.WriteLine("===========");
            ToConsole.AllAssignments();
            Console.WriteLine("===========");
            ToConsole.AllStudents();
            Console.WriteLine("===========");
            ToConsole.AllTrainers();



            Console.ReadKey();
        }
    }

    public class ToConsole
    {
        #region PrintCourses
        public static void AllCourses()
        {
            CourseRepository courseRepository = new CourseRepository();

            var courses = courseRepository.GetAll();

            foreach (var course in courses)
            {
                Console.WriteLine("{0, -5}{1, -10}", course.CourseId, course.Title);
            }
        }

        public static void CourseById(int? id)
        {
            CourseRepository courseRepository = new CourseRepository();

            var course = courseRepository.GetById(id);

            Console.WriteLine("{0, -5}{1, -10}", course.CourseId, course.Title);
        }

        public static void InsertCourse(Course c)
        {
            CourseRepository courseRepository = new CourseRepository();
            courseRepository.Insert(c);
        }

        public static void UpdateCourse(Course c)
        {
            CourseRepository courseRepository = new CourseRepository();
            courseRepository.Update(c);
        }

        public static void DeleteCourse(Course c)
        {
            CourseRepository courseRepository = new CourseRepository();
            courseRepository.Delete(c);
        }
        #endregion

        #region PrintAssignments
        public static void AllAssignments()
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            var assignments = assignmentRepository.GetAll();

            foreach (var assignment in assignments)
            {
                Console.WriteLine("{0, -5}{1, -10}", assignment.AssignmentId, assignment.Title);
            }
        }

        public static void AssignmentById(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            var assignment = assignmentRepository.GetById(id);

            Console.WriteLine("{0, -5}{1, -10}", assignment.AssignmentId, assignment.Title);
        }

        public static void InsertAssignment(Assignment a)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            assignmentRepository.Insert(a);
        }

        public static void UpdateAssignment(Assignment a)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            assignmentRepository.Update(a);
        }

        public static void DeleteAssignment(Assignment a)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            assignmentRepository.Delete(a);
        }
        #endregion

        #region PrintStudents
        public static void AllStudents()
        {
            StudentRepository studentRepository = new StudentRepository();

            var students = studentRepository.GetAll();

            foreach (var student in students)
            {
                Console.WriteLine("{0, -5}{1, -10}", student.StudentId, student.FirstName);
            }
        }

        public static void StudentById(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();

            var student = studentRepository.GetById(id);

            Console.WriteLine("{0, -5}{1, -10}", student.StudentId, student.FirstName);
        }

        public static void InsertStudent(Student s)
        {
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Insert(s);
        }

        public static void UpdateStudent(Student s)
        {
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Update(s);
        }

        public static void DeleteStudent(Student s)
        {
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Delete(s);
        }
        #endregion

        #region PrintTrainers
        public static void AllTrainers()
        {
            TrainerRepository trainerRepository = new TrainerRepository();

            var trainers = trainerRepository.GetAll();

            foreach (var trainer in trainers)
            {
                Console.WriteLine("{0, -5}{1, -10}", trainer.TrainerId, trainer.FirstName);
            }
        }

        public static void TrainerById(int? id)
        {
            TrainerRepository trainerRepository = new TrainerRepository();

            var trainer = trainerRepository.GetById(id);

            Console.WriteLine("{0, -5}{1, -10}", trainer.TrainerId, trainer.FirstName);
        }

        public static void InsertTrainer(Trainer t)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            trainerRepository.Insert(t);
        }

        public static void UpdateTrainer(Trainer t)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            trainerRepository.Update(t);
        }

        public static void DeleteTrainer(Trainer t)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            trainerRepository.Delete(t);
        }
        #endregion
    }
}
