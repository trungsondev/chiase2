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
    public class LopHocPhanService: ILopHocPhanRepo
    {
        public QLDTContext _db;
        public IHttpClientFactory _factor;
        public IConfiguration _configuration;
        public string _conn;
        public LopHocPhanService(IHttpClientFactory factor, IConfiguration configuration, QLDTContext db)
        {
            this._factor = factor;
            this._configuration = configuration;
            this._db = db;
            this._conn = this._configuration["ConnectionStrings:QldtDB"];
        }
        public List<MonHoc> GetAllMonHocID()
        {
            var data = this._db.MonHocs.ToList();
            return data;
        }
        public List<GiangVien> GetAllGiangVienID()
        {
            var data = this._db.GiangViens.ToList();
            return data;
        }
        public List<HocKy> GetAllHocKyID()
        {
            var data = this._db.HocKies.ToList();
            return data;
        }
        public DataTable GetAllLopHocPhan()
        {
            SqlHelper dbo = new SqlHelper(this._conn);
            var data = dbo.SqlExecuteDataSet("GetAll_LopHocPhan", new SqlParameter[] { }).Tables[0];
            return data;
        }
        public async Task<string> GetOnly(string ID)
        {
            var data = _db.LopHocPhans.Where(x => x.LopHPID.ToString().ToLower() == ID.ToLower()).SingleOrDefault();
            var json=JsonHelper.ToJson<LopHocPhan>(data);
            return json;
        }
        public async Task<bool> ThemLopHocPhan(LopHocPhanVM form)
        {
            LopHocPhan sv = new LopHocPhan()
            {
                LopHPID=Guid.NewGuid(),
                GiangVienId = form.GiangVienId,
                TenLopHp=form.TenLopHp,
                MaLopHp=form.MaLopHp,
                MonHocId=form.MonHocId,
                SoluongSv=form.SoluongSv,
                HocKyId=form.HocKyId
            };
            var result = await this._db.LopHocPhans.AddAsync(sv);
            if (result == null)
            {
                return false;
            }
            await this._db.SaveChangesAsync();
            return true;
        }



        public async Task<bool> SuaLopHocPhan(LopHocPhanVM form)
        {
            var data = this._db.LopHocPhans.Where(x => x.LopHPID == form.LopHPID).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            data.GiangVienId = form.GiangVienId;
            data.TenLopHp = form.TenLopHp;
            data.MaLopHp = form.MaLopHp;
            data.MonHocId = form.MonHocId;
            data.SoluongSv = form.SoluongSv;
            data.HocKyId = form.HocKyId;
            await this._db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> XoaLopHocPhan(string ID)
        {
            var data = this._db.LopHocPhans.Where(x => x.LopHPID.ToString() == ID).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            this._db.Remove(data);
            await this._db.SaveChangesAsync();
            return true;
        }


        public async Task<bool> XoaLopHocPhanAPI(string ID)
        {
            var data = this._db.LopHocPhans.Where(x => x.LopHPID.ToString() == ID).SingleOrDefault();
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
