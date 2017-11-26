using PDMS.DataManipulation;
using PDMS.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PDMS.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {   //  Show all projects

            Project p = new Project();
            p.GetRandom();
            //ViewBag.Panels = p.GetRandom();


            return View(p);
        }
    }
}