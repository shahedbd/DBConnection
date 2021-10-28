using DBConnection.Data;
using DBConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace DBConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = AddCompanyInfo();
            var GetAllCompanyInfo = _context.CompanyInfo.ToList();
            return View();
        }



        private CompanyInfo AddCompanyInfo()
        {
            CompanyInfo _CompanyInfo = new CompanyInfo
            {
                Name = "Google",
                Address = "USA",
                Email = "infogoogle@gmail.com"
            };

            _context.Add(_CompanyInfo);
            _context.SaveChanges();

            return _CompanyInfo;
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
