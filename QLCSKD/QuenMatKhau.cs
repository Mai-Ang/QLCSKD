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
    public partial class QuenMatKhau : Form
    {
        private DangNhap dangnhap;
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        public QuenMatKhau(DangNhap dangnhap)
        {
            InitializeComponent();
            this.dangnhap = dangnhap;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            XacNhanDoi xacNhanDoi = new XacNhanDoi();
            xacNhanDoi.Show();
            this.Close();
        }
    }
}
