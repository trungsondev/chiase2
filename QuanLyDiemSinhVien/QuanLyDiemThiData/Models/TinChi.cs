using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class TinChi
    {
        public Guid TinChiId { get; set; }
        public string MaTinhChi { get; set; }
        public byte? SoTinhChi { get; set; }
        public bool? LoaiTinhChi { get; set; }
    }
}
