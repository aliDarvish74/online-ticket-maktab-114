using Microsoft.AspNetCore.Mvc;
using OnlineTicketAndReservationSystem.Models;
using Service.ServiceInterfaces;
using System.Diagnostics;

namespace OnlineTicketAndReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRoleService _roleService;

        public HomeController(ILogger<HomeController> logger, IRoleService roleService)
        {
            _logger = logger;
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            _roleService.CreateRole(new DataTransferObject.DTOClasses.RoleDTO());
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
