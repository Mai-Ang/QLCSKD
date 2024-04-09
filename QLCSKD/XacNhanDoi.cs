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
    public partial class XacNhanDoi : Form
    {
        private DangNhap dangnhap;
        public XacNhanDoi()
        {
            InitializeComponent();
        }
        public XacNhanDoi(DangNhap dangnhap)
        {
            InitializeComponent();
            this.dangnhap = dangnhap;
        }

        private void cb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txtmatkhaumoi.UseSystemPasswordChar = !cb_hienmatkhau.Checked;
            txt_xacnhanmatkhau.UseSystemPasswordChar = !cb_hienmatkhau.Checked;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            dangnhap.Show(this);
            this.Close();
        }
    }
}
