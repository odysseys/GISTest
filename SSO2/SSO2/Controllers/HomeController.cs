using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SSO2.Data;
using SSO2.Models;

namespace SSO2.Controllers
{
    public class HomeController : Controller
    {
        private readonly SSO2Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SSO2Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var item = await _context.Place.ToListAsync();
            ViewBag.DataItem = JsonConvert.SerializeObject(item, new JavaScriptDateTimeConverter());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
