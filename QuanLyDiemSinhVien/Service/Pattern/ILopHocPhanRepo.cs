using Model.Models;
using Service.RequestForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public interface ILopHocPhanRepo
    {
        List<MonHoc> GetAllMonHocID();
        List<GiangVien> GetAllGiangVienID();
        List<HocKy> GetAllHocKyID();
        DataTable GetAllLopHocPhan();
        Task<string> GetOnly(string ID);
        Task<bool> ThemLopHocPhan(LopHocPhanVM form);
        Task<bool> SuaLopHocPhan(LopHocPhanVM form);
        Task<bool> XoaLopHocPhan(string ID);
        Task<bool> XoaLopHocPhanAPI(string ID);
    }
}
