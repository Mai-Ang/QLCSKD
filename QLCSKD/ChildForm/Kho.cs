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

namespace QLCSKD.ChildForm
{
    public partial class Kho : Form
    {
        private ADO dbConnection;
        private MongoClient client;
        private IMongoDatabase database;
        public Kho()
        {
            InitializeComponent();
            this.Load += Kho_Load;
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenthietbi.Text) ||
                string.IsNullOrWhiteSpace(txtSL.Text) ||
                string.IsNullOrWhiteSpace(txtViTri.Text) ||
                cmbTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenthietbi = txtTenthietbi.Text;
            string sL = txtSL.Text;
            string viTri = txtViTri.Text;
            string trangThai = cmbTrangThai.SelectedItem?.ToString();

            if (!int.TryParse(sL, out _))
            {
                MessageBox.Show("Số lượng phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(viTri, out _))
            {
                MessageBox.Show("Vị trí phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var sup = new Supplies
            {
                Tenthietbi = tenthietbi,
                SL = sL,
                ViTri = viTri,
                TrangThai = trangThai,
            };

            await dbConnection.ThemThietBi("Supplies", sup);
            await LoadDataToDataGridView();

            cmbTrangThai.SelectedItem = 0;
            txtTenthietbi.Clear();
            txtSL.Clear();
            txtViTri.Clear();
        }

        private async void Kho_Load(object sender, EventArgs e)
        {
            await LoadDataToDataGridView();
        }

        private async Task LoadDataToDataGridView()
        {
            var contract = await dbConnection.Trans_Hisas("Supplies");
            contract = contract.OrderByDescending(t => t.SL).ToList();
            dtgvThietbi.DataSource = contract;
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvThietbi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtgvThietbi.SelectedRows)
            {
                // Lấy đối tượng Contract từ dòng được chọn
                var supplies = row.DataBoundItem as Supplies;
                if (supplies != null && supplies.Id != null)
                {
                    // Gọi phương thức xóa hợp đồng từ cơ sở dữ liệu MongoDB
                    await dbConnection.XoaThietBi("Supplies", supplies);
                }
            }

            // Tải lại dữ liệu lên DataGridView sau khi xóa
            await LoadDataToDataGridView();

            MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dtgvThietbi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dtgvThietbi.SelectedRows[0];

            var supplies = selectedRow.DataBoundItem as Supplies;
            if (supplies == null)
            {
                MessageBox.Show("Không thể tìm thấy hợp đồng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTenthietbi.Text))
                supplies.Tenthietbi = txtTenthietbi.Text;

            if (!string.IsNullOrWhiteSpace(txtSL.Text))
                supplies.SL = txtSL.Text;

            if (!string.IsNullOrWhiteSpace(txtViTri.Text))
                supplies.ViTri = txtViTri.Text;

            if (cmbTrangThai.SelectedItem != null)
                supplies.TrangThai = cmbTrangThai.SelectedItem.ToString();



            //supplies.NgayBatDau = dtpkBegin.Value.ToString("yyyy-MM-dd");

            // Call the method to update the contract in the database
            await dbConnection.SuaThietBi("Supplies", supplies);

            // Reload data to DataGridView after editing
            await LoadDataToDataGridView();

            // Clear input controls
            txtTenthietbi.Clear();
            txtSL.Clear();
            txtViTri.Clear();
            cmbTrangThai.SelectedIndex = -1;

            btnSua.Enabled = true;

            MessageBox.Show("Đã cập nhật hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvThietbi_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvThietbi.SelectedRows.Count > 0)
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
