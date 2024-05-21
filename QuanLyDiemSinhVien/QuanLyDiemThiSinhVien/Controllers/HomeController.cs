using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QuanLyDiemThiSinhVien.Models;
using Service.RequestForm;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuanLyDiemThiSinhVien.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserService _services;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger,UserService services, IConfiguration config)
        {
            _logger = logger;
            this._services = services;
            this._config = config;
        }

        public async Task<IActionResult> Index()
        {
            var ID = ((ClaimsIdentity)User.Identity).FindFirst("UserID").Value.ToString();
            var token = HttpContext.Session.GetString("Token");
            var login = new LoginVM() {
                TaiKhoan = ID.ToString(),
                TokenLogin= token
            };

            var data = await this._services.GetInfo(login);
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
