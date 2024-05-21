using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class ChucDanh
    {
        public Guid ChucDanhId { get; set; }
        public string MaChucDanh { get; set; }
        public string TenChucDanh { get; set; }
    }
}
