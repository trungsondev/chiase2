using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Model.Models;
using Service.Pattern;
using Service.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MonHocService: IMonHocRepo
    {
        public QLDTContext _db;
        public IHttpClientFactory _factor;
        public IConfiguration _configuration;
        public string _conn;
        public MonHocService(IHttpClientFactory factor, IConfiguration configuration, QLDTContext db)
        {
            this._factor = factor;
            this._configuration = configuration;
            this._db = db;
            this._conn = this._configuration["ConnectionStrings:QldtDB"];
        }
        public async Task<DataTable> GetAllMonHoc()
        {
            SqlHelper dbo = new SqlHelper(this._conn);
            var data = dbo.SqlExecuteDataSet("GetAll_MonHoc", new SqlParameter[] { }).Tables[0];
            return data;
        }

    }
}
