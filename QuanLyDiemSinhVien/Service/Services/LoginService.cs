using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.Models;
using Newtonsoft.Json;
using Service.RequestForm;

namespace Service.Services
{
    
    public class LoginService
    {
        public QLDTContext _db = new QLDTContext();

        public  IConfiguration _configuration;
        public IHttpClientFactory _factor;

        public LoginService(IHttpClientFactory factor)
        {
            this._factor = factor;
        }
        public LoginService()
        {
        }
        public async Task<string> DangNhap(LoginVM loGin)
        {
            var user = _db.TaiKhoans.Where<TaiKhoan>(x=>x.TenTaiKhoan== loGin.TaiKhoan && x.MatKhau== loGin.MatKhau).SingleOrDefault();
            if (user == null) { return null; }
            var tokenKey = Model.Token.TokenSecrect.KeyToken;
            var issuer = Model.Token.TokenSecrect.Issuer;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.Name,user.TenTaiKhoan),
                new Claim("UserID",user.TaiKhoanId.ToString()),
                new Claim(ClaimTypes.Role,user.LoaiTaiKhoanId.ToString()),
            };
            var token = new JwtSecurityToken(issuer, issuer,
                claim,
                expires:DateTime.Now.AddMinutes(1),
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<List<TaiKhoan>> GetAllUser()
        {
            var user = _db.TaiKhoans.ToList();
            return user;
        }

        public async Task<string> XacNhan(LoginVM loGin)
        {
            var json = JsonConvert.SerializeObject(loGin);
            var contents = new StringContent(json, Encoding.UTF8, "application/json");
            var client=this._factor.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44380");
            var result =await client.PostAsync("/api/login/dang-nhap", contents);
            var token = await result.Content.ReadAsStringAsync();
            return token;

        }

        
    }
}
