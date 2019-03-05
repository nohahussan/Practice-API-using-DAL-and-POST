using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApIPractice.Models;
using Newtonsoft.Json.Linq;



namespace ApIPractice.Controllers
{
    public class HomeController : Controller
    {

        UserInput userChoice = new UserInput();
        
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(UserInput userChoice)
        {
            if (ModelState.IsValid)
            {

                Session["UserInput"] = userChoice;

                return RedirectToAction("About");
            }
            else
            {
                UserInput obj = new UserInput();
                return View(obj);
            }
        }

        public ActionResult About()
        {
            UserInput objj = (UserInput)Session["UserInput"];
            string title = objj.Title;
            
            List<Post> list = new List<Post>();
            for (int i =0; i <10; i++)
            {
                Post obj = new Post();

                obj = DAL.GetPost(title, i);
                list.Add(obj);
                
            }
          
            

            return View(list);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
