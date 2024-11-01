using DataTransferObject.DTOClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTicketAndReservationSystem.Models;
using Service.ServiceInterfaces;
using System.Diagnostics;

namespace OnlineTicketAndReservationSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IProvinceService _provinceService;

        public HomeController(ILogger<HomeController> logger, IUserService userService, IProvinceService provinceService)
        {
            _logger = logger;
            _userService = userService;
            _provinceService = provinceService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsers();
            return View(users);
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

        [Authorize]
        public IActionResult InsertProvince()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> InsertProvince([FromBody] ProvinceDTO province)
        {
            if (ModelState.IsValid)
            {
                var result = await _provinceService.CreateProvince(province);
                return Json(result);
            }
            return View();
        }
    }
}
