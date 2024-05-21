using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Service.RequestForm;
using Service.Shared;
using System.Data;
using Service.Pattern;

namespace QuanLyDiemThiSinhVien.Controllers
{
    [Authorize]
    public class SinhVienController : Controller
    {
        public ISinhVienRepo _service;
        public SinhVienController(ISinhVienRepo serviceUser)
        {
            this._service = serviceUser;
        }
        public async Task<IActionResult> Index()
        {
            var result = await this._service.GetAllSinhVien();
            ViewData["Data"] = result;
            return View(result);
        }

        public async Task<IActionResult> Them(SinhVienVM data)
        {
            var check = await this._service.ThemSinhVien(data);
            return Redirect("/LopHocPhan");
        }
        public async Task<IActionResult> Sua(SinhVienVM data)
        {
            var check = await this._service.SuaSinhVien(data);
            return Redirect("/LopHocPhan");
        }
        public async Task<string> GetOnlySV(string ID)
        {
            var data = await this._service.GetOnly(ID);
            var json = JsonHelper.ToJson<SinhVien>(data);
            return json;
        }
    }
}
