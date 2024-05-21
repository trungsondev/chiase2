using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.RequestForm;
using Microsoft.AspNetCore.Cors;
using System.Security.Claims;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Model.Token;

namespace QuanLyDiemThiAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class LoginController : Controller
    {
        public QLDTContext _db;
        public LoginService _service;
        public UserService _serviceUser;
        public LoginController(UserService serviceUser)
        {
            this._serviceUser = serviceUser;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }

        [Route("dang-nhap")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> DangNhap(LoginVM request)
        {
            this._service = new LoginService();
            var result = await this._service.DangNhap(request);
            if (string.IsNullOrEmpty(result))
            {
                return BadRequest("Tài khoản hoặc mật khẩu không đúng");

            }
            return Ok(result);
        }

        [Route("get-userbyid")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GetUserByID(LoginVM request)
        {
            var result = await this._serviceUser.GetInfoUserAPI(request);
            if (result==null)
            {
                return BadRequest("Tài khoản hoặc mật khẩu không đúng");
            }
            return Ok(result);
        }

    }
}
