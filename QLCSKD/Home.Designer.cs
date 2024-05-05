namespace QLCSKD
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pn_navi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_dichvu = new System.Windows.Forms.Button();
            this.btn_khach = new System.Windows.Forms.Button();
            this.btn_kho = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_phong = new System.Windows.Forms.Button();
            this.btn_doanhthu = new System.Windows.Forms.Button();
            this.lb_copyright = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_navi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_navi
            // 
            this.pn_navi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_navi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pn_navi.Controls.Add(this.label1);
            this.pn_navi.Controls.Add(this.pic_logo);
            this.pn_navi.Controls.Add(this.panel1);
            this.pn_navi.Controls.Add(this.btn_dichvu);
            this.pn_navi.Controls.Add(this.btn_khach);
            this.pn_navi.Controls.Add(this.btn_kho);
            this.pn_navi.Controls.Add(this.btn_hoadon);
            this.pn_navi.Controls.Add(this.btn_phong);
            this.pn_navi.Controls.Add(this.btn_doanhthu);
            this.pn_navi.Location = new System.Drawing.Point(0, 0);
            this.pn_navi.Margin = new System.Windows.Forms.Padding(2);
            this.pn_navi.Name = "pn_navi";
            this.pn_navi.Size = new System.Drawing.Size(233, 612);
            this.pn_navi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "STAY CONTROL";
            // 
            // pic_logo
            // 
            this.pic_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_logo.Image = global::QLCSKD.Properties.Resources.LogoApp;
            this.pic_logo.Location = new System.Drawing.Point(13, 11);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(52, 49);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 2;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Location = new System.Drawing.Point(26, 514);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 88);
            this.panel1.TabIndex = 6;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(62, 11);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(60, 19);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Admin";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(8, 42);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(165, 43);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Đăng Xuất ";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_dichvu
            // 
            this.btn_dichvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_dichvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dichvu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dichvu.ForeColor = System.Drawing.Color.White;
            this.btn_dichvu.Location = new System.Drawing.Point(34, 339);
            this.btn_dichvu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dichvu.Name = "btn_dichvu";
            this.btn_dichvu.Size = new System.Drawing.Size(165, 49);
            this.btn_dichvu.TabIndex = 5;
            this.btn_dichvu.Text = "Dịch Vụ";
            this.btn_dichvu.UseVisualStyleBackColor = false;
            this.btn_dichvu.Click += new System.EventHandler(this.btn_dichvu_Click);
            // 
            // btn_khach
            // 
            this.btn_khach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_khach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_khach.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khach.ForeColor = System.Drawing.Color.White;
            this.btn_khach.Location = new System.Drawing.Point(34, 178);
            this.btn_khach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_khach.Name = "btn_khach";
            this.btn_khach.Size = new System.Drawing.Size(165, 49);
            this.btn_khach.TabIndex = 3;
            this.btn_khach.Text = "Khách";
            this.btn_khach.UseVisualStyleBackColor = false;
            this.btn_khach.Click += new System.EventHandler(this.btn_khach_Click);
            // 
            // btn_kho
            // 
            this.btn_kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kho.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho.ForeColor = System.Drawing.Color.White;
            this.btn_kho.Location = new System.Drawing.Point(34, 285);
            this.btn_kho.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(165, 49);
            this.btn_kho.TabIndex = 4;
            this.btn_kho.Text = "Kho";
            this.btn_kho.UseVisualStyleBackColor = false;
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hoadon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Location = new System.Drawing.Point(34, 232);
            this.btn_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(165, 49);
            this.btn_hoadon.TabIndex = 2;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_phong
            // 
            this.btn_phong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_phong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_phong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phong.ForeColor = System.Drawing.Color.White;
            this.btn_phong.Location = new System.Drawing.Point(34, 124);
            this.btn_phong.Margin = new System.Windows.Forms.Padding(2);
            this.btn_phong.Name = "btn_phong";
            this.btn_phong.Size = new System.Drawing.Size(165, 49);
            this.btn_phong.TabIndex = 2;
            this.btn_phong.Text = "Phòng";
            this.btn_phong.UseVisualStyleBackColor = false;
            this.btn_phong.Click += new System.EventHandler(this.btn_phong_Click);
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.btn_doanhthu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doanhthu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthu.ForeColor = System.Drawing.Color.White;
            this.btn_doanhthu.Location = new System.Drawing.Point(34, 71);
            this.btn_doanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(165, 49);
            this.btn_doanhthu.TabIndex = 1;
            this.btn_doanhthu.Text = "Doanh Thu";
            this.btn_doanhthu.UseVisualStyleBackColor = false;
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // lb_copyright
            // 
            this.lb_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_copyright.AutoSize = true;
            this.lb_copyright.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_copyright.ForeColor = System.Drawing.Color.White;
            this.lb_copyright.Location = new System.Drawing.Point(556, 587);
            this.lb_copyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_copyright.Name = "lb_copyright";
            this.lb_copyright.Size = new System.Drawing.Size(127, 13);
            this.lb_copyright.TabIndex = 2;
            this.lb_copyright.Text = "Product Of AKCTeam";
            // 
            // pn_content
            // 
            this.pn_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_content.BackColor = System.Drawing.Color.Transparent;
            this.pn_content.Controls.Add(this.lb_copyright);
            this.pn_content.Location = new System.Drawing.Point(238, 0);
            this.pn_content.Margin = new System.Windows.Forms.Padding(2);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(686, 612);
            this.pn_content.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(924, 612);
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_navi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pn_navi.ResumeLayout(false);
            this.pn_navi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_content.ResumeLayout(false);
            this.pn_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_navi;
        private System.Windows.Forms.Button btn_khach;
        private System.Windows.Forms.Button btn_kho;
        private System.Windows.Forms.Button btn_phong;
        private System.Windows.Forms.Button btn_doanhthu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dichvu;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_copyright;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Button btn_hoadon;
    }
}