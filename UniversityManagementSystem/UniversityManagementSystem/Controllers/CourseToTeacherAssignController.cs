using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Controllers
{
    public class CourseToTeacherAssignController : Controller
    {
        private UniveristyContext db = new UniveristyContext();

        // GET: CourseToTeacherAssign
        public ActionResult Index()
        {
            return View();
        }

        // GET: CourseToTeacherAssign/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseToTeacherAssign/Create
        public ActionResult Assign()
        {
            ViewBag.Department = new SelectList(db.Depatments, "Id", "Name");

 

            return View();
        }

        // POST: CourseToTeacherAssign/Create
        [HttpPost]
        public ActionResult Assign(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseToTeacherAssign/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseToTeacherAssign/Edit/5
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

        // GET: CourseToTeacherAssign/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseToTeacherAssign/Delete/5
        [HttpPost]
        public ActionResult GetTeacherList(int id)
        {
            var list = db.Teachers.Where(x => x.DepartmentId == id).Select(x => new { value= x.Id, Text= x.TeacherName,credit= x.CreditToBeTaken}).ToList();         

            return Json(list);
        }
    }
}
