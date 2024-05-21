using Microsoft.AspNetCore.Identity;
using Model.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Service.RequestForm
{
    public class LoginVM: Tokens
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool GhiNho { get; set; }
    }
}
