using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyBanHangWinmart.BusinessLogicLayer;
using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using QuanLyBanHangWinmart;
using System.Data;

namespace UnitTestLogin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_DangNhap_Successfully()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            String tenDangNhap = "user1";
            String matKhau = "password1";

            DataTable dt = taiKhoanDAL.dangNhap(tenDangNhap, matKhau);
            NhanVien actual = new NhanVien(
                    (string)dt.Rows[0]["sMaNV"],
                    (string)dt.Rows[0]["sTenNV"],
                    (string)dt.Rows[0]["sTenLoaiTK"]
            );
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestMethod_DangNhap_TenTK_Does_Not_Exist()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            String tenTK = "Linh Thai";
            String matKhau = "cccccc";

            Assert.IsNull(taiKhoanDAL.dangNhap(tenTK, matKhau));
        }

        [TestMethod]
        public void TestMethod_KiemTraDangNhap_NotSuccess()
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            string username = "";
            string password = "";
            
            bool expected = false;
            bool actual = frmDangNhap.KiemTraDangNhap(username, password);

            Assert.AreEqual(expected, actual);
        }


    }
}
