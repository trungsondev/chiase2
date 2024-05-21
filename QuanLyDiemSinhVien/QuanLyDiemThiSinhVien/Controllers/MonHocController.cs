using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Service.Pattern;

namespace QuanLyDiemThiSinhVien.Controllers
{
    [Authorize]
    public class MonHocController : Controller
    {
        public IMonHocRepo _service;
        public MonHocController(IMonHocRepo service)
        {
            this._service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await this._service.GetAllMonHoc();
            ViewData["Data"] = data;
            return View(data);
        }
    }
}
