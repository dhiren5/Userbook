using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Userbook.Models;

namespace Userbook.Controllers
{
    public class UserbookController : Controller
    {
        private readonly DatabookContext _context;

       
        public UserbookController(DatabookContext context)
        {
            _context = context;
        }
        // GET: UserbookController
        public async Task<IActionResult> Index()
        {
            var users = await _context.Details.ToListAsync();
            return View(users);
        }

        // GET: UserbookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserbookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserbookController/Create
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

        // GET: UserbookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserbookController/Edit/5
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

        // GET: UserbookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserbookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
