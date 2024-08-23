using Microsoft.AspNetCore.Mvc;
using BLL.Services.CounterServices;
using DAL.ViewModels;
using System.Threading.Tasks;

namespace projectmvc.Controllers
{
    public class CounterController : Controller
    {
        private readonly ICounterServices _counterServices;

        public CounterController(ICounterServices counterServices)
        {
            _counterServices = counterServices;
        }

        // GET: Counter
        public async Task<IActionResult> Index()
        {
            ViewData["Message"] = TempData["Message"];
            var counters = await _counterServices.GetAll();
            return View(counters);
        }

        // GET: Counter/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var counter = await _counterServices.GetById(id);
            if (counter == null)
            {
                return NotFound();
            }
            return View(counter);
        }

        // GET: Counter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Counter/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CounterVM counterVM)
        {
            if (ModelState.IsValid)
            {
                await _counterServices.Create(counterVM);
                return RedirectToAction(nameof(Index));
            }
            return View(counterVM);
        }

        // GET: Counter/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var counter = await _counterServices.GetById(id);
            if (counter == null)
            {
                return NotFound();
            }
            return View(counter);
        }

        // POST: Counter/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CounterVM counterVM)
        {
            if (id != counterVM.CounterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _counterServices.Edit(counterVM);
                return RedirectToAction(nameof(Index));
            }
            return View(counterVM);
        }


        // GET: Counter/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var counter = await _counterServices.GetById(id);
            if (counter == null)
            {
                return NotFound();
            }

            return View(counter);
        }

        // POST: Counter/DeleteConfirmed
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(CounterVM counterVM)
        {
            if (counterVM == null)
            {
                return NotFound();
            }

            await _counterServices.Delete(counterVM);

            TempData["Message"] = "Counter deleted successfully.";
            return RedirectToAction(nameof(Index));
        }



       
    }
}

