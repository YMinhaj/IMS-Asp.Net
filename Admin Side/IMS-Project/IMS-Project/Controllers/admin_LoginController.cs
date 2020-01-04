using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_Project.Models;
using DBModel;

namespace IMS_Project.Controllers
{
    public class admin_LoginController : Controller
    {
        kahreedoEntities db = new kahreedoEntities();
        // GET: admin_Login
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Login(admin_Login login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var model = db.admin_Login.Where(x => x.UserName == login.UserName && x.Password == login.Password).ToArray();
                    if (model.Count() > 0)
                    {
                        var loginInfo = db.admin_Login.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

                        Session["username"] = loginInfo.UserName;
                        TemData.EmpID = loginInfo.EmpID;
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                catch(Exception ex)
                {

                }
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "admin_Login");
        }
    }
}