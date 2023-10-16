using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangWinmart.DataAccessLayer
{
    public class NhaCungCapDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString;
        
        public DataTable getAllNCC()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prLayTatCaNCC", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cm))
                    {
                        DataTable dt = new DataTable("tblNhaCungCap");
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void ThemNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSDT)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prThemNCC", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNCC", sMaNCC);
                    cm.Parameters.AddWithValue("@TenNCC",sTenNCC);
                    cm.Parameters.AddWithValue("@DiaChi",sDiaChi);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void SuaNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSDT)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prSuaNCC", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNCC", sMaNCC);
                    cm.Parameters.AddWithValue("@TenNCC", sTenNCC);
                    cm.Parameters.AddWithValue("@DiaChi", sDiaChi);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void XoaNCC(string sMaNCC)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prXoaNCC", con))
                {
                    con.Open();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNCC", sMaNCC);
                    cm.ExecuteNonQuery();
                }
            }
        }

        

    }
}
