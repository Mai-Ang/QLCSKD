using DnsClient.Protocol;
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
        public string name;
        private DangNhap dangnhap;
        public DangNhap()
        {
            InitializeComponent();
            dbConnection = new ADO("User", "nCW1WEZazoccBmT3");
        }
        //public static class CurrentUser
        //{
        //    public static string u_name { get; set; }
        //}
        private void cb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_pass.UseSystemPasswordChar == true)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
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
            string username = txt_username.Text;
            string password = txt_pass.Text;
            if (await dbConnection.KiemTraDangNhap("Accounts", username, password) == true)
            {
                pn_failed.Visible = false;
                pn_success.Visible = true;
                //CurrentUser.u_name = username;
                await Task.Delay(3000);
                this.Hide();
                Home home = new Home();
                home.Show();
                //home.DisplayUsername(CurrentUser.u_name);
            }
            else
            {
                pn_failed.Visible = true;
            }
        }
    }
}
