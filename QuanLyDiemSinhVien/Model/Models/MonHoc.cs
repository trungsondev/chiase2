using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class MonHoc
    {
        public Guid MonHocId { get; set; }
        public string TenMonHoc { get; set; }
        public int? Tclt { get; set; }
        public int? Tcth { get; set; }
        public Guid? TheLoaiId { get; set; }
        public Guid? KhoaId { get; set; }
    }
}
