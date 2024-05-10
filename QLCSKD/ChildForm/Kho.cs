using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
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



        private async void Kho_Load(object sender, EventArgs e)
        {
            await LoadDataToDataGridView("Supplies");
        }

        private async Task LoadDataToDataGridView(string collectionName)
        {
            var supplies = await dbConnection.LsKho(collectionName);

            dtg_content.DataSource = supplies;

            dtg_content.Columns["Tenthietbi"].HeaderText = "Tên thiết bị";
            dtg_content.Columns["PS"].HeaderText = "Phòng Số";
            dtg_content.Columns["ViTri"].HeaderText = "Vị trí";
            dtg_content.Columns["TrangThai"].HeaderText = "Trạng thái";

        }





        private void dtg_content_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count > 0)
            {
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        private async void btnthem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ttb.Text) ||
                cb_ps.SelectedItem == null ||
                cb_vt.SelectedItem == null ||
                cb_tt.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSupplies = new Supplies
            {
                Tenthietbi = txt_ttb.Text,
                PS = cb_ps.SelectedItem.ToString(),
                ViTri = cb_vt.SelectedItem.ToString(),
                TrangThai = cb_tt.SelectedItem.ToString()
            };

            await dbConnection.ThemThietBi("Supplies", newSupplies);
            await LoadDataToDataGridView("Supplies");

            cb_tt.SelectedItem = null;
            txt_ttb.Clear();
        }

        private async void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtg_content.SelectedRows)
            {
                // Lấy đối tượng Supplies từ dòng được chọn
                var supplies = row.DataBoundItem as Supplies;
                if (supplies != null && supplies.Id != null)
                {
                    await dbConnection.XoaThietBi("Supplies", supplies); // Thay đổi tham số thứ hai thành Id của đối tượng Supplies
                }
            }

            // Tải lại dữ liệu lên DataGridView sau khi xóa
            await LoadDataToDataGridView("Supplies");

            MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnsua_Click_1(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dtg_content.SelectedRows[0];
            var id = selectedRow.Cells["Id"].Value.ToString(); // Lấy ID của hàng được chọn

            if (!ObjectId.TryParse(id, out ObjectId objectId))
            {
                MessageBox.Show("Không thể tìm thấy dữ liệu để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplies = new Supplies
            {
                Id = objectId,
                Tenthietbi = txt_ttb.Text,
                PS = cb_ps.SelectedItem?.ToString(),
                ViTri = cb_vt.SelectedItem?.ToString(),
                TrangThai = cb_tt.SelectedItem?.ToString()
            };

            await dbConnection.SuaThietBi("Supplies", supplies);
            await LoadDataToDataGridView("Supplies");

            txt_ttb.Clear();
            cb_ps.SelectedIndex = -1;
            cb_vt.SelectedIndex = -1;
            cb_tt.SelectedIndex = -1;

            btnsua.Enabled = true;

            MessageBox.Show("Đã cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void dtg_content_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dtg_content.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtg_content.SelectedRows[0];
                // Lấy các giá trị từ hàng được chọn
                string tenthietbi = selectedRow.Cells["Tenthietbi"].Value.ToString();
                string ps = selectedRow.Cells["PS"].Value.ToString();
                string vitri = selectedRow.Cells["ViTri"].Value.ToString();
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                txt_ttb.Text = tenthietbi;
                cb_ps.SelectedItem = ps;
                cb_vt.SelectedItem = vitri;
                cb_tt.SelectedItem = trangThai;
            }
            else
            {
                txt_ttb.Clear();
                cb_ps.SelectedIndex = -1;
                cb_vt.SelectedIndex = -1;
                cb_tt.SelectedIndex = -1;
            }
        }
    }

    
}
