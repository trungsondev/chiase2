using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class LoaiTaiKhoan
    {
        public Guid LoaiTaiKhoanId { get; set; }
        public string TenLoaiTaiKhoan { get; set; }
        public string MaLoaiTaiKhoan { get; set; }
    }
}
