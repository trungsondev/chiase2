﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public interface IMonHocRepo
    {
        Task<DataTable> GetAllMonHoc();
    }
}
