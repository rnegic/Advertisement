using Advertisement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly Repository _repository = new Repository();

        public AdvertisementController(IRepository repository)
        {
            _repository = (Repository)repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAllOrders());
        }

        public IActionResult Create()
        {
            return View("Order", new Order());
        }
        public IActionResult Edit(int id)
        {
            var order = _repository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View("Order", order);
        }

        [HttpPost]
        public IActionResult Order(Order order)
        {
            if (!ModelState.IsValid) return View(order);

            if (order.Id == 0)
            {
                _repository.AddOrder(order);
            }
            else
            {
                _repository.UpdateOrder(order);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Order(int? id)
        {
            var order = id == null ? new Order() : _repository.GetOrderById(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: AdvertisementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: AdvertisementController/Create
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

        // POST: AdvertisementController/Edit/5
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

        // GET: AdvertisementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvertisementController/Delete/5
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
