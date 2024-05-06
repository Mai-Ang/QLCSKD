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
            dtgvHopDong.SelectionChanged += dtgvHopDong_SelectionChanged;
        }

        private async void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            await LoadDataToDataGridView();
        }

        private async Task LoadDataToDataGridView()
        {
            var contract = await dbConnection.Trans_Hisa("Contract");
            contract = contract.OrderByDescending(t => t.NgayBatDau).ToList();
            dtgvHopDong.DataSource = contract;

            dtgvHopDong.Columns["TenKhach"].HeaderText = "Tên khách";
            dtgvHopDong.Columns["ThongTinLienHe"].HeaderText = "Thông tin liên hệ";
            dtgvHopDong.Columns["SOCCCD"].HeaderText = "Số CCCD";
            dtgvHopDong.Columns["SoPhong"].HeaderText = "Số phòng";
            dtgvHopDong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dtgvHopDong.Columns["Gia"].HeaderText = "Gia";
            dtgvHopDong.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
        }


        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhach.Text) ||
                string.IsNullOrWhiteSpace(txtThongTinLienHe.Text) ||
                string.IsNullOrWhiteSpace(txtSoPhong.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                cmbLoai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKhach = txtKhach.Text;
            string thongTinLienHe = txtThongTinLienHe.Text;
            string soPhong = txtSoPhong.Text;
            string soCCCD = txtCCCD.Text;
            string loaiPhong = cmbLoai.SelectedItem?.ToString();
            string gia = txtGia.Text;
            string ngayBatDau = dtpkBegin.Value.ToString("yyyy-MM-dd");

            if (!int.TryParse(thongTinLienHe, out _) || thongTinLienHe.Length != 10)
            {
                MessageBox.Show("Số lượng phải là một số nguyên và phải 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soPhong, out _))
            {
                MessageBox.Show("Số phòng phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soCCCD, out _))
            {
                MessageBox.Show("Số CCCD phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            var contt = new Contract
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
            txtSoPhong.Clear();
            txtCCCD.Clear();
            txtGia.Clear();
            cmbLoai.SelectedIndex = 0;
        }


        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
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

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtgvHopDong.SelectedRows)
            {
                // Lấy đối tượng Contract từ dòng được chọn
                var contract = row.DataBoundItem as Contract;
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


        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dtgvHopDong.SelectedRows[0];

            var contract = selectedRow.DataBoundItem as Contract;
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

            if (!string.IsNullOrWhiteSpace(txtSoPhong.Text))
                contract.SoPhong = txtSoPhong.Text;

            if (cmbLoai.SelectedItem != null)
                contract.LoaiPhong = cmbLoai.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(txtGia.Text))
                contract.Gia = txtGia.Text;


            contract.NgayBatDau = dtpkBegin.Value.ToString("yyyy-MM-dd");

            // Call the method to update the contract in the database
            await dbConnection.SuaHopDong("Contract", contract);

            // Reload data to DataGridView after editing
            await LoadDataToDataGridView();

            // Clear input controls
            txtKhach.Clear();
            txtThongTinLienHe.Clear();
            txtSoPhong.Clear();
            txtCCCD.Clear();
            txtGia.Clear();
            cmbLoai.SelectedIndex = -1;

            btnSua.Enabled = true;

            MessageBox.Show("Đã cập nhật hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dtgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvHopDong.SelectedRows.Count > 0)
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
    }
}
