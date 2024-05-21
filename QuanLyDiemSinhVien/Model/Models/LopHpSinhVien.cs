using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class LopHpSinhVien
    {
        public Guid LopHpLTid { get; set; }
        public Guid LopHpTHid { get; set; }
        public Guid LopHPSVID { get; set; }
        public Guid? SinhVienId { get; set; }
        public byte? LanHoc { get; set; }
        public decimal? DiemQT { get; set; }
        public decimal? DiemGK { get; set; }
        public decimal? DiemThi { get; set; }
        public decimal? DiemHP { get; set; }
        public decimal? DiemChu { get; set; }
        public decimal? HeSo4 { get; set; }
    }
}
