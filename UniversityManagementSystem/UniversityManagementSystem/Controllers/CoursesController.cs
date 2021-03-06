﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class CoursesController : Controller
    {
        private UniveristyContext db = new UniveristyContext();

        // GET: Courses
        public ActionResult Index()
        {
            var courses = db.Courses.Include(c => c.Department).Include(c => c.Semester);
            return View(courses.ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name");
            ViewBag.SemesterID = new SelectList(db.Semesters, "Id", "SemesterName");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,CourseCode,Credit,Descriptio,DepartmentID,SemesterID")] Course course)
        {
            if (ModelState.IsValid)
            {
                course.IsAssigned = true;
                db.Courses.Add(course);
                db.SaveChanges();
                ViewBag.Msg = "Course Saved Succesfully!";
            }

            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", course.DepartmentID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "Id", "SemesterName", course.SemesterID);
            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", course.DepartmentID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "Id", "SemesterName", course.SemesterID);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,CourseCode,Credit,Descriptio,DepartmentID,SemesterID")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", course.DepartmentID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "Id", "SemesterName", course.SemesterID);
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpPost]
        public JsonResult DoesCourseCodeExist(string CourseCode)
        {
            return Json((!db.Courses.Any(x => x.CourseCode == CourseCode)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DoesCourseNameExist(string Name)
        {
            return Json((!db.Courses.Any(x => x.Name == Name)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void UnassignAllCourse()
        {
            db.Courses.ToList().ForEach(x => {
                x.IsAssigned = false;
                db.Entry(x).State = EntityState.Modified;
            });
            db.SaveChanges();
        }
    }
}
