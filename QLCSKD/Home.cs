using QLCSKD.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSKD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Addform(Form f)
        {
            this.pn_content.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pn_content.Controls.Add(f);
            f.Show();
        }
        public void DisplayUsername(string u_name)
        {
            lb_name.Text = u_name;
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Đã Thoát Chương Trình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
        private void pic_logo_Click(object sender, EventArgs e)
        {
            this.pn_content.Controls.Clear();
        }
        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            var f = new DoanhThu();
            Addform(f);
        }
        private void btn_phong_Click(object sender, EventArgs e)
        {
            var f = new Phong();
            Addform(f);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            var f = new HoaDon();
            Addform(f);
        }
    }
}
