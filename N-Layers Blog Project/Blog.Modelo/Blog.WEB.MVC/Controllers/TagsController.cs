using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WEB.MVC.Controllers
{
    public class TagsController : Controller
    {
        private readonly string apiUrl = "https://localhost:5001/api/tags/";
        // GET: TagController
        public ActionResult Index()
        {
            var tags = API.Consumer.Crud<Modelo.Tag>.GetAll(apiUrl);
            return View(tags);
        }

        // GET: TagController/Details/5
        public ActionResult Details(int id)
        {
            var tag = API.Consumer.Crud<Modelo.Tag>.GetOne(apiUrl+id);
            return View(tag);
        }

        // GET: TagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelo.Tag tag)
        {
            try
            {
                API.Consumer.Crud<Modelo.Tag>.Insert(apiUrl, tag);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tag);
            }
        }

        // GET: TagController/Edit/5
        public ActionResult Edit(int id)
        {
            var tag = API.Consumer.Crud<Modelo.Tag>.GetOne(apiUrl+id);
            return View(tag);
        }

        // POST: TagController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelo.Tag tag)
        {
            try
            {
                API.Consumer.Crud<Modelo.Tag>.Update(apiUrl+id,tag);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tag);
            }
        }

        // GET: TagController/Delete/5
        public ActionResult Delete(int id)
        {
            var tag = API.Consumer.Crud<Modelo.Tag>.GetOne(apiUrl + id);
            return View();
        }

        // POST: TagController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Modelo.Tag tag)
        {
            try
            {
                API.Consumer.Crud<Modelo.Tag>.Delete(apiUrl+id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tag);
            }
        }
    }
}
