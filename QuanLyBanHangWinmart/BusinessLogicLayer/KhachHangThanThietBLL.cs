using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart.BusinessLogicLayer
{
    public class KhachHangThanThietBLL
    {
        KhachHangThanThietDAL KHTTDAL = new KhachHangThanThietDAL();
        public DataTable getKhachHangTT()
        {
            try
            {
                return KHTTDAL.getAllKhachHangTT();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void themKhachHangTT(string sMaKH, string sTenKH, string sSDT)
        {
            KHTTDAL.ThemKhachHangTT(sMaKH, sTenKH, sSDT);
        }

        public void suaKhachHangTT(string sMaKH, string sTenKH, string sSDT)
        {
            KHTTDAL.SuaKhachHangTT(sMaKH, sTenKH, sSDT);
        }

        public void xoaKhachHangTT(string sMaKH)
        {
            KHTTDAL.XoaKhachHangTT(sMaKH);
        }
    }
}
