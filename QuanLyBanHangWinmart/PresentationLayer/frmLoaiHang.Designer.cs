namespace QuanLyBanHangWinmart
{
    partial class frmLoaiHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tpChinhSua = new System.Windows.Forms.TabPage();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.tpTimKiem = new System.Windows.Forms.TabPage();
            this.cboMaS = new System.Windows.Forms.ComboBox();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.lblTenS = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crystalOpenFileDialog1 = new CrystalDecisions.Shared.Interop.CrystalOpenFileDialog();
            this.tabContainer.SuspendLayout();
            this.tpChinhSua.SuspendLayout();
            this.tpTimKiem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.tpChinhSua);
            this.tabContainer.Controls.Add(this.tpTimKiem);
            this.tabContainer.Location = new System.Drawing.Point(13, 22);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(953, 199);
            this.tabContainer.TabIndex = 13;
            // 
            // tpChinhSua
            // 
            this.tpChinhSua.Controls.Add(this.txtTenLoaiHang);
            this.tpChinhSua.Controls.Add(this.lblTen);
            this.tpChinhSua.Controls.Add(this.txtMaLoaiHang);
            this.tpChinhSua.Controls.Add(this.lblMa);
            this.tpChinhSua.Location = new System.Drawing.Point(4, 25);
            this.tpChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Name = "tpChinhSua";
            this.tpChinhSua.Padding = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Size = new System.Drawing.Size(945, 170);
            this.tpChinhSua.TabIndex = 0;
            this.tpChinhSua.Text = "Chỉnh sửa";
            this.tpChinhSua.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(146, 72);
            this.txtTenLoaiHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(567, 22);
            this.txtTenLoaiHang.TabIndex = 13;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(16, 75);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(99, 16);
            this.lblTen.TabIndex = 12;
            this.lblTen.Text = "Tên Loại Hàng ";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(146, 24);
            this.txtMaLoaiHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(567, 22);
            this.txtMaLoaiHang.TabIndex = 11;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(16, 27);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(91, 16);
            this.lblMa.TabIndex = 10;
            this.lblMa.Text = "Mã Loại hàng ";
            // 
            // tpTimKiem
            // 
            this.tpTimKiem.Controls.Add(this.label1);
            this.tpTimKiem.Controls.Add(this.cboMaS);
            this.tpTimKiem.Controls.Add(this.btnHienTatCa);
            this.tpTimKiem.Controls.Add(this.btnTimKiem);
            this.tpTimKiem.Controls.Add(this.txtTenS);
            this.tpTimKiem.Controls.Add(this.lblTenS);
            this.tpTimKiem.Controls.Add(this.lblMaS);
            this.tpTimKiem.Location = new System.Drawing.Point(4, 25);
            this.tpTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tpTimKiem.Name = "tpTimKiem";
            this.tpTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.tpTimKiem.Size = new System.Drawing.Size(945, 170);
            this.tpTimKiem.TabIndex = 1;
            this.tpTimKiem.Text = "Tìm kiếm";
            this.tpTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboMaS
            // 
            this.cboMaS.FormattingEnabled = true;
            this.cboMaS.Location = new System.Drawing.Point(134, 27);
            this.cboMaS.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaS.Name = "cboMaS";
            this.cboMaS.Size = new System.Drawing.Size(589, 24);
            this.cboMaS.TabIndex = 32;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(597, 125);
            this.btnHienTatCa.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(92, 32);
            this.btnHienTatCa.TabIndex = 31;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(778, 125);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 32);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(134, 72);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(589, 22);
            this.txtTenS.TabIndex = 23;
            // 
            // lblTenS
            // 
            this.lblTenS.AutoSize = true;
            this.lblTenS.Location = new System.Drawing.Point(16, 75);
            this.lblTenS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenS.Name = "lblTenS";
            this.lblTenS.Size = new System.Drawing.Size(93, 16);
            this.lblTenS.TabIndex = 22;
            this.lblTenS.Text = "Tên Loại hàng";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(16, 27);
            this.lblMaS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(88, 16);
            this.lblMaS.TabIndex = 20;
            this.lblMaS.Text = "Mã Loại hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số lượng tìm được";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Location = new System.Drawing.Point(785, 262);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 32);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(622, 262);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 32);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(446, 262);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 32);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Location = new System.Drawing.Point(259, 262);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 32);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(89, 262);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 32);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(953, 235);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại hàng ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // crystalOpenFileDialog1
            // 
            this.crystalOpenFileDialog1.FileName = "crystalOpenFileDialog1";
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tabContainer);
            this.Name = "frmLoaiHang";
            this.Text = "frmLoaiHang";
            this.tabContainer.ResumeLayout(false);
            this.tpChinhSua.ResumeLayout(false);
            this.tpChinhSua.PerformLayout();
            this.tpTimKiem.ResumeLayout(false);
            this.tpTimKiem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tpChinhSua;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TabPage tpTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaS;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label lblTenS;
        private System.Windows.Forms.Label lblMaS;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrystalDecisions.Shared.Interop.CrystalOpenFileDialog crystalOpenFileDialog1;
    }
}