using QuanLyBanHangWinmart.BusinessLogicLayer;
using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart
{
    public partial class frmNhaCungCap : Form
    {
        NhaCungCapBLLcs nccBLL = new NhaCungCapBLLcs();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = nccBLL.getALLNCC();

            dgvNCC.Columns[0].HeaderText = "Mã NV";
            dgvNCC.Columns[1].HeaderText = "Tên NV";
            dgvNCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNCC.Columns[3].HeaderText = "Số điện thoại";
            

            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMa.Enabled = false;
        }

        private void resetValue()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }
        private bool validate()
        {
            bool check = true;
            errorValidate.Clear();

            if (txtTen.Text.Trim() == "")
            {
                errorValidate.SetError(txtTen, "Không được để trống!");
                check = false;
            }
            else if (txtTen.Text.Length > 70)
            {
                errorValidate.SetError(txtTen, "Không được quá 70 kí tự!");
                check = false;
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                errorValidate.SetError(txtDiaChi, "Không được để trống!");
                check = false;
            }
            else if (txtDiaChi.Text.Length > 70)
            {
                errorValidate.SetError(txtDiaChi, "Không được quá 70 kí tự!");
                check = false;
            }

            if (txtSDT.Text.Trim() == "")
            {
                errorValidate.SetError(txtSDT, "Không được để trống!");
                check = false;
            }
            else if (txtSDT.Text.Length > 20)
            {
                errorValidate.SetError(txtSDT, "Không được quá 20 kí tự!");
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
                    nccBLL.themNCC(
                    txtMa.Text.Trim(),
                    txtTen.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    txtSDT.Text.Trim());

                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;

                    resetValue();

                    dgvNCC.DataSource = nccBLL.getALLNCC();
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
                    if (MessageBox.Show($"Bạn có muốn sửa nhân viên {txtMa.Text}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nccBLL.suaNCC(
                        txtMa.Text.Trim(),
                        txtTen.Text.Trim(),
                        txtDiaChi.Text.Trim(),
                        txtSDT.Text.Trim());

                        resetValue();

                        dgvNCC.DataSource = nccBLL.getALLNCC();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !btnThem.Enabled)
                return;

            if (tabContainer.SelectedTab == tpTimKiem)
            {
                tabContainer.SelectedTab = tpChinhSua;
            }

            txtMa.Text = dgvNCC.CurrentRow.Cells["sMaNCC"].Value.ToString();
            txtTen.Text = dgvNCC.CurrentRow.Cells["sTenNCC"].Value.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells["sDiaChi"].Value.ToString();
            txtSDT.Text = dgvNCC.CurrentRow.Cells["sSDT"].Value.ToString();
            

            if (btnThem.Enabled == true)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Bạn có muốn xóa nhân viên {txtMa.Text}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    nccBLL.xoaNCC(txtMa.Text);

                    resetValue();

                    dgvNCC.DataSource = nccBLL.getALLNCC();
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

            txtMa.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            if (btnThem.Enabled == false && tabContainer.SelectedTab == tpChinhSua)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }

            resetValue();
        }
    }
}
