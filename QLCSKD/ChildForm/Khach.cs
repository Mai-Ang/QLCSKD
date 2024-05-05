using QLCSKD.ChildForm.KhachChild;
using QLCSKD.ChildForm.KhachChlid;
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
    public partial class Khach : Form
    {
        public Khach()
        {
            InitializeComponent();
        }

        private void Addform(Form f)
        {
            this.pnlKhachChild.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlKhachChild.Controls.Add(f);
            f.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            var f = new Danhsachluutru();
            Addform(f);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            var f = new QuanLyHopDong();
            Addform(f);
        }
    }
}
