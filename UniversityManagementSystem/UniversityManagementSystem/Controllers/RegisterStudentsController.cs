using System;
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

        public static List<int> CSE = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        public static List<int> EEE = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        public static List<int> BBA = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

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
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name");
            return View();
        }

        // POST: RegisterStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,StudentEmail,ContactNumber,CurrentDate,StudentAddress,DepartmentID")] RegisterStudent registerStudent)
        {
            //var departmentName = db.Depatments.Where(x => x.Id == registerStudent.DepartmentID).Select(x => x.Name).SingleOrDefault();
            //var registrationDate = registerStudent.CurrentDate.Year;


            if (ModelState.IsValid)
            {
                registerStudent.RegistrotionNo = CreateStudentRegistrationNO(registerStudent);
                //if ("CSE" == departmentName)
                //{
                //    registerStudent.RegistrotionNo = departmentName + registrationDate + CSE[0];
                //    CSE.RemoveAt(0);
                //}
                //else if ("BBA" == departmentName)
                //{
                //    registerStudent.RegistrotionNo = departmentName + registrationDate + BBA[0];
                //    CSE.RemoveAt(0);
                //}
                //else
                //{
                //    registerStudent.RegistrotionNo = departmentName + registrationDate + CSE[0];
                //    CSE.RemoveAt(0);
                //}
                    

                db.RegisterStudents.Add(registerStudent);
                db.SaveChanges();

                return RedirectToAction("Details", new { id =  registerStudent.Id});
            }

            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", registerStudent.DepartmentID);
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

        private string CreateStudentRegistrationNO(RegisterStudent registerStudent)
        {
            int id = db.RegisterStudents.Count(s => (s.DepartmentID == registerStudent.DepartmentID) && (s.CurrentDate.Year == registerStudent.CurrentDate.Year)) + 1;

            Department bDepartment = db.Depatments.Where(d => d.Id == registerStudent.DepartmentID).FirstOrDefault();
            string registrationId = bDepartment.Name + "-" + registerStudent.CurrentDate.Year + "-";
            string zero = "";
            int len = 3 - id.ToString().Length;
            for(int i = 0; i < len; i++)
            {
                zero = "0" + zero;
            }
            return registrationId + zero +id;
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
