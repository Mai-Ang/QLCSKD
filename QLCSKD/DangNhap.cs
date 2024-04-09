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
    public partial class DangNhap : Form
    {
        private ADO dbConnection;
        public DangNhap()
        {
            InitializeComponent();
            dbConnection = new ADO("mongodb://localhost:27017/?readPreference=primary&appname=MongoDI", "QLCSKD");
        }

        private void cb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = !cb_hienmatkhau.Checked; ;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        { 
            DangKy dangKy = new DangKy(this);
            dangKy.Show();
            this.Hide();
        }

        private void llbquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Show();
            this.Hide();
        }

        private async void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_tendangnhap.Text;
            string password = txt_matkhau.Text;
            if (await dbConnection.KiemTraDangNhap("Accounts", username, password) == true)
            {
                MessageBox.Show("Dang Nhap Thanh Cong");
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Ten Dang Nhap Hoac Mat Khau Sai");
            }
        }
    }
}
