using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLCSKD.ADO;

namespace QLCSKD.ChildForm
{
    public partial class DichVu : Form
    {
        private ADO dbConnection;
        private IMongoCollection<BsonDocument> collection;
        public DichVu()
        {
            InitializeComponent();
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
            this.Load += DichVu_Load;
        }

        private async void DichVu_Load(object sender, EventArgs e)
        {
            await LoadDataToDataGridView();
        }

        private async Task LoadDataToDataGridView()
        {
            var supplies = await dbConnection.LsDichVu("Services");
            supplies = supplies.OrderByDescending(t => t.Price).ToList();
            dtgvDichVu.DataSource = supplies;

            dtgvDichVu.Columns["Name"].HeaderText = "Tên dịch vụ";
            dtgvDichVu.Columns["Price"].HeaderText = "Giá tiền";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Tên.Text) ||
                !int.TryParse(txt_Gia.Text, out int gia) ||
                gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tendichvu = txt_Tên.Text;

            var services = new Services
            {
                Name = tendichvu,
                Price = gia,

            };

            await dbConnection.ThemDichVu("Services", services);
            await LoadDataToDataGridView();

            txt_Tên.Clear();
            txt_Gia.Clear();

        }

        private async void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtgvDichVu.SelectedRows)
            {
                // Lấy đối tượng Contract từ dòng được chọn
                var services = row.DataBoundItem as Services; // Fully qualified name
                if (services != null && services.Id != null)
                {
                    // Gọi phương thức xóa hợp đồng từ cơ sở dữ liệu MongoDB
                    await dbConnection.XoaDichVu("Services", services);
                }
            }

            // Tải lại dữ liệu lên DataGridView sau khi xóa
            await LoadDataToDataGridView();

            MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dtgvDichVu.SelectedRows[0];

            var services = selectedRow.DataBoundItem as Services;
            if (services == null)
            {
                MessageBox.Show("Không thể tìm thấy hợp đồng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txt_Tên.Text))
                services.Name = txt_Tên.Text;

            if (!string.IsNullOrWhiteSpace(txt_Gia.Text))
            {
                if (int.TryParse(txt_Gia.Text, out int gia) && gia > 0)
                {
                    services.Price = gia;
                }
                else
                {
                    MessageBox.Show("Giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            await dbConnection.SuaDichVu("Services", services);

            await LoadDataToDataGridView();

            txt_Tên.Clear();
            txt_Gia.Clear();


            MessageBox.Show("Đã cập nhật hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDichVu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDichVu.SelectedRows[0];
                string Tendichvu = selectedRow.Cells["Name"].Value.ToString();
                string Gia = selectedRow.Cells["Price"].Value.ToString();


                txt_Tên.Text = Tendichvu;
                txt_Gia.Text = Gia;

            }
            else
            {
                txt_Tên.Clear();
                txt_Gia.Clear();

            }
        }
    }
}
