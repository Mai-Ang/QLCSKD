using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLCSKD.ADO;

namespace QLCSKD.ChildForm
{
    public partial class HoaDon : Form
    {
        private ADO dbConnection;
        public HoaDon()
        {
            InitializeComponent();
            dbConnection = new ADO("Admin", "9YtggVE1pjSZspeq");
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            cb_numberphong.DataSource = dbConnection.Get_List_Phong();
            CapNhatDataGrid(sender, e);
        }

        private async void CapNhatDataGrid(object sender, EventArgs e)
        {
            var invoices = await dbConnection.LsHoaDon("Invoices");
            invoices = invoices.OrderByDescending(t => t.Ngay).ToList();
            dtgrid_invoices.DataSource = invoices;
        }
        private void cb_numberphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_numberphong.SelectedIndex != -1) 
            {
                pn_crinvoices.Visible = true;
                txt_phong.Text = dbConnection.Get_Price("Phong");
                txt_giadien.Text = dbConnection.Get_Price("Dien");
                txt_gianuoc.Text = dbConnection.Get_Price("Nuoc");
            }
        }
        private void CheckInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private double TienPhuThu(object sender, EventArgs e)
        {
            double phuthu = 0;
            if (string.IsNullOrEmpty(txt_phuthu.Text))
            {
               return phuthu = 0;
            }
            else
            {
               return phuthu = Convert.ToDouble(txt_phuthu.Text);
            }
        }
        private double TienKhac(object sender, EventArgs e)
        {
            double khac = 0;
            if (string.IsNullOrEmpty(txt_khac.Text))
            {
                return khac = 0;
            }
            else
            {
                return khac = Convert.ToDouble(txt_khac.Text);
            }
        }
        private string NoiDung(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noidung.Text))
            {
                return "Trong";
            }
            else
            {
                return txt_noidung.Text;
            }
        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_dien.Text))
            {
                MessageBox.Show("Ban Chua Nhap Chi So Dien","Thong Bao",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_dien.Focus();
            }
            else if (string.IsNullOrEmpty(txt_dienmoi.Text))
            {
                MessageBox.Show("Ban Chua Nhap Chi So Dien Moi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_dienmoi.Focus();
            }
            else if (string.IsNullOrEmpty(txt_nuoc.Text))
            {
                MessageBox.Show("Ban Chua Nhap Chi So Nuoc", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nuoc.Focus();
            }
            else if (string.IsNullOrEmpty(txt_nuocmoi.Text))
            {
                MessageBox.Show("Ban Chua Nhap Chi So Nuoc Moi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nuocmoi.Focus();
            }
            else
            {
                var invoi = new Invoices
                {
                    Phong = cb_numberphong.Text,
                    Tienphong = Convert.ToDouble(txt_phong.Text),
                    CSD = Convert.ToDouble(txt_dien.Text),
                    CSDMoi = Convert.ToDouble(txt_dienmoi.Text),
                    TienDien = (Convert.ToDouble(txt_dienmoi.Text) - Convert.ToDouble(txt_dien.Text)) * Convert.ToDouble(txt_giadien.Text),
                    CSN = Convert.ToDouble(txt_nuoc.Text),
                    CSNMoi = Convert.ToDouble(txt_nuocmoi.Text),
                    TienNuoc = (Convert.ToDouble(txt_nuocmoi.Text) - Convert.ToDouble(txt_nuoc.Text)) * Convert.ToDouble(txt_gianuoc.Text),
                    PhuThu = TienPhuThu(sender, e),
                    Khac = TienKhac(sender, e),
                    TongTien = Convert.ToDouble(txt_tiendien.Text) + Convert.ToDouble(txt_tiennuoc.Text) + TienKhac(sender, e) + TienPhuThu(sender, e),
                    NoiDung = NoiDung(sender, e),
                    Ngay = DateTime.Now,
                    Status = "Chua Thanh Toan"
                };
                await dbConnection.ThemHoaDon("Invoices", invoi);
                MessageBox.Show("Tao Moi Mot Hoa Don Vao Luc " + DateTime.Now + " Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dien.Clear();
                txt_dienmoi.Clear();
                txt_nuoc.Clear();
                txt_nuocmoi.Clear();
                txt_noidung.Clear();
                txt_khac.Clear();
                txt_phuthu.Clear();
                CapNhatDataGrid(sender,e);
            }
        }
        // Function MoneyBill
        private string MoneyBill(string x, string x_new, string x_price)
        {
            double value_x = 0, value_x_new = 0;
            if (!string.IsNullOrEmpty(x) && !string.IsNullOrEmpty(x_new))
            {
                value_x = Convert.ToDouble(x);
                value_x_new = Convert.ToDouble(x_new);
                double price = Convert.ToDouble(x_price);
                return Convert.ToString((value_x_new - value_x) * price);
            }
            return "0";
        }
        private double TotalBill()
        {
            if(!string.IsNullOrEmpty(txt_tiendien.Text) && !string.IsNullOrEmpty(txt_tiennuoc.Text))
            {
                if (string.IsNullOrEmpty(txt_phuthu.Text) && string.IsNullOrEmpty(txt_khac.Text))
                {
                    return Convert.ToDouble(txt_tiendien.Text) + Convert.ToDouble(txt_tiennuoc.Text) + 0 + 0;
                }
                else if (!string.IsNullOrEmpty(txt_phuthu.Text) && string.IsNullOrEmpty(txt_khac.Text))
                {
                    return Convert.ToDouble(txt_tiendien.Text) + Convert.ToDouble(txt_tiennuoc.Text) + Convert.ToDouble(txt_phuthu.Text) + 0;
                }
                else if (string.IsNullOrEmpty(txt_phuthu.Text) && !string.IsNullOrEmpty(txt_khac.Text))
                {
                    return Convert.ToDouble(txt_tiendien.Text) + Convert.ToDouble(txt_tiennuoc.Text) + 0 + Convert.ToDouble(txt_khac.Text);
                }
                else if (!string.IsNullOrEmpty(txt_phuthu.Text) && !string.IsNullOrEmpty(txt_khac.Text))
                {
                    return Convert.ToDouble(txt_tiendien.Text) + Convert.ToDouble(txt_tiennuoc.Text) + Convert.ToDouble(txt_phuthu.Text) + Convert.ToDouble(txt_khac.Text);
                }
            }
            return 0;
        }
        private void txt_dien_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dien.Text) || !string.IsNullOrEmpty(txt_dienmoi.Text))
            {
               txt_tiendien.Text = MoneyBill(txt_dien.Text, txt_dienmoi.Text, txt_giadien.Text);
            }
            else
            {
                txt_tiendien.Text = "0";
            }
        }
        private void txt_dienmoi_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_dien.Text) || !string.IsNullOrEmpty(txt_dienmoi.Text))
            {
                txt_tiendien.Text = MoneyBill(txt_dien.Text, txt_dienmoi.Text, txt_giadien.Text);
            }
            else
            {
                txt_tiendien.Text = "0";
            }
        }
        private void txt_nuoc_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nuoc.Text) || !string.IsNullOrEmpty(txt_nuocmoi.Text))
            {
                txt_tiennuoc.Text = MoneyBill(txt_nuoc.Text, txt_nuocmoi.Text, txt_gianuoc.Text);
            }
        }
        private void txt_nuocmoi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nuoc.Text) || !string.IsNullOrEmpty(txt_nuocmoi.Text))
            {
                txt_tiennuoc.Text = MoneyBill(txt_nuoc.Text, txt_nuocmoi.Text, txt_gianuoc.Text);
            }
        }
        private void TotalBill_TextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tiendien.Text) || !string.IsNullOrEmpty(txt_tiennuoc.Text) || !string.IsNullOrEmpty(txt_phuthu.Text) || !string.IsNullOrEmpty(txt_khac.Text))
            {
                txt_tongtien.Text = Convert.ToString(TotalBill());
            }
            else
            {
                txt_tongtien.Text = "0";
            }
        }
    }
}
