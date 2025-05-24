using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DoAnSE104.DAL
{
    class DatabaseHelper
    {
        private string connectionString = "server=localhost;database=PhongKham;user=root;password=;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public DataTable ExecuteQuery(string query) //truy vấn trả về bảng dữ liệu (select...)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters) //truy vấn trả về bảng dữ liệu (select...)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        public int ExecuteNonQuery(string query) //truy vấn không trả về giá trị nào (insert, update, delete...)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query) //truy vấn trả về 1 giá trị duy nhất (count, max, min...)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }


        public int ExecuteNonQuery(string query, MySqlParameter[] parameters) //truy vấn không trả về giá trị nào (insert, update, delete...)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
