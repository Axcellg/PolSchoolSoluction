using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PolSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudenController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
