using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class XepLoai
    {
        public Guid XepLoaiId { get; set; }
        public string MaXepLoai { get; set; }
        public string TenXepLoai { get; set; }
        public decimal? DiemBd { get; set; }
        public decimal? DiemKetThuc { get; set; }
    }
}
