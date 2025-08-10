using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCongNghe.DataAccess
{
    public class DatabaseHelper
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLCH;Integrated Security=True"; // sửa nếu cần

        public static DataTable GetData(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static int Execute(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return cmd.ExecuteNonQuery(); // ✅ Trả về số dòng ảnh hưởng
                }
            }
        }

        public static int Execute(string sql, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    return cmd.ExecuteNonQuery(); // ✅ Trả về số dòng bị ảnh hưởng
                }
            }
        }

        public static int Execute(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }


        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
        }
        public static object ExecuteScalar(string sql, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
