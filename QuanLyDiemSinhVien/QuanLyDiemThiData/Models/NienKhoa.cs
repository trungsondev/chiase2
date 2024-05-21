using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class NienKhoa
    {
        public Guid NienKhoaId { get; set; }
        public string MaNienKhoa { get; set; }
        public string TenNienKhoa { get; set; }
    }
}
