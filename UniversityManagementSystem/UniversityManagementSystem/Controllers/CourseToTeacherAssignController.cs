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

            List<CourseStatic> bids = new List<CourseStatic>();
            var list = from b in db.Courses
                       join a in db.Semesters on b.SemesterID equals a.Id
                       select new
                       {
                           a.Id,
                           b.CourseCode,
                           b.Name,
                           a.SemesterName,
                          
                       };
            foreach (var v in list)
            {
                CourseStatic cour = new CourseStatic();
                cour.Id = v.Id;
                cour.CourseCode = v.CourseCode;
                cour.Name = v.Name;
                cour.SemesterName = v.SemesterName;

                bids.Add(cour);

            }
            Console.WriteLine(bids.Count);

            return View(bids);
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

        public ActionResult GetCouseCodeList(int id)
        {
            var list = db.Courses.Where(x => x.DepartmentID == id).Select(x => new { value = x.Id, Text = x.CourseCode,Name= x.Name,creditNo=x.Credit }).ToList();

            return Json(list);
        }

        //public ActionResult GetCouseNameList(int id)
        //{
        //    var list = db.Courses.Where(x => x.Id == id).Select(x => new { value = x.Id, Text = x.Name }).ToList();

        //    return Json(list);
        //}

        //public ActionResult GetCouseCreditList(int id)
        //{
        //    var list = db.Courses.Where(x => x.Id == id).Select(x => new { value = x.Id, Text = x.Credit }).ToList();

        //    return Json(list);
        //}
    }
}
