using System.Web.Mvc;

namespace CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult All() {
            return View();
        }
        public ActionResult DX() {
            return View();
        }
        public ActionResult Plain() {
            return View();
        }
        public ActionResult SeparateAction() {
            return Content("Content From Separate <b>Action</b> Here...");
        }
    }
}