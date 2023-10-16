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
    public class NhaCungCapBLLcs
    {
        NhaCungCapDAL nccDAL = new NhaCungCapDAL();

        public DataTable getALLNCC()
        {
            try
            {
                return nccDAL.getAllNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void themNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSDT)
        {
            nccDAL.ThemNCC(sMaNCC, sTenNCC, sDiaChi, sSDT);
        }

        public void suaNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSDT)
        {
            nccDAL.SuaNCC(sMaNCC, sTenNCC, sDiaChi, sSDT);
        }

        public void xoaNCC(string sMaNCC)
        {
            nccDAL.XoaNCC(sMaNCC);
        }

       
    }
}
