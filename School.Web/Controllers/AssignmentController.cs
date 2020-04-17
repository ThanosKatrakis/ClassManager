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
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult AssignmentTable(string sortOrder, string searchTitle, int? page)
        {
            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentSort = sortOrder;

            ViewBag.TitleShort = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";

            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignments = assignmentRepository.GetAll();

            // FILTERING
            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                assignments = assignments.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }

            // SORTING
            switch (sortOrder)
            {
                case "TitleDesc": assignments = assignments.OrderByDescending(x => x.Title); break;
                default: assignments = assignments.OrderBy(x => x.Title); break;
            }

            // PAGINATION
            int pageSize = 4;
            int pageNuber = page ?? 1; 

            return View(assignments.ToPagedList(pageNuber, pageSize));
        }

        // Get: Assignment Details
        public ActionResult AssignmentDetails(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var assignment = assignmentRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            assignmentRepository.Dispose();
            return View(assignment);
        }
    }
}
