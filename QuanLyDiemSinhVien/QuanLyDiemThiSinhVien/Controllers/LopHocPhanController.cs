using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Service.Pattern;
using Service.RequestForm;
using Service.Services;
using Service.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDiemThiSinhVien.Controllers
{
    [Authorize]
    public class LopHocPhanController : Controller
    {
        public ILopHocPhanRepo _service;
        public LopHocPhanController(ILopHocPhanRepo service)
        {
            
            this._service = service;
        }
        
        public IActionResult Index()
        {
            //if (User.Identity.Name == null) return Redirect("/login");
            var dataMH = this._service.GetAllMonHocID();
            var dataGV = this._service.GetAllGiangVienID();
            var dataHK = this._service.GetAllHocKyID();
            ViewData["DataMonHoc"] = dataMH;
            ViewData["DataGiangVien"] = dataGV;
            ViewData["DataHocKy"] = dataHK;
            return View();
        }
       
        public IActionResult GetAllLopHP()
        {
            //if (User.Identity.Name == null) return Redirect("/login");
            var data =  this._service.GetAllLopHocPhan();
            var json = JsonHelper.ToJson<DataTable>(data);
            return Ok(new { Result=json });
        }
   
        public async Task<IActionResult> NhanDuLieu(LopHocPhanVM data)
        {
            var check = await this._service.ThemLopHocPhan(data);
            return Redirect("/LopHocPhan");
        }
        public async Task<IActionResult> SuaDuLieu(LopHocPhanVM data)
        {
            var check = await this._service.SuaLopHocPhan(data);
            return Redirect("/LopHocPhan");
        }
        public async Task<IActionResult> GetOnlyLopHP(string ID)
        {
            var data =  await this._service.GetOnly(ID);
            return Ok(new { Result = data });
        }
    }
}
