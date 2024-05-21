using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDiemThiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SinhVienController : ControllerBase
    {
        public SinhVienService _service;
        public SinhVienController(SinhVienService serviceUser)
        {
            this._service = serviceUser;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            var result = await this._service.GetAllSinhVien();
            return Ok(new { 
                data= result
            });
        }
    }
}
