using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLCSKD.ADO;

namespace QLCSKD.ChildForm.KhachChild
{
    public partial class QuanLyHopDong : Form
    {
        private ADO dbConnection;
        private MongoClient client;
        private IMongoDatabase database;

        private IMongoCollection<BsonDocument> collection;
        public QuanLyHopDong()
        {
            InitializeComponent();
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
            this.Load += QuanLyHopDong_Load;
            btnSua.Enabled = false;
            btnSua.Enabled = false;
            dtg_content.SelectionChanged += dtgvHopDong_SelectionChanged;
        }

        private async void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            await LoadDataToDataGridView();
        }

        private async Task LoadDataToDataGridView()
        {
            var contract = await dbConnection.Trans_Hisa("Contract");
            contract = contract.OrderByDescending(t => t.NgayBatDau).ToList();
            dtg_content.DataSource = contract;

            dtg_content.Columns["TenKhach"].HeaderText = "Tên khách";
            dtg_content.Columns["ThongTinLienHe"].HeaderText = "Thông tin liên hệ";
            dtg_content.Columns["SOCCCD"].HeaderText = "Số CCCD";
            dtg_content.Columns["SoPhong"].HeaderText = "Số phòng";
            dtg_content.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dtg_content.Columns["Gia"].HeaderText = "Gia";
            dtg_content.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
        }

       

        private void dtgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private async void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhach.Text) ||
                string.IsNullOrWhiteSpace(txtThongTinLienHe.Text) ||
                cmb_SoPhong.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                cmbLoai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKhach = txtKhach.Text;
            string thongTinLienHe = txtThongTinLienHe.Text;
            string soPhong = cmb_SoPhong.SelectedItem?.ToString();
            string soCCCD = txtCCCD.Text;
            string loaiPhong = cmbLoai.SelectedItem?.ToString();
            string gia = txtGia.Text;
            string ngayBatDau = dtpkBegin.Value.ToString("yyyy-MM-dd");

            if (!int.TryParse(thongTinLienHe, out _) || thongTinLienHe.Length != 10)
            {
                MessageBox.Show("Số liên hệ phải là một số nguyên và phải 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(soCCCD, out _))
            {
                MessageBox.Show("Số CCCD phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var contt = new QLCSKD.ADO.Contract
            {
                TenKhach = tenKhach,
                ThongTinLienHe = thongTinLienHe,
                SOCCCD = soCCCD,
                SoPhong = soPhong,
                LoaiPhong = loaiPhong,
                Gia = gia,
                NgayBatDau = ngayBatDau
            };

            await dbConnection.ThemHopDong("Contract", contt);
            await LoadDataToDataGridView();

            txtKhach.Clear();
            txtThongTinLienHe.Clear();
            cmb_SoPhong.SelectedIndex = -1;
            txtCCCD.Clear();
            txtGia.Clear();
            cmbLoai.SelectedIndex = 0;
        }

        private async void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtg_content.SelectedRows)
            {
                // Lấy đối tượng Contract từ dòng được chọn
                var contract = row.DataBoundItem as QLCSKD.ADO.Contract; // Fully qualified name
                if (contract != null && contract.Id != null)
                {
                    // Gọi phương thức xóa hợp đồng từ cơ sở dữ liệu MongoDB
                    await dbConnection.XoaHopDong("Contract", contract);
                }
            }

            // Tải lại dữ liệu lên DataGridView sau khi xóa
            await LoadDataToDataGridView();

            MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dtg_content.SelectedRows[0];

            var contract = selectedRow.DataBoundItem as QLCSKD.ADO.Contract;
            if (contract == null)
            {
                MessageBox.Show("Không thể tìm thấy hợp đồng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtKhach.Text))
                contract.TenKhach = txtKhach.Text;

            if (!string.IsNullOrWhiteSpace(txtThongTinLienHe.Text))
                contract.ThongTinLienHe = txtThongTinLienHe.Text;

            if (!string.IsNullOrWhiteSpace(txtCCCD.Text))
                contract.SOCCCD = txtCCCD.Text;

            if (cmb_SoPhong.SelectedItem != null)
                contract.SoPhong = cmb_SoPhong.SelectedItem.ToString();

            if (cmbLoai.SelectedItem != null)
                contract.LoaiPhong = cmbLoai.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(txtGia.Text))
                contract.Gia = txtGia.Text;


            contract.NgayBatDau = dtpkBegin.Value.ToString("yyyy-MM-dd");

            await dbConnection.SuaHopDong("Contract", contract);

            await LoadDataToDataGridView();

            txtKhach.Clear();
            txtThongTinLienHe.Clear();
            cmb_SoPhong.SelectedIndex = -1;
            txtCCCD.Clear();
            txtGia.Clear();
            cmbLoai.SelectedIndex = -1;

            btnSua.Enabled = true;

            MessageBox.Show("Đã cập nhật hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtg_content_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtg_content.SelectedRows[0];
                string tenKhach = selectedRow.Cells["TenKhach"].Value.ToString();
                string thongTinLienHe = selectedRow.Cells["ThongTinLienHe"].Value.ToString();
                string soCCCD = selectedRow.Cells["SOCCCD"].Value.ToString();
                string soPhong = selectedRow.Cells["SoPhong"].Value.ToString();
                string loaiPhong = selectedRow.Cells["LoaiPhong"].Value.ToString();
                string gia = selectedRow.Cells["Gia"].Value.ToString();
                string ngayBatDau = selectedRow.Cells["NgayBatDau"].Value.ToString();

                txtKhach.Text = tenKhach;
                txtThongTinLienHe.Text = thongTinLienHe;
                txtCCCD.Text = soCCCD;
                cmb_SoPhong.SelectedItem = soPhong;
                cmbLoai.SelectedItem = loaiPhong;
                txtGia.Text = gia;
                dtpkBegin.Value = DateTime.Parse(ngayBatDau);
            }
            else
            {
                txtKhach.Clear();
                txtThongTinLienHe.Clear();
                txtCCCD.Clear();
                cmb_SoPhong.SelectedIndex = -1;
                cmbLoai.SelectedIndex = -1;
                txtGia.Clear();
                dtpkBegin.Value = DateTime.Now;
            }
        }

        private void cmbLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLoai.SelectedIndex == 0)
            {
                txtGia.Text = "1200000";
            }
            else
            {
                txtGia.Text = "800000";
            }
        }


    }
}
