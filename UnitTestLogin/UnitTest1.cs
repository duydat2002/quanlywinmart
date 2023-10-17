using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangWinmart.DataAccessLayer.Tests
{
    [TestClass()]
    public class TaiKhoanDALTests
    {
        [TestMethod]
        public void dangNhapTest_Success()
        {
            // Test thành công khi kết quả trả về datatable chứa 1 row
            // Test thất bại khi catch được lỗi
            try
            {
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

                int expected = 1;

                DataTable dt = taiKhoanDAL.dangNhap("user1", "password1");
                int actual = dt.Rows.Count;

                Assert.AreEqual(actual, expected);
            }
            catch (SqlException ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void dangNhapTest_User_Not_Exits()
        {
            // Test thành công khi catch được lỗi "Tài khoản không tồn tại!"
            // Test thất bại khi không catch được lỗi
            try
            {
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
                DataTable dt = taiKhoanDAL.dangNhap("user21", "password1");
                Assert.Fail();
            }
            catch (SqlException ex)
            {
                string expected = "Tài khoản không tồn tại!";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void dangNhapTest_Password_Incorrect()
        {
            // Test thành công khi catch được lỗi "Mật khẩu không đúng!"
            // Test thất bại khi không catch được lỗi
            try
            {
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
                DataTable dt = taiKhoanDAL.dangNhap("user1", "password2");
                Assert.Fail();
            }
            catch (SqlException ex)
            {
                string expected = "Mật khẩu không đúng!";
                Assert.AreEqual(ex.Message, expected);
            }
        }
    }
}
/*using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            String tenDangNhap = "Oanhhoang";
            String matKhau = "password1";

            DataTable actual = taiKhoanDAL.dangNhap(tenDangNhap, matKhau);
           
            Assert.IsNull(actual);
        }
        public void TestMethod_DangNhap_MK_Does_Not_Exist()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            String tenDangNhap = "user1";
            String matKhau = "password12";

            DataTable actual = taiKhoanDAL.dangNhap(tenDangNhap, matKhau);
         
            Assert.IsNull(actual);
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
}*/
