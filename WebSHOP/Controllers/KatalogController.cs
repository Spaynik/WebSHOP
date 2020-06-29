using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSHOP.Models;

namespace WebSHOP.Controllers
{
    public class KatalogController : Controller
    {
        private readonly ApplicationContext _context;

        public KatalogController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produkts.ToListAsync());
        }
    }
}
