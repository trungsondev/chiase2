using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestForm
{
    public class SinhVienVM
    {
        public Guid SinhVienId { get; set; }
        public string MaSv { get; set; }
        public string HoTenSv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string NoiSinh { get; set; }
        public Guid? LopId { get; set; }
        public string Email { get; set; }
    }
}
