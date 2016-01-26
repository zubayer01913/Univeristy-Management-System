﻿using System;
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
        public ActionResult Index(CourseStatic model)
        {

            List<CourseStatic> courseStatic = new List<CourseStatic>();
            var list = from b in db.CourseAssigns
                       join a in db.Semesters on b.Id equals a.Id
                       select new
                       {
                           b.Id,
                           b.CouseCode,
                           b.CourseName,
                           b.TeacherName,
                           a.SemesterName,
                           

                       };
            foreach (var v in list)
            {
                CourseStatic cour = new CourseStatic();
                cour.Id = v.Id;
                cour.CourseCode = v.CouseCode;
                cour.Name = v.CourseName;
                cour.TeacherName = v.TeacherName;
                cour.SemesterName = v.SemesterName;

                courseStatic.Add(cour);

            }
            //Console.WriteLine(ids.Count);

            return View(courseStatic);
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

        [HttpPost]
        public ActionResult Create(CourseAssignTeacher model)
        {

            if (ModelState.IsValid)
            {
                db.CourseAssigns.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
           
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
            var list = db.Teachers.Where(x => x.DepartmentId == id).Select(x => new { value = x.Id, Text = x.TeacherName, credit = x.CreditToBeTaken }).ToList();

            return Json(list);
        }

        public ActionResult GetCouseCodeList(int id)
        {
            var list = db.Courses.Where(x => x.DepartmentID == id).Select(x => new { x.Id,x.CourseCode, x.Name, x.Credit }).ToList();

            return Json(list);
        }

  



// shehedule View
        public ActionResult Sehedule()
        {
            List<SeheduleRoom> sehedules = new List<SeheduleRoom>();
            var list = from d in db.Courses
                       join a in db.RoomNoAllocates on d.Id equals a.Id

                       select new
                       {
                           d.Id,
                           d.CourseCode,
                           d.Name,
                           a.Room,
                           a.CourseName,
                           a.Start,
                           a.End,
                       };
            foreach (var v in list)
            {
                SeheduleRoom sedule = new SeheduleRoom();
                sedule.Id = v.Id;
                sedule.CourseCode = v.CourseCode;
                sedule.Name = v.Name;
                //sedule.Room = v.Room;
                sedule.Start = v.Start;
                sedule.End = v.End;

                sehedules.Add(sedule);
            }

            return View(sehedules);

        }
    }
}
