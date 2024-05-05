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
            collection = dbConnection.GetCollection("Services");
            this.Load += DichVu_Load;
        }

        private async void DichVu_Load(object sender, EventArgs e)
        {
            List<BsonDocument> documents = await collection.Find(new BsonDocument()).ToListAsync();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Tên dịch vụ");
            dataTable.Columns.Add("Tiền");

            foreach (BsonDocument document in documents)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = document["_id"].ToString();
                row["Tên dịch vụ"] = document["Name"].ToString();
                row["Tiền"] = document["Price"].ToString();

                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
