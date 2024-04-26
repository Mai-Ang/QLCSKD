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
            cb_numberphong.DisplayMember = "Name";
        }
    }
}
