using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Model.Models;
using Service.Pattern;
using Service.RequestForm;
using Service.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class SinhVienService:ISinhVienRepo
    {
        public QLDTContext _db;
        public IHttpClientFactory _factor;
        public IConfiguration _configuration;
        public SinhVienService(IHttpClientFactory factor, IConfiguration configuration, QLDTContext db)
        {
            this._factor = factor;
            this._configuration = configuration;
            this._db = db;
        }
        public async Task<DataTable> GetAllSinhVien()
        {
            SqlHelper dbo = new SqlHelper(_configuration["ConnectionStrings:QldtDB"]);
            var data = dbo.SqlExecuteDataSet("GetAll_SinhVien",new SqlParameter[] { }).Tables[0];
            return data;
        }
        public async Task<bool> ThemSinhVien(SinhVienVM form)
        {
            form.SinhVienId = Guid.NewGuid();
            SinhVien sv = new SinhVien()
            {
                SinhVienId= form.SinhVienId,
                MaSv = form.MaSv,
                HoTenSv = form.HoTenSv,
                NgaySinh = form.NgaySinh,
                GioiTinh = form.GioiTinh,
                DanToc = form.DanToc,
                NoiSinh = form.NoiSinh,
                LopId = form.LopId,
                Email = form.Email,
            };
            var result = await this._db.SinhViens.AddAsync(sv);
            if (result == null)
            {
                return false;
            }
            await this._db.SaveChangesAsync();
            return true;
        }



        public async Task<bool> SuaSinhVien(SinhVienVM form)
        {
            var data = this._db.SinhViens.Where(x => x.SinhVienId == form.SinhVienId).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            data.MaSv = form.MaSv;
            data.HoTenSv = form.HoTenSv;
            data.NgaySinh = form.NgaySinh;
            data.GioiTinh = form.GioiTinh;
            data.DanToc = form.DanToc;
            data.NoiSinh = form.NoiSinh;
            data.LopId = form.LopId;
            data.Email = form.Email;
            await this._db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> XoaSinhVien(string ID)
        {
            var data = this._db.SinhViens.Where(x => x.SinhVienId.ToString() == ID).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            this._db.Remove(data);
            await this._db.SaveChangesAsync();
            return true;
        }
        public async Task<SinhVien> GetOnly(string ID)
        {
            var data = this._db.SinhViens.Where(x => x.SinhVienId.ToString() == ID).SingleOrDefault();
            return data;
        }


        public async Task<bool> XoaSinhVienAPI(string ID)
        {
            var data = this._db.SinhViens.Where(x => x.SinhVienId.ToString() == ID).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            this._db.Remove(data);
            await this._db.SaveChangesAsync();
            return true;
        }


    }
}
