using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class LopHpSinhVien
    {
        public Guid? SinhVienId { get; set; }
        public Guid? LopHpid { get; set; }
        public byte? LanHoc { get; set; }
    }
}
