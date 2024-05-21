using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Lop
    {
        public Guid LopId { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public Guid? CoVanHocTap { get; set; }
        public Guid? KhoaId { get; set; }
        public Guid? GiaoVienQuanLy { get; set; }
        public Guid? KhoaDaoTao { get; set; }
    }
}
