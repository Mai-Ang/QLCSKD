using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLCSKD.ADO;
using System.Collections;
using System.Security.Policy;

namespace QLCSKD.ChildForm
{
    public partial class DoanhThu : Form
    {
        private ADO dbConnection;
        private Timer timer;
        public DoanhThu()
        {
            InitializeComponent();
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += CapNhatDataGrid;
            timer.Tick += Insert;
            timer.Tick += TongDoanhThu;
            timer.Tick += TongChi;
            timer.Tick += LoiNhuan;
            timer.Start();
        }
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            CapNhatDataGrid(sender, e);
            TongDoanhThu(sender, e);
            TongChi(sender, e);
            LoiNhuan(sender, e);
        }
        // Test Insert
        private async void Insert(object sender, EventArgs e)
        {
            var Trans = new Transaction
            {
                Ngay = DateTime.Now,
                Ten = "John Doe",
                STK = "1234567890",
                SoTien = 1000.0,
                NoiDung = "Sample transaction"
            };
            await dbConnection.ThemGiaoDich("Transaction",Trans);
        }
        // Task Doanh Thu Page
        private void TongDoanhThu(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(DataGridViewRow row in dtgrid_trans.Rows)
            {
                if (Convert.ToDouble(row.Cells[4].Value) > 0)
                {
                    sum += Convert.ToDouble(row.Cells[4].Value);
                }
            }
            lb_valuethu.Text = sum.ToString();
        }
        private void TongChi(object sender, EventArgs e)
        {
            double minus = 0;
            foreach (DataGridViewRow row in dtgrid_trans.Rows)
            {
                if(Convert.ToDouble(row.Cells[4].Value) < 0)
                {
                    minus += Convert.ToDouble(row.Cells[4].Value);
                }
            }
            lb_valuechi.Text = minus.ToString();
        }
        private void LoiNhuan(object sender, EventArgs e)
        {
            lb_valueln.Text = Convert.ToString(Convert.ToDouble(lb_valuethu.Text) - Convert.ToDouble(lb_valuechi.Text));
        }
        private async void CapNhatDataGrid(object sender, EventArgs e)
        {
            var transactions = await dbConnection.Trans_His("Transaction");
            transactions = transactions.OrderByDescending(t => t.Ngay).ToList();
            dtgrid_trans.DataSource = transactions;
        }
    }
}
