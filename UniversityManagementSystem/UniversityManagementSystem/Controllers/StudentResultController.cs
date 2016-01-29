using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class StudentResultController : Controller
    {
        private UniveristyContext db = new UniveristyContext();
        // GET: StudentResult
        public ActionResult Index()
        {
            ViewBag.SelectGradLetter = new SelectList(new[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "D", "F" });
            ViewBag.RegistrationNumber = new SelectList(db.RegisterStudents, "Id", "RegistrotionNo");
            return View();
        }

        // GET: StudentResult/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentResult/Create
        public ActionResult Create()
        {
            ViewBag.SelectGradLetter = new SelectList(new[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "D", "F" });
            ViewBag.RegistrationNumber = new SelectList(db.RegisterStudents, "Id", "RegistrotionNo");
            ViewBag.CourseName = new SelectList(db.Courses, "Id", "Name");
            return View();
        }

        // POST: StudentResult/Create
        [HttpPost]
        public ActionResult Create(StudentResult model)
        {
            if (ModelState.IsValid)
            {
                db.StudentResults.Add(model);
                db.SaveChanges();
                return null;
            }

            return null;
        }

        // GET: StudentResult/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentResult/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentResult/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentResult/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult GetStudentList(int id)
        {
            //var departmentName = db.Depatments.Where(x => x.Id == RegisterStudents.DepartmentID).Select(x => x.Name).SingleOrDefault();

            var list = db.RegisterStudents.Where(x => x.Id == id).Select(x => new { x.Id, x.StudentName, x.StudentEmail, x.Department.Name }).ToList();

            return Json(list);
        }
    }
}
