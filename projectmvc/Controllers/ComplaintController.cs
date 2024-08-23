using Microsoft.AspNetCore.Mvc;
using BLL.Services.ComplaintServices; // Assuming you have a service for Complaints
using DAL.ViewModels;
using System.Threading.Tasks;

namespace projectmvc.Controllers
{
    public class ComplaintController : Controller
    {
        private readonly IComplaintServices _complaintServices;

        public ComplaintController(IComplaintServices complaintServices)
        {
            _complaintServices = complaintServices;
        }

        // GET: Complaint
        public async Task<IActionResult> Index()
        {
            var complaints = await _complaintServices.GetAll();
            return View(complaints);
        }

        // GET: Complaint/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var complaint = await _complaintServices.GetById(id);
            if (complaint == null)
            {
                return NotFound();
            }
            return View(complaint);
        }

        // GET: Complaint/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Complaint/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComplaintVM complaintVM)
        {
            if (ModelState.IsValid)
            {
                await _complaintServices.Create(complaintVM);
                return RedirectToAction(nameof(Index));
            }
            return View(complaintVM);
        }

        // GET: Complaint/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var complaint = await _complaintServices.GetById(id);
            if (complaint == null)
            {
                return NotFound();
            }
            return View(complaint);
        }

        // POST: Complaint/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ComplaintVM complaintVM)
        {
            if (id != complaintVM.ComplaintId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _complaintServices.Edit(complaintVM);
                return RedirectToAction(nameof(Index));
            }
            return View(complaintVM);
        }
        // GET: Complaint/Delete/5
        public IActionResult Delete(int id)
        {
            var complaint = _complaintServices.GetById(id).Result; 
            if (complaint == null)
            {
                return NotFound();
            }

            return View(complaint);
        }

        // POST: Complaint/DeleteConfirmed
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(ComplaintVM complaintVM)
        {
            if (complaintVM == null)
            {
                return NotFound();
            }

            await _complaintServices.Delete(complaintVM);

            TempData["Message"] = "Complaint deleted successfully.";
            return RedirectToAction(nameof(Index));
        }





        

    }


}



