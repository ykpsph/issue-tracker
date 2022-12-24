using AddingBootstrapTheme.Models;
using AddingBootstrapTheme.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddingBootstrapTheme.Controllers
{
    public class AccountController : Controller
    {
        // object of the context class.
        public PoliceStationContext db = new PoliceStationContext();


        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }



        // GET : Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (!ModelState.IsValid)
                return View("Register", user);
            // checking if the username already exist.
            if (db.Users.Where(u => u.Username == user.Username).Any())
            {
                ModelState.AddModelError("Username", "This username is already exit.");
                return View("Register", user);
            }

            db.Users.Add(user);
            db.SaveChanges();


            return Content("yehu");
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginFormViewModel user)
        {
            if (!ModelState.IsValid)
                return View("Login", user);

            var loginUser = db.Users.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if (loginUser == null)
            {
                ModelState.AddModelError("Username", "Username or Password is incorrect.");
            }
            else
            {
                Session["Username"] = loginUser.Username;
                return RedirectToAction("Index", "Police");
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}