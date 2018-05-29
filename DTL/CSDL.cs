using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DTL
{
    public class CSDL
    {
        public string chuoiKetNoi = ConfigurationManager.ConnectionStrings["chuoiKetNoi"].ConnectionString;

        //Hàm thực thi câu lệnh truy vấn select trả về DataTable.
        public DataTable ExecuteQuery(SqlCommand cmd) {
            DataTable dt = new DataTable();
            //Đối tượng SqlConnection sẽ tự động được giải phóng khi rời khỏi khối using.
            using (SqlConnection sqlConnection = new SqlConnection(chuoiKetNoi)) {
                cmd.Connection = sqlConnection;
            }
            return dt;
        }
    }
}
