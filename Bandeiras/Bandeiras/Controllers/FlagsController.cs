using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bandeiras.Controllers
{
    public class FlagsController : Controller
    {
        // GET: Bandeira
        public ActionResult Index()
        {
            string param1 = this.Request.QueryString["idxF"];
            return View();
        }

        public ActionResult GetImage(string id)
        {
            var dir = Server.MapPath("/Images");
            var path = Path.Combine(dir, id + ".jpg");
            return base.File(path, "image/jpeg");
        }
    }
}