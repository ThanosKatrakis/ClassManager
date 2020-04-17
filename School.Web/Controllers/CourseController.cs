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
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult CourseTable(string sortOrder, string searchTitle, int? page)
        {
            ViewBag.CurrentTitle = searchTitle;
            ViewBag.TitleShort = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();

            // FILTERING
            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                courses = courses.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }

            // SORTING
            switch (sortOrder)
            {
                case "TitleDesc": courses = courses.OrderByDescending(x => x.Title); break;
                default: courses = courses.OrderBy(x => x.Title); break;
            }

            // PAGINATION
            int pageSize = 4;
            int pageNuber = page ?? 1;


            return View(courses.ToPagedList(pageNuber, pageSize));
        }

        // Get: Course Details
        public ActionResult CourseDetails(int? id)
        {
            CourseRepository courseRepository = new CourseRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            courseRepository.Dispose();
            return View(course);
        }
    }
}
