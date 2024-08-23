using Microsoft.AspNetCore.Mvc;
using BLL.Services.CustomerServices; // Adjust the namespace if different
using DAL.ViewModels;
using System.Threading.Tasks;

namespace projectmvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customers = await _customerServices.GetAll();
            return View(customers);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var customer = await _customerServices.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerVM customerVM)
        {
            if (ModelState.IsValid)
            {
                await _customerServices.Create(customerVM);
                return RedirectToAction(nameof(Index));
            }
            return View(customerVM);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _customerServices.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CustomerVM customerVM)
        {
            if (id != customerVM.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _customerServices.Edit(customerVM);
                return RedirectToAction(nameof(Index));
            }
            return View(customerVM);
        }

        

            // GET: Customer/Delete/5
            public async Task<IActionResult> Delete(int id)
            {
                var customer = await _customerServices.GetById(id);
                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }

            // POST: Customer/DeleteConfirmed
            [HttpPost]
            [ActionName("DeleteConfirmed")]
            public async Task<IActionResult> DeleteConfirmed(CustomerVM customerVM)
            {
                if (customerVM == null)
                {
                    return NotFound();
                }

                await _customerServices.Delete(customerVM);

                TempData["Message"] = "Customer deleted successfully.";
                return RedirectToAction(nameof(Index));
            }

            // Other actions like Index, Create, Edit, etc.
        }


    }

