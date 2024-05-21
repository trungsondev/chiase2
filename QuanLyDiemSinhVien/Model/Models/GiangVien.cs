using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class GiangVien
    {
        public Guid GiangVienId { get; set; }
        public string HoTenGv { get; set; }
        public string MaGv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public Guid? ChucDanhId { get; set; }
        public string KhoaId { get; set; }
    }
}
