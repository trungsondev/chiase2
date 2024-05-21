using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class HocKy
    {
        public Guid HocKyId { get; set; }
        public string MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public Guid? NamHocId { get; set; }
    }
}
