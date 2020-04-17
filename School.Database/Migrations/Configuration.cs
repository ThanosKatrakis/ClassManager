namespace School.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using School.Entities;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<School.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(School.Database.MyDatabase context)
        {
            #region SEED COURSE SYSTEM

            // ~~~ SEEDING ASSIGNMENTS ~~~~~~~~~~~~~~~~~~~~~~~
            Assignment a1 = new Assignment() { Title = "C# Individual Part I ft", Description = "Create a basic console app", SubmissionDate = new DateTime(2020, 1, 1), OralMark = 20, TotalMark = 100 };
            Assignment a2 = new Assignment() { Title = "C# Individual Part II ft", Description = "Create a basic ASP.NET Project", SubmissionDate = new DateTime(2020, 2, 1), OralMark = 10, TotalMark = 100 };
            Assignment a3 = new Assignment() { Title = "C# Individual Part III ft", Description = "Create a full functional web app", SubmissionDate = new DateTime(2020, 3, 1), OralMark = 20, TotalMark = 100 };
            Assignment a4 = new Assignment() { Title = "Java Individual Part I ft", Description = "Create a basic console app", SubmissionDate = new DateTime(2020, 1, 1), OralMark = 20, TotalMark = 100 };
            Assignment a5 = new Assignment() { Title = "Java Individual Part II ft", Description = "Create a basic web Project", SubmissionDate = new DateTime(2020, 2, 1), OralMark = 10, TotalMark = 100 };
            Assignment a6 = new Assignment() { Title = "Java Individual Part III ft", Description = "Create a full functional web app", SubmissionDate = new DateTime(2020, 3, 1), OralMark = 20, TotalMark = 100 };
            Assignment a7 = new Assignment() { Title = "C# Individual Part I pt", Description = "Create a basic console app", SubmissionDate = new DateTime(2020, 3, 1), OralMark = 20, TotalMark = 100 };
            Assignment a8 = new Assignment() { Title = "C# Individual Part II pt", Description = "Create a basic ASP.NET Project", SubmissionDate = new DateTime(2020, 6, 1), OralMark = 10, TotalMark = 100 };
            Assignment a9 = new Assignment() { Title = "C# Individual Part III pt", Description = "Create a full functional web app", SubmissionDate = new DateTime(2020, 9, 1), OralMark = 20, TotalMark = 100 };
            Assignment a10 = new Assignment() { Title = "Java Individual Part I pt", Description = "Create a basic console app", SubmissionDate = new DateTime(2020, 3, 1), OralMark = 20, TotalMark = 100 };
            Assignment a11 = new Assignment() { Title = "Java Individual Part II pt", Description = "Create a basic web Project", SubmissionDate = new DateTime(2020, 6, 1), OralMark = 10, TotalMark = 100 };
            Assignment a12 = new Assignment() { Title = "Java Individual Part III pt", Description = "Create a full functional web app", SubmissionDate = new DateTime(2020, 9, 1), OralMark = 20, TotalMark = 100 };
            Assignment a13 = new Assignment() { Title = "Javascript Individual Part I pt", Description = "Create a dice mini app", SubmissionDate = new DateTime(2020, 3, 1), OralMark = 30, TotalMark = 100 };
            Assignment a14 = new Assignment() { Title = "Javascript Individual Part II pt", Description = "Create a basic app with Nodejs", SubmissionDate = new DateTime(2020, 6, 1), OralMark = 20, TotalMark = 100 };
            Assignment a15 = new Assignment() { Title = "Javascript Individual Part III pt", Description = "Create a full functional web app", SubmissionDate = new DateTime(2020, 9, 1), OralMark = 20, TotalMark = 100 };

            // ~~~ SEEDING TRAINERS ~~~~~~~~~~~~~~~~~~~~~~~~~~
            Trainer t1 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "Back End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t2 = new Trainer() { FirstName = "Kostantinos", LastName = "Strogulos", Subject = "Back End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t3 = new Trainer() { FirstName = "Kostas", LastName = "Minaidis", Subject = "Back End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t4 = new Trainer() { FirstName = "Vasilis", LastName = "Tzelepopoulos", Subject = "Back End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t5 = new Trainer() { FirstName = "Konstantinos", LastName = "Zitis", Subject = "Back End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t6 = new Trainer() { FirstName = "Giorgos", LastName = "Pasparakis", Subject = "Front End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t7 = new Trainer() { FirstName = "Panagiotis", LastName = "Mpozas", Subject = "Front End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t8 = new Trainer() { FirstName = "Vasilis", LastName = "Athanasiou", Subject = "Front End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t9 = new Trainer() { FirstName = "Makis", LastName = "Efthimiadis", Subject = "Front End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };
            Trainer t10 = new Trainer() { FirstName = "Aris", LastName = "Dermetzoglou", Subject = "Front End Tecnologies", PhotoUrl = "https://www.iconshock.com/image/Sigma/people/teacher/" };

            // ~~~ SEEDING STUDENTS ~~~~~~~~~~~~~~~~~~~~~~~~~~
            Student s1 = new Student() { FirstName = "Thanos", LastName = "Katrakis", BirthDate = new DateTime(1990, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s2 = new Student() { FirstName = "Panos", LastName = "Rizos", BirthDate = new DateTime(1990, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s3 = new Student() { FirstName = "Eleni", LastName = "Parisi", BirthDate = new DateTime(1991, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s4 = new Student() { FirstName = "Dionisis", LastName = "Pilikas", BirthDate = new DateTime(1983, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s5 = new Student() { FirstName = "Aggelos", LastName = "Pantos", BirthDate = new DateTime(1997, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s6 = new Student() { FirstName = "Eirini", LastName = "Fergadi", BirthDate = new DateTime(1998, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s7 = new Student() { FirstName = "Anna", LastName = "Talka", BirthDate = new DateTime(1991, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s8 = new Student() { FirstName = "Sofia", LastName = "Lagiou", BirthDate = new DateTime(1983, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s9 = new Student() { FirstName = "Maria", LastName = "Krakitsou", BirthDate = new DateTime(1970, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s10 = new Student() { FirstName = "Petros", LastName = "Petrou", BirthDate = new DateTime(1980, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s11 = new Student() { FirstName = "Dimitra", LastName = "Keramida", BirthDate = new DateTime(1991, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s12 = new Student() { FirstName = "Ioanna", LastName = "Kremlidou", BirthDate = new DateTime(1993, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s13 = new Student() { FirstName = "Elisavet", LastName = "Vosniak", BirthDate = new DateTime(1985, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s14 = new Student() { FirstName = "Takis", LastName = "Haramis", BirthDate = new DateTime(1992, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s15 = new Student() { FirstName = "Akis", LastName = "Petroulakos", BirthDate = new DateTime(1999, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s16 = new Student() { FirstName = "Filio", LastName = "Papapetrou", BirthDate = new DateTime(2000, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s17 = new Student() { FirstName = "Antisthenis", LastName = "Zaharis", BirthDate = new DateTime(2001, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s18 = new Student() { FirstName = "Xenofontas", LastName = "Vlahogiannis", BirthDate = new DateTime(2002, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s19 = new Student() { FirstName = "Karol", LastName = "Kounievic", BirthDate = new DateTime(1996, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s20 = new Student() { FirstName = "Kelli", LastName = "Arapi", BirthDate = new DateTime(1990, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s21 = new Student() { FirstName = "Elsa", LastName = "Ioannou", BirthDate = new DateTime(1993, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s22 = new Student() { FirstName = "Evridiki", LastName = "Miheli", BirthDate = new DateTime(1980, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s23 = new Student() { FirstName = "Mihalis", LastName = "Arpatzoglou", BirthDate = new DateTime(1987, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s24 = new Student() { FirstName = "Ilias", LastName = "Karampinas", BirthDate = new DateTime(1987, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s25 = new Student() { FirstName = "Fanis", LastName = "Lampropoulos", BirthDate = new DateTime(1988, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s26 = new Student() { FirstName = "Giota", LastName = "Strati", BirthDate = new DateTime(1989, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s27 = new Student() { FirstName = "Zoi", LastName = "Karoni", BirthDate = new DateTime(1990, 5, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s28 = new Student() { FirstName = "Ntaniela", LastName = "Kolia", BirthDate = new DateTime(1991, 3, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s29 = new Student() { FirstName = "Ifigenia", LastName = "Megalooikonomou", BirthDate = new DateTime(1983, 10, 4), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };
            Student s30 = new Student() { FirstName = "Niki", LastName = "Afaloniati", BirthDate = new DateTime(1990, 9, 7), TuitionFees = 2500, PhotoUrl = "https://icon-icons.com/icons2/1465/PNG/256/130manstudent2_100617.png" };

            // ~~~ SEEDING COURSES ~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Course c1 = new Course() { Title = "C# full time", Stream = "Entry level full stack developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 1), PhotoUrl = "https://cdn.iconscout.com/icon/free/png-256/c-36-555159.png" };
            Course c2 = new Course() { Title = "C# part time", Stream = "Entry level full stack developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 6, 1), PhotoUrl = "https://cdn.iconscout.com/icon/free/png-256/c-36-555159.png" };
            Course c3 = new Course() { Title = "Java full time", Stream = "Entry level full stack developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 1), PhotoUrl = "https://cdn.iconscout.com/icon/free/png-256/java-60-1174953.png" };
            Course c4 = new Course() { Title = "Java part time", Stream = "Entry level full stack developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 6, 1), PhotoUrl = "https://cdn.iconscout.com/icon/free/png-256/java-60-1174953.png" };
            Course c5 = new Course() { Title = "Javascript part time", Stream = "Entry level front-end developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 6, 1), PhotoUrl = "https://cdn.iconscout.com/icon/free/png-256/node-js-1174925.png" };



            // ~~~ RELATIONS courses with trainers ~~~~~~~~~~~
            c1.Trainers = new List<Trainer> { t1, t6 };
            c2.Trainers = new List<Trainer> { t2, t7 };
            c3.Trainers = new List<Trainer> { t3, t8 };
            c4.Trainers = new List<Trainer> { t4, t9 };
            c5.Trainers = new List<Trainer> { t5, t10 };

            //// ~~~ RELATIONS courses with assignmetns ~~~~~~~~
            c1.Assignments = new List<Assignment> { a1, a2, a3 };
            c2.Assignments = new List<Assignment> { a7, a8, a9 };
            c3.Assignments = new List<Assignment> { a4, a5, a6 };
            c4.Assignments = new List<Assignment> { a10, a11, a12 };
            c5.Assignments = new List<Assignment> { a13, a14, a15 };

            //// ~~~ RELATIONS assigments with studens ~~~~~~~~
            a1.Students = new List<Student> { s1, s2, s3, s4, s5, s6 };
            a2.Students = new List<Student> { s1, s2, s3, s4, s5, s6 };
            a3.Students = new List<Student> { s1, s2, s3, s4, s5, s6 };
            a4.Students = new List<Student> { s7, s8, s9, s10, s11, s12 };
            a5.Students = new List<Student> { s7, s8, s9, s10, s11, s12 };
            a6.Students = new List<Student> { s7, s8, s9, s10, s11, s12 };
            a7.Students = new List<Student> { s13, s14, s15, s16, s17, s18 };
            a8.Students = new List<Student> { s13, s14, s15, s16, s17, s18 };
            a9.Students = new List<Student> { s13, s14, s15, s16, s17, s18 };
            a10.Students = new List<Student> { s19, s20, s21, s22, s23, s24 };
            a11.Students = new List<Student> { s19, s20, s21, s22, s23, s24 };
            a12.Students = new List<Student> { s19, s20, s21, s22, s23, s24 };
            a13.Students = new List<Student> { s25, s26, s27, s28, s29, s30 };
            a14.Students = new List<Student> { s25, s26, s27, s28, s29, s30 };
            a15.Students = new List<Student> { s25, s26, s27, s28, s29, s30 };

            // ~~~ RELATIONS students with courses ~~~~~~~~~~~
            s1.Courses = new List<Course> { c1 };
            s2.Courses = new List<Course> { c1 };
            s3.Courses = new List<Course> { c1 };
            s4.Courses = new List<Course> { c1 };
            s5.Courses = new List<Course> { c1 };
            s6.Courses = new List<Course> { c1 };
            s7.Courses = new List<Course> { c3 };
            s8.Courses = new List<Course> { c3 };
            s9.Courses = new List<Course> { c3 };
            s10.Courses = new List<Course> { c3 };
            s11.Courses = new List<Course> { c3 };
            s12.Courses = new List<Course> { c3 };
            s13.Courses = new List<Course> { c2 };
            s14.Courses = new List<Course> { c2 };
            s15.Courses = new List<Course> { c2 };
            s16.Courses = new List<Course> { c2 };
            s17.Courses = new List<Course> { c2 };
            s18.Courses = new List<Course> { c2 };
            s19.Courses = new List<Course> { c4 };
            s20.Courses = new List<Course> { c4 };
            s21.Courses = new List<Course> { c4 };
            s22.Courses = new List<Course> { c4 };
            s23.Courses = new List<Course> { c4 };
            s24.Courses = new List<Course> { c4 };
            s25.Courses = new List<Course> { c5 };
            s26.Courses = new List<Course> { c5 };
            s27.Courses = new List<Course> { c5 };
            s28.Courses = new List<Course> { c5 };
            s29.Courses = new List<Course> { c5 };
            s30.Courses = new List<Course> { c5 };


            // ~~~ UPSERT TABLES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);

            #endregion
        }
    }
}
