using FundRaisers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FundRaisers.Models;
using Microsoft.AspNetCore.Authorization;

namespace FundRaisers.Controllers
{
    [Authorize (Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly FundRaisersDbContext _context;

        public AdminController(FundRaisersDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> DonorIndex()
        {
            return _context.Donors != null ?
                        View(await _context.Donors.ToListAsync()) :
                        Problem("Entity set 'FundRaisersDbContext.Donors'  is null.");
        }
		public async Task<IActionResult> Donor()
		{
			return _context.Donors != null ?
						View(await _context.Donors.ToListAsync()) :
						Problem("Entity set 'FundRaisersDbContext.Donors'  is null.");
		}

		public async Task<IActionResult> EventIndex()
        {
            return _context.Events != null ?
                        View(await _context.Events.ToListAsync()) :
                        Problem("Entity set 'FundRaisersDbContext.Events'  is null.");
        }
		public async Task<IActionResult> Receiver()
		{
			return _context.Events != null ?
						View(await _context.Events.ToListAsync()) :
						Problem("Entity set 'FundRaisersDbContext.Events'  is null.");
		}


		// GET: Donors/Details/5
		public  IActionResult Index()
        {
            return View();
        }


        
    }
}
