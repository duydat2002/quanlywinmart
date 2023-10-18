using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestNhanVien
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Update_Employee_Successfully()
        {
            // Test thành công khi kết quả trả về datatable chứa 1 row
            // Test thất bại khi catch được lỗi
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
                nhanvienDAL.suaNhanVien("NV001", "Trần Văn A", true, "Hà Nội", DateTime.Parse("1990-01-01"), DateTime.Parse("2020-01-01"), "0123456789", true);
            }
            catch (SqlException ex)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethod_Update_Employee_Does_Not_Exist()
        {
            // Test thành công khi kết quả trả về datatable chứa 1 row
            // Test thất bại khi catch được lỗi

            NhanVienDAL nhanvienDAL = new NhanVienDAL();
            int expected = 0;
            int actual = nhanvienDAL.suaNhanVien("NV0001", "Trần Văn A", true, "Hà Nội", DateTime.Parse("1990-01-01"), DateTime.Parse("2020-01-01"), "0123456789", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Insert_Employee_Successfully()
        {
            // Test thành công khi kết quả trả về datatable chứa 1 row
            // Test thất bại khi catch được lỗi
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
              

                 nhanvienDAL.themNhanVien("NV013", "Trần Văn A", true, "Hà Nội", DateTime.Parse("1990-01-01"), DateTime.Parse("2020-01-01"), "0123456789", true);

                
            }
            catch (SqlException ex)
            {
                Assert.Fail();
            }
        }
      
        

    }
}
