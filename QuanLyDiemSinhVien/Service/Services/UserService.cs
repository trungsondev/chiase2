using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Model.Models;
using Newtonsoft.Json;
using Service.RequestForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService
    {
        public QLDTContext _db;
        public IHttpClientFactory _factor;
        public IConfiguration _configuration;
        public UserService(IHttpClientFactory factor, IConfiguration configuration, QLDTContext db)
        {
            this._factor = factor;
            this._configuration = configuration;
            this._db = db;
        }
        public async Task<TaiKhoan> GetInfo(LoginVM loGin)
        {
            var json = JsonConvert.SerializeObject(loGin);
            var contents = new StringContent(json, Encoding.UTF8, "application/json");
            var client = this._factor.CreateClient();
          
            client.BaseAddress = new Uri(this._configuration["Tokens:BaseAd"]);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loGin.TokenLogin);
            var result = await client.PostAsync("/api/login/get-userbyid", contents);
            var Datas = await result.Content.ReadAsStringAsync();
            var data = (TaiKhoan) JsonConvert.DeserializeObject(Datas);
            return data;

        }


        public async Task<TaiKhoan> GetInfoUserAPI(LoginVM loGin)
        {
            var data = _db.TaiKhoans.Where(x => x.TaiKhoanId.ToString() == loGin.TaiKhoan).FirstOrDefault();
            return data;

        }
    }
}
