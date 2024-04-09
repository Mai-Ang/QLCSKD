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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void Addform(Form f)
        {
            this.pn_contentstart.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pn_contentstart.Controls.Add(f);
            f.Show();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            var f = new DangNhap();
            Addform(f);
        }
    }
}
