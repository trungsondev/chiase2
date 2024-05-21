using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class MonHoc
    {
        public Guid MonHocId { get; set; }
        public string TenMonHoc { get; set; }
        public Guid? Tclt { get; set; }
        public Guid? Tcth { get; set; }
        public Guid? TheLoaiId { get; set; }
        public Guid? KhoaId { get; set; }
        public Guid? NganhId { get; set; }
    }
}
