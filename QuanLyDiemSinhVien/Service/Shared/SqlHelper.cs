using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Shared
{
    public class SqlHelper
    {
        public string _conn = "";
        public SqlHelper(string conn)
        {
            this._conn = conn;
        }
        public  DataSet SqlExecuteDataSet(string ProcName, SqlParameter[] prm)
        {
            using (SqlConnection connecttion = new SqlConnection(this._conn))
            {
                connecttion.Open();
                SqlCommand cmd = new SqlCommand(ProcName, connecttion);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter pr in prm)
                {
                    cmd.Parameters.Add(pr);
                }
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                return ds;
            }
        }


        public string SqlExecuteOnLyOne(string ProcName, SqlParameter[] prm)
        {
            using (SqlConnection connecttion = new SqlConnection(this._conn))
            {
                connecttion.Open();
                SqlCommand cmd = new SqlCommand(ProcName, connecttion);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter pr in prm)
                {
                    cmd.Parameters.Add(pr);
                }
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                string simpleValue = "";
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    simpleValue = reader.GetString(0);
                }
                //adapter.Fill(ds);
                return simpleValue;
            }
        }


        public void SqlExecuteNone(string ProcName, SqlParameter[] prm)
        {
            using (SqlConnection connecttion = new SqlConnection(this._conn))
            {
                connecttion.Open();
                SqlCommand cmd = new SqlCommand(ProcName, connecttion);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter pr in prm)
                {
                    cmd.Parameters.Add(pr);
                }
                cmd.ExecuteNonQuery();
                //DataSet ds = new DataSet();
                //SqlDataAdapter adapter = new SqlDataAdapter();
                //adapter.SelectCommand = cmd;
                //adapter.Fill(ds);
                //return ds.Tables[0].Rows[0][0].ToString();
            }
        }
    }
}
