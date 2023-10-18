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
    public class KhachHangThanThietDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString;

        public DataTable getAllKhachHangTT()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prLayTatCaKhachHangTT", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cm))
                    {
                        DataTable dt = new DataTable("tblKhachHangThanThiet");
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void ThemKhachHangTT(string sMaKH, string sTenKH, string sSDT)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prThemKhachHangTT", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNV", sMaKH);
                    cm.Parameters.AddWithValue("@TenKH", sTenKH);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void SuaKhachHangTT(string sMaKH, string sTenKH, string sSDT)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prSuaKhachHangThanThiet", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaKH", sMaKH);
                    cm.Parameters.AddWithValue("@TenKH", sTenKH);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void XoaKhachHangTT(string sMaKH)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prXoaKhachHangTT", con))
                {
                    con.Open();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaKH", sMaKH);
                    cm.ExecuteNonQuery();
                }
            }
        }
    }
}
