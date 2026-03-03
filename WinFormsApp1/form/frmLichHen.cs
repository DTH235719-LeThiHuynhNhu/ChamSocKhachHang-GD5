using ChamSocKhachHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocKhachHang.form
{
    public partial class frmLichHen : Form
    {
        CSKHContext context = new CSKHContext();
        bool xuLyThem = false;
        int id;
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Load khách hàng vào combobox
            cboKhachHang.DataSource = context.KhachHangs.ToList();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "ID";

            dtpNgayHen.Format = DateTimePickerFormat.Custom;
            dtpNgayHen.CustomFormat = "dd/MM/yyyy";

            // Load lịch hẹn
            LoadLichHen(context.LichHens.ToList());
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            cboKhachHang.Enabled = giaTri;
            dtpNgayHen.Enabled = giaTri;
            txtNoiDung.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void LoadLichHen(List<LichHen> lh)
        {
            var data = lh.Select(x => new
            {
                x.ID,
                TenKhachHang = x.KhachHang.HoTen,
                NgayHen = x.NgayHen.ToString("dd/MM/yyyy"),
                x.NoiDung,
                TrangThai = x.TrangThai ? "Đã xử lý" : "Chưa xử lý"
            }).ToList();

            dataGridView2.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtNoiDung.Clear();
            chkTrangThai.Checked = false;
            dtpNgayHen.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa lịch hẹn?", "Xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value);

                LichHen lh = context.LichHens.Find(id);
                if (lh != null)
                {
                    context.LichHens.Remove(lh);
                    context.SaveChanges();
                }

                LoadLichHen(context.LichHens.ToList());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung!");
                return;
            }

            if (xuLyThem)
            {
                LichHen lh = new LichHen();
                lh.KhachHangID = (int)cboKhachHang.SelectedValue;
                lh.NgayHen = dtpNgayHen.Value.Date;
                lh.NoiDung = txtNoiDung.Text;
                lh.TrangThai = chkTrangThai.Checked;

                context.LichHens.Add(lh);
            }
            else
            {
                LichHen lh = context.LichHens.Find(id);
                if (lh != null)
                {
                    lh.KhachHangID = (int)cboKhachHang.SelectedValue;
                    lh.NgayHen = dtpNgayHen.Value;
                    lh.NoiDung = txtNoiDung.Text;
                    lh.TrangThai = chkTrangThai.Checked;
                }
            }

            context.SaveChanges();
            LoadLichHen(context.LichHens.ToList());
            BatTatChucNang(false);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadLichHen(context.LichHens.ToList());

            txtNoiDung.Clear();
            chkTrangThai.Checked = false;

            BatTatChucNang(false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();

            var query = context.LichHens.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    x.NoiDung.ToLower().Contains(keyword)
                    || x.KhachHang.HoTen.ToLower().Contains(keyword)
                );
            }

            // nếu bạn muốn tìm theo ngày
            query = query.Where(x => x.NgayHen.Date == dtpTimNgay.Value.Date);

            LoadLichHen(query.ToList());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
