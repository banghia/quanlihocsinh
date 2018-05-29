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
                sqlConnection.Open(); //Mở kết nối cơ sở dữ liệu.
                cmd.Connection = sqlConnection; //Gán kết nối csdl hiện tại cho SqlCommand.
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt); //Đổ dữ liệu query từ csdl vào DataTable.
                sqlConnection.Close(); //Đóng kết nối csdl.
            }
            return dt;
        }

        //Hàm thực thi câu lệnh truy vấn không phải select trả về số dòng thực hiện thành công.
        //Câu lệnh truy vần non query: insert, update, delete,..
        public int ExecuteNonQuery(SqlCommand cmd)
        {
            int result = 0;
            //Đối tượng SqlConnection sẽ tự động được giải phóng khi rời khỏi khối using.
            using (SqlConnection sqlConnection = new SqlConnection(chuoiKetNoi))
            {
                sqlConnection.Open(); //Mở kết nối cơ sở dữ liệu.
                cmd.Connection = sqlConnection; //Gán kết nối csdl hiện tại cho SqlCommand.
                result = cmd.ExecuteNonQuery(); //Thực thi câu lệnh truy vẫn NonQuery.
                sqlConnection.Close(); //Đóng kết nối csdl.
            }
            return result;
        }
    }
}
