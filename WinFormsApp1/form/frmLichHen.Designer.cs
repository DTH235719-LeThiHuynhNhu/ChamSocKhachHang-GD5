namespace ChamSocKhachHang.form
{
    partial class frmLichHen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLamMoi = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtNoiDung = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            txtTimKiem = new TextBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            chkTrangThai = new CheckBox();
            dtpNgayHen = new DateTimePicker();
            cboKhachHang = new ComboBox();
            dtpTimNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.GradientActiveCaption;
            btnLamMoi.Location = new Point(735, 508);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 33);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "Nội dung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 79);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 0;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(554, 30);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(222, 27);
            txtNoiDung.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "Ngày hẹn";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(606, 126);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(371, 508);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(221, 27);
            txtTimKiem.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Size = new Size(829, 252);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(17, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(835, 278);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = SystemColors.ActiveCaptionText;
            btnHuyBo.Location = new Point(506, 126);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(406, 126);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(306, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(106, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách Hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientActiveCaption;
            btnTimKiem.Location = new Point(623, 508);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.ActiveCaptionText;
            btnSua.Location = new Point(206, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTrangThai);
            groupBox1.Controls.Add(dtpNgayHen);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNoiDung);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 174);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(554, 75);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(85, 24);
            chkTrangThai.TabIndex = 15;
            chkTrangThai.Text = "Đã xử lý";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // dtpNgayHen
            // 
            dtpNgayHen.Location = new Point(139, 79);
            dtpNgayHen.Name = "dtpNgayHen";
            dtpNgayHen.Size = new Size(250, 27);
            dtpNgayHen.TabIndex = 14;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(139, 29);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 13;
            // 
            // dtpTimNgay
            // 
            dtpTimNgay.Location = new Point(81, 506);
            dtpTimNgay.Name = "dtpTimNgay";
            dtpTimNgay.Size = new Size(250, 27);
            dtpTimNgay.TabIndex = 15;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(864, 554);
            Controls.Add(dtpTimNgay);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox1);
            Name = "frmLichHen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLichHen";
            Load += frmLichHen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLamMoi;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtNoiDung;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private TextBox txtTimKiem;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private Button btnTimKiem;
        private Button btnSua;
        private GroupBox groupBox1;
        private CheckBox chkTrangThai;
        private DateTimePicker dtpNgayHen;
        private ComboBox cboKhachHang;
        private DateTimePicker dtpTimNgay;
    }
}