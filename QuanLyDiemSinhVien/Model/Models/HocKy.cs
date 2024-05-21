using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class HocKy
    {
        public Guid HocKyId { get; set; }
        public string MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public int? NamHoc { get; set; }
    }
}
