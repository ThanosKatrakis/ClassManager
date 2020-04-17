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
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult TrainerTable(string sortOrder, string searchlastname, string searchfirstname, int? page)
        {
            ViewBag.CurrentFirstName = searchfirstname;
            ViewBag.CurrentLastName = searchlastname;

            ViewBag.FirstNameShort = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSort = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";

            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();

            // FILTERING
            if (!string.IsNullOrWhiteSpace(searchlastname))
            {
                trainers = trainers.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            }

            // SORTING
            switch (sortOrder)
            {
                case "FirstNameDesc": trainers = trainers.OrderByDescending(x => x.FirstName); break;
                case "LastNameAsc": trainers = trainers.OrderBy(x => x.LastName); break;
                case "LastNameDesc": trainers = trainers.OrderByDescending(x => x.LastName); break;
                default: trainers = trainers.OrderBy(x => x.FirstName); break;
            }

            // PAGINATION
            int pageSize = 4;
            int pageNuber = page ?? 1;


            return View(trainers.ToPagedList(pageNuber, pageSize));
        }

        // Get: Trainer Details
        public ActionResult TrainerDetails(int? id)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            trainerRepository.Dispose();
            return View(trainer);
        }
    }
}