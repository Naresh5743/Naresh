using Microsoft.AspNetCore.Mvc;
using EPassport.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Passport.Controllers
{
    public class PassportOfficeController : Controller
    {
        private readonly EPassportContext _context;

        public PassportOfficeController(EPassportContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.PassportOffices.ToListAsync());
        }

        [HttpGet]
        public IActionResult AddOffice()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddOffice([Bind("OfficeId,OfficeName,Jurisdiction,Address,PhoneNumber")] PassportOffice passportOffice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passportOffice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passportOffice);
        }
    }
}
