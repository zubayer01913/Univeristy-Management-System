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
    public class RegisterStudentsController : Controller
    {
        private UniveristyContext db = new UniveristyContext();

        // GET: RegisterStudents
        public ActionResult Index()
        {
            var registerStudents = db.RegisterStudents.Include(r => r.Department);
            return View(registerStudents.ToList());
        }

        // GET: RegisterStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerStudent = db.RegisterStudents.Find(id);
            if (registerStudent == null)
            {
                return HttpNotFound();
            }
            return View(registerStudent);
        }

        // GET: RegisterStudents/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Code");
            return View();
        }

        // POST: RegisterStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,StudentEmail,ContactNumber,CurrentDate,StudentAddress,DepartmentID")] RegisterStudent registerStudent)
        {
            if (ModelState.IsValid)
            {
                db.RegisterStudents.Add(registerStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Code", registerStudent.DepartmentID);
            return View(registerStudent);
        }

        // GET: RegisterStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerStudent = db.RegisterStudents.Find(id);
            if (registerStudent == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Code", registerStudent.DepartmentID);
            return View(registerStudent);
        }

        // POST: RegisterStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,StudentEmail,ContactNumber,CurrentDate,StudentAddress,DepartmentID")] RegisterStudent registerStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registerStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Code", registerStudent.DepartmentID);
            return View(registerStudent);
        }

        // GET: RegisterStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerStudent = db.RegisterStudents.Find(id);
            if (registerStudent == null)
            {
                return HttpNotFound();
            }
            return View(registerStudent);
        }

        // POST: RegisterStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisterStudent registerStudent = db.RegisterStudents.Find(id);
            db.RegisterStudents.Remove(registerStudent);
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
    }
}