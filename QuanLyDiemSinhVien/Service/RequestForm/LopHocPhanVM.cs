using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestForm
{
    public class LopHocPhanVM
    {
        public Guid LopHPID { get; set; }
        public string MaLopHp { get; set; }
        public string TenLopHp { get; set; }
        public Guid? GiangVienId { get; set; }
        public Guid? MonHocId { get; set; }
        public int? SoluongSv { get; set; }
        public Guid? HocKyId { get; set; }
    }
}
