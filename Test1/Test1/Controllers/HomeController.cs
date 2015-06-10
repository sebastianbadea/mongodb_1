using MongoDB.Driver;
using System.Web.Mvc;
using Test1.Properties;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        MongoDbContext _context;
        public HomeController()
        {
            _context = new MongoDbContext();
        }
        public ActionResult Index()
        {
            _context.Database.GetStats();
            return Json(_context.Database.Server.BuildInfo, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}