using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class Khoa
    {
        public Guid KhoaId { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string Email { get; set; }
        public string Dt { get; set; }
    }
}
