using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class TheLoai
    {
        public Guid TheLoaiId { get; set; }
        public string TenTheLoai { get; set; }
        public string MaTheLoai { get; set; }
    }
}
