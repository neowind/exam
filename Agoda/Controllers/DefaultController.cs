using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Agoda.Models;

namespace Agoda.Controllers
{
    public class DefaultController : Controller
    {
        private HotelDBContext db = new HotelDBContext();

        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View(db.Hotels.ToList());
        }

        public ActionResult Ajax()
        {
            return View();
        }
    }
}
