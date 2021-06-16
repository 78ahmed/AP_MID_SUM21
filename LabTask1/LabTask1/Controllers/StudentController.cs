using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask1.Models;
using LabTask1.Models.Database;

namespace LabTask1.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            Database db = new Database();
            var students=db.Students.GetAll();
            return View(students);
        }
        public ActionResult Login()
        {
            Admin a = new Admin();
            return View(a);
        }
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            //return View(a);
            return RedirectToAction("Dashboard");
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult CreateS()
        {
            Student s = new Student();
            return View(s);
        }
        [HttpPost]
        public ActionResult CreateS(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var s = db.Students.Get(id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {   
            Database db = new Database();
            db.Students.Update(s);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("Index");
        }

    }
}