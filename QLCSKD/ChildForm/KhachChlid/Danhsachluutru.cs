using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSKD.ChildForm.KhachChlid
{
    public partial class Danhsachluutru : Form
    {
        private ADO dbConnection;
        private IMongoCollection<BsonDocument> collection;

        public Danhsachluutru()
        {
            InitializeComponent();
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
            collection = dbConnection.GetCollection("Contract");
            this.Load += DanhSachLuuTru_Load;
        }

        private async void DanhSachLuuTru_Load(object sender, EventArgs e)
        {
            List<BsonDocument> documents = await collection.Find(new BsonDocument()).ToListAsync();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Tên Khách");
            dataTable.Columns.Add("Thông tin liên hệ");
            dataTable.Columns.Add("Số phòng");

            foreach (BsonDocument document in documents)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = document["_id"].ToString();
                row["Tên Khách"] = document["TenKhach"].ToString();
                row["Thông tin liên hệ"] = document["ThongTinLienHe"].ToString();
                row["Số phòng"] = document["SoPhong"].ToString();

                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
