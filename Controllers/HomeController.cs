using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MVC_BasedFoodOrderingSystem.Models;
using System.Data.Entity;

namespace MVC_BasedFoodOrderingSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Dish()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Order()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(TblContact tblContact)
        {

            using(FoodDataEntities db=new FoodDataEntities())
            {
                if(ModelState.IsValid)
                {
                    db.TblContacts.Add(tblContact);
                    db.SaveChanges();
                    ViewBag.message = "Feedback Send Successfully";
                    ModelState.Clear();
                }
            }
            return View(tblContact);
        }
        [HttpPost]
        public ActionResult Registration(TblRegister tblRegister)
        {
            using (FoodDataEntities db = new FoodDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblRegisters.Add(tblRegister);
                    db.SaveChanges();
                    ViewBag.message = "Registration Successfully";
                    ModelState.Clear();
                }
            }
            return View(tblRegister);
        }
        [HttpPost]
        public ActionResult Order(TblRequest tblRequest)
        {
            using (FoodDataEntities db = new FoodDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblRequests.Add(tblRequest);
                    db.SaveChanges();
                    ViewBag.message = "Request  Successfully";
                    ModelState.Clear();
                }
            }
            return View(tblRequest);
        }
        [HttpPost]
        public ActionResult Login(TblRegister tblRegister)
        {
            using (FoodDataEntities db = new FoodDataEntities())
            {
                if (ModelState.IsValid)
                {
                    RedirectToAction("Order");
                    ModelState.Clear();
                }
            }

            return View(tblRegister);
        }

    }
}