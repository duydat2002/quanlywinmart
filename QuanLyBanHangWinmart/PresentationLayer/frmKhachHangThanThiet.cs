using QuanLyBanHangWinmart.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart.PresentationLayer
{
    public partial class frmKhachHangThanThiet : Form
    {
        KhachHangThanThietBLL khttBLL = new KhachHangThanThietBLL();
        public frmKhachHangThanThiet()
        {
            InitializeComponent();
        }

        private void frmKhachHangThanThiet_Load(object sender, EventArgs e)
        {
            dgvKHTT.DataSource = khttBLL.getKhachHangTT();

            dgvKHTT.Columns[0].HeaderText = "Mã NV";
            dgvKHTT.Columns[1].HeaderText = "Tên NV";
            dgvKHTT.Columns[2].HeaderText = "SDT";



            dgvKHTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;
        }

        private void resetValue()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
        }

        private bool validate()
        {
            bool check = true;
            errorValidate.Clear();

            if (txtTenKH.Text.Trim() == "")
            {
                errorValidate.SetError(txtTenKH, "Không được để trống!");
                check = false;
            }
            else if (txtTenKH.Text.Length > 70)
            {
                errorValidate.SetError(txtTenKH, "Không được quá 70 kí tự!");
                check = false;
            }

            if (txtSDT.Text.Trim() == "")
            {
                errorValidate.SetError(txtSDT, "Không được để trống!");
                check = false;
            }
            else if (txtSDT.Text.Length > 20)
            {
                errorValidate.SetError(txtSDT, "Không được quá 15 kí tự!");
                check = false;
            }
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled == true)
                resetValue();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    khttBLL.themKhachHangTT(
                    txtMaKH.Text.Trim(),
                    txtTenKH.Text.Trim(),
                    txtSDT.Text.Trim());

                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;

                    resetValue();

                    dgvKHTT.DataSource = khttBLL.getKhachHangTT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    if (MessageBox.Show($"Bạn có muốn sửa nhân viên {txtMaKH.Text}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        khttBLL.suaKhachHangTT(
                        txtMaKH.Text.Trim(),
                        txtTenKH.Text.Trim(),
                        txtSDT.Text.Trim());

                        resetValue();

                        dgvKHTT.DataSource = khttBLL.getKhachHangTT();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Bạn có muốn xóa nhân viên {txtMaKH.Text}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    khttBLL.xoaKhachHangTT(txtMaKH.Text);

                    resetValue();

                    dgvKHTT.DataSource = khttBLL.getKhachHangTT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorValidate.Clear();

            txtMaKH.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            if (btnThem.Enabled == false && tabContainer.SelectedTab == tpChinhSua)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }

            resetValue();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !btnThem.Enabled)
                return;

            if (tabContainer.SelectedTab == tpTimKiem)
            {
                tabContainer.SelectedTab = tpChinhSua;
            }

            txtMaKH.Text = dgvKHTT.CurrentRow.Cells["sMaKH"].Value.ToString();
            txtTenKH.Text = dgvKHTT.CurrentRow.Cells["sTenKH"].Value.ToString();
            txtSDT.Text = dgvKHTT.CurrentRow.Cells["sSDT"].Value.ToString();


            if (btnThem.Enabled == true)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaKH.Enabled = false;
            }
        }
    }
}
