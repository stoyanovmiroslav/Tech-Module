namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        private LogNozirohDbContext db = new LogNozirohDbContext();
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var report = db.Reports.ToList();
            return View(report);
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var report = db.Reports.Find(id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Report());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Report report)
        {
            if (this.ModelState.IsValid)
            {
                db.Reports.Add(report);
                db.SaveChanges();
                return Redirect("/");
            }

            return View(report);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var report = db.Reports.Find(id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            var LogNozirohDbContext = db.Reports.Find(id);
            if (LogNozirohDbContext == null)
            {
                return HttpNotFound();
            }
            db.Reports.Remove(LogNozirohDbContext);
            db.SaveChanges();
            return Redirect("/");
        }
    }
}