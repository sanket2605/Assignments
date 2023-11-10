using Microsoft.AspNetCore.Mvc;
using MVC_AuthorBook.Models;

namespace MVC_AuthorBook.Controllers
{
    public class BookController : Controller
    {
        private IBookRepos _BookRepos;
        public BookController(IBookRepos BookRepos)
        {
            _BookRepos = BookRepos;
        }
        // GET: BookController
        public ActionResult Index()
        {
            var model = _BookRepos.GetAllBook();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book obj)
        {
            try
            {
                var model = _BookRepos.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            var model = _BookRepos.GetBook(id);
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var model = _BookRepos.GetBook(id);
            return View(model);
        }
        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book emp)
        {
            try
            {
                var model = _BookRepos.Update(emp);
                return RedirectToAction(nameof(Index));
            }
            catch 
            { 
                return View(); 
            }

        }
        public ActionResult Delete(int id)
        {
            var model = _BookRepos.GetBook(id);
            return View(model);
        }
        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var model = _BookRepos.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
