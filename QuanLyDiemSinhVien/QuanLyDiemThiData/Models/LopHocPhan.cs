using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class LopHocPhan
    {
        public Guid LopHpid { get; set; }
        public string MaLopHp { get; set; }
        public string TenLopHp { get; set; }
        public Guid? GiangVienId { get; set; }
        public Guid? MonHocId { get; set; }
        public int? SoluongSv { get; set; }
        public Guid? HocKyId { get; set; }
    }
}
