using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Model.Token;
using Service.RequestForm;
using Service.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemThiSinhVien.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _services;
        private readonly IConfiguration _config;

        public LoginController(LoginService services, IConfiguration _config)
        {
            this._services = services;
            this._config = _config;
        }
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> DangNhap(LoginVM login)
        {
            var token = await this._services.XacNhan(login);
            if (string.IsNullOrEmpty(token))
            {
                return Redirect("/login");
            }
            else
            {
                HttpContext.Session.SetString("Token", token);
            }
            var usePrincipal= ValidateToken(token);
            var authPro = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.Now.AddMinutes(1),
                IsPersistent = false

            };
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
            usePrincipal, authPro);
            return Redirect("/");
        }
        private ClaimsPrincipal ValidateToken(string jwt)
        {
            IdentityModelEventSource.ShowPII = true;
            SecurityToken validateToken;
            TokenValidationParameters validationParam = new TokenValidationParameters();
            validationParam.ValidateLifetime = true;
            validationParam.ValidAudience = _config["Tokens:Issuer"];
            validationParam.ValidIssuer = _config["Tokens:Issuer"];
            validationParam.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwt, validationParam, out validateToken);
            return principal;

        }
    }
}
