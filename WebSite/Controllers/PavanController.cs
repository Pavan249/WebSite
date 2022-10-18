using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class PavanController : Controller
    {
        // GET: Pavan
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult LoginValidation(Paper v)
        {
            if (v.UserName == "pavan" && v.Password == "abc")
            {
                ViewBag.s = "Hai";
                ViewData["dev"] = "good Morning";
                Paper employee = new Paper()
                {
                    EmployeeId = 101,
                    EmployeeName = "Pavan kumar",
                    EmployeeCompany = "Span Technology",
                    EmployeePhoneNo = 9989786705,
                    EmployeeLocation = "Chennai"
                };
                return View ("Info", employee);
            }
            else
            {
                ViewBag.x = "Invalid Username and Password! Please Try again.";
                return View("Login");
            }
            
          
        }
        //public ActionResult Info()
        //{
        //    Paper employee = new Paper()
        //    {
        //        EmployeeId = 101,
        //        EmployeeName = "Pavan kumar",
        //        EmployeeCompany = "Span Technology",
        //        EmployeePhoneNo = 9989786705,
        //        EmployeeLocation = "Chennai"
        //    };
        //    return View(employee);
        //}
    }
}