using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class KhoaDaoTao
    {
        public Guid KhoaDaoTaoId { get; set; }
        public string TenKhoaDt { get; set; }
        public int? NamTcdt { get; set; }
        public int? NamTddt { get; set; }
        public DateTime? NamDaoTao { get; set; }
        public Guid? NganhId { get; set; }
    }
}
