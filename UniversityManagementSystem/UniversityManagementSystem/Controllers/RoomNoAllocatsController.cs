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
    public class RoomNoAllocatsController : Controller
    {
        private UniveristyContext db = new UniveristyContext();

        // GET: RoomNoAllocats
        public ActionResult Index()
        {
            var roomNoAllocates = db.RoomNoAllocates.Include(r => r.Department).Include(r => r.Room);
            return View(roomNoAllocates.ToList());
        }

        // GET: RoomNoAllocats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomNoAllocat roomNoAllocat = db.RoomNoAllocates.Find(id);
            if (roomNoAllocat == null)
            {
                return HttpNotFound();
            }
            return View(roomNoAllocat);
        }

        // GET: RoomNoAllocats/Create
        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "SaturDay", "SunDay", " MonDay", "TuesDay", "WesnesDay", "ThursDay", "FriDay" });
                     ViewBag.CategoryList = categoryList;
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name");
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomNumber");
            return View();
        }

        // POST: RoomNoAllocats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DepartmentID,CourseName,RoomId,DateOfSaven,Start,End")] RoomNoAllocat roomNoAllocat)
        {
            if (ModelState.IsValid)
            {
                roomNoAllocat.IsAssigned = true;
                db.RoomNoAllocates.Add(roomNoAllocat);
                db.SaveChanges();
            }

            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", roomNoAllocat.DepartmentID);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomNumber", roomNoAllocat.RoomId);
            return RedirectToAction("Index");
        }

        // GET: RoomNoAllocats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomNoAllocat roomNoAllocat = db.RoomNoAllocates.Find(id);
            if (roomNoAllocat == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", roomNoAllocat.DepartmentID);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomNumber", roomNoAllocat.RoomId);
            return View(roomNoAllocat);
        }

        // POST: RoomNoAllocats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DepartmentID,CourseName,RoomId,DateOfSaven,Start,End")] RoomNoAllocat roomNoAllocat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomNoAllocat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Depatments, "Id", "Name", roomNoAllocat.DepartmentID);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomNumber", roomNoAllocat.RoomId);
            return View(roomNoAllocat);
        }

        // GET: RoomNoAllocats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomNoAllocat roomNoAllocat = db.RoomNoAllocates.Find(id);
            if (roomNoAllocat == null)
            {
                return HttpNotFound();
            }
            return View(roomNoAllocat);
        }

        // POST: RoomNoAllocats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomNoAllocat roomNoAllocat = db.RoomNoAllocates.Find(id);
            db.RoomNoAllocates.Remove(roomNoAllocat);
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

        public ActionResult GetCouseCodeList(int id)
        {
            var list = db.Courses.Where(x => x.DepartmentID == id).Select(x => new { value = x.Id, Text = x.Name }).ToList();

            return Json(list);
        }

        [HttpPost]
        public void UnassignAllCourse()
        {
            db.RoomNoAllocates.ToList().ForEach(x =>
            {
                x.IsAssigned = false;
                db.Entry(x).State = EntityState.Modified;
            });
            db.SaveChanges();
        }

    }
}
