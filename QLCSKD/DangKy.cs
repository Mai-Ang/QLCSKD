﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSKD
{
    public partial class DangKy : Form
    {
        private ADO dbConnection;
        private DangNhap dangnhap;
        public DangKy(DangNhap dangnhap)
        {
            InitializeComponent();
            this.dangnhap = dangnhap;
            this.dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
        }

        private void cb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = !cb_hienmatkhau.Checked;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            dangnhap.Show();
            this.Close();
        }

        private async void btn_dangky_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_tentaikhoan.Text))
            {
                MessageBox.Show("Vui Long Nhap Ten");
                txt_tentaikhoan.Focus();
            }
            else if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Vui Long Nhap Mat Khau");
                txt_matkhau.Focus();
            }
            else if (txt_matkhau.Text != txt_xacnhanmatkhau.Text)
            {
                MessageBox.Show("Mat Khau Khong Trung Khop");
                txt_xacnhanmatkhau.Focus();
            }
            else if(string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Vui Long Nhap Email");
                txt_email.Focus();
            }
            else
            {
                string username = txt_tentaikhoan.Text;
                string email = txt_email.Text;
                //if (await dbConnection.KiemTraTaiKhoanTonTai(username) == true)
                //{
                //    ep_errorname.SetError(txt_tentaikhoan, "Tai Khoan Da Ton Tai");
                //}
                //else if (await dbConnection.KiemTraTaiKhoanTonTai(email) == true)
                //{
                //    ep_errorname.SetError(txt_email, "Mat Khau Da Duoc Su Dung");
                //}
                //else
                {
                    string password = txt_matkhau.Text;
                    await dbConnection.ThemNguoiDung("Accounts", username, password, email, "User");
                    MessageBox.Show("Ban Da Dang Ky Thanh Cong");
                    txt_tentaikhoan.Clear();
                    txt_matkhau.Clear();
                    txt_email.Clear();
                    txt_xacnhanmatkhau.Clear();
                    dangnhap.Show();
                    this.Close();
                }
            }
        }
    }
}
