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
    public interface ISinhVienRepo
    {
        Task<DataTable> GetAllSinhVien();
        Task<bool> ThemSinhVien(SinhVienVM form);
        Task<bool> SuaSinhVien(SinhVienVM form);
        Task<bool> XoaSinhVien(string ID);
        Task<SinhVien> GetOnly(string ID);
        Task<bool> XoaSinhVienAPI(string ID);
    }
}
