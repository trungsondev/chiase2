using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class TaiKhoan
    {
        public Guid TaiKhoanId { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public Guid? LoaiTaiKhoanId { get; set; }
        public Guid? KhachHangId { get; set; }
    }
}
