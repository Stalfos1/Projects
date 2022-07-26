using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WEB.MVC.Controllers
{
    public class EntradasController : Controller
    {
        private readonly string apiUrl = "https://localhost:5001/api/entradas/";
        // GET: EntradaController
        public ActionResult Index()
        {
            var tags = API.Consumer.Crud<Modelo.Entrada>.GetAll(apiUrl);
            return View(tags);
        }

        // GET: EntradaController/Details/5
        public ActionResult Details(int id)
        {
            var tag= API.Consumer.Crud<Modelo.Entrada>.GetOne(apiUrl + id);
            return View(tag);
        }

        // GET: EntradaController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: EntradaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelo.Entrada entrada)
        {
            try
            {
                API.Consumer.Crud<Modelo.Entrada>.Insert(apiUrl, entrada);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(entrada);
            }
        }

        // GET: EntradaController/Edit/5
        public ActionResult Edit(int id)
        {
            var tag = API.Consumer.Crud<Modelo.Entrada>.GetOne(apiUrl + id);
            return View(tag);
        }

        // POST: EntradaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelo.Entrada entrada)
        {
            try
            {
                API.Consumer.Crud<Modelo.Entrada>.Update(apiUrl + id, entrada);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(entrada);
            }
        }

        // GET: EntradaController/Delete/5
        public ActionResult Delete(int id)
        {
            var entrada = API.Consumer.Crud<Modelo.Entrada>.GetOne(apiUrl + id);
            return View();
        }

        // POST: EntradaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelo.Entrada entrada)
        {
            try
            {
                API.Consumer.Crud<Modelo.Entrada>.Delete(apiUrl + id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(entrada);
            }
        }
    }
}
