using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogPlayDate.Controllers
{
    public class DogsController : Controller
    {
        // GET: Dogs
        public ActionResult Create()
        {
            return View();
        }
    }
}