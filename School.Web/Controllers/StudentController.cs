using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using School.Database;
using School.Entities;
using School.Services;
using PagedList.Mvc;
using PagedList;

namespace School.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Students
        public ActionResult StudentTable(string sortOrder, string searchlastname, string searchfirstname, int? page)
        {
            ViewBag.CurrentFirstName = searchfirstname;
            ViewBag.CurrentLastName = searchlastname;

            ViewBag.FirstNameShort = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSort = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";

            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();

            // FILTERING
            if (!string.IsNullOrWhiteSpace(searchlastname))
            {
                students = students.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            }

            // SORTING
            switch (sortOrder)
            {
                case "FirstNameDesc": students = students.OrderByDescending(x => x.FirstName); break;
                case "LastNameAsc": students = students.OrderBy(x => x.LastName); break;
                case "LastNameDesc": students = students.OrderByDescending(x => x.LastName); break;
                default: students = students.OrderBy(x => x.FirstName); break;
            }

            // PAGINATION
            int pageSize = 4;
            int pageNuber = page ?? 1;


            return View(students.ToPagedList(pageNuber, pageSize));
        }

        // Get: Student Details
        public ActionResult StudentDetails(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            } 
            var student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            studentRepository.Dispose();
            return View(student);
        }
    }
}
