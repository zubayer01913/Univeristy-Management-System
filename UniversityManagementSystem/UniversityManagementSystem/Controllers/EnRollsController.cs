using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class EnRollsController : Controller
    {
        private UniveristyContext db = new UniveristyContext();

        // GET: EnRolls
        public ActionResult Index()
        {
            return View();
        }

        // GET: EnRolls/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Enroll()
        {

            //  ViewBag.RegistrationNumber = new SelectList(db.RegisterStudents, "Id", "RegistrotionNo");
            return View();
        }

        // GET: EnRolls/Create
        public ActionResult Create()
        {

            ViewBag.RegistrationNumber = new SelectList(db.RegisterStudents, "Id", "RegistrotionNo");
            ViewBag.CourseName = new SelectList(db.Courses, "Id", "Name");
            return View();
        }

        // POST: EnRolls/Create
        [HttpPost]
        public ActionResult Create(EnrollCourse model)
        {
            if (ModelState.IsValid)
            {

                db.EnrollCourses.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
                
            }

            return View(model);
        }

        // GET: EnRolls/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnRolls/Edit/5
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

        // GET: EnRolls/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnRolls/Delete/5
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
