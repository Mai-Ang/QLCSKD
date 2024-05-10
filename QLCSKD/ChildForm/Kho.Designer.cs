namespace QLCSKD.ChildForm
{
    partial class Kho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.cb_vt = new System.Windows.Forms.ComboBox();
            this.cb_ps = new System.Windows.Forms.ComboBox();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.txt_ttb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ttb = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtg_content = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_content)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 228);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 10;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.cb_vt);
            this.bunifuGroupBox1.Controls.Add(this.cb_ps);
            this.bunifuGroupBox1.Controls.Add(this.cb_tt);
            this.bunifuGroupBox1.Controls.Add(this.txt_ttb);
            this.bunifuGroupBox1.Controls.Add(this.label4);
            this.bunifuGroupBox1.Controls.Add(this.label3);
            this.bunifuGroupBox1.Controls.Add(this.label2);
            this.bunifuGroupBox1.Controls.Add(this.lb_ttb);
            this.bunifuGroupBox1.Controls.Add(this.btnthem);
            this.bunifuGroupBox1.Controls.Add(this.btnsua);
            this.bunifuGroupBox1.Controls.Add(this.btnxoa);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(34, 27);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(816, 189);
            this.bunifuGroupBox1.TabIndex = 4;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Quản Lý Thiết Bị";
            // 
            // cb_vt
            // 
            this.cb_vt.FormattingEnabled = true;
            this.cb_vt.Items.AddRange(new object[] {
            "Hành Lang",
            "Phòng Bếp",
            "Phòng Ngủ",
            "Phòng Tắm"});
            this.cb_vt.Location = new System.Drawing.Point(161, 88);
            this.cb_vt.Name = "cb_vt";
            this.cb_vt.Size = new System.Drawing.Size(166, 27);
            this.cb_vt.TabIndex = 119;
            // 
            // cb_ps
            // 
            this.cb_ps.FormattingEnabled = true;
            this.cb_ps.Items.AddRange(new object[] {
            "Phòng 1",
            "Phòng 2",
            "Phòng 3",
            "Phòng 4",
            "Phòng 5",
            "Phòng 6",
            "Phòng 7",
            "Phòng 8",
            "Phòng 9",
            "Phòng 10"});
            this.cb_ps.Location = new System.Drawing.Point(461, 32);
            this.cb_ps.Name = "cb_ps";
            this.cb_ps.Size = new System.Drawing.Size(166, 27);
            this.cb_ps.TabIndex = 118;
            // 
            // cb_tt
            // 
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "Hư ",
            "Bình Thường"});
            this.cb_tt.Location = new System.Drawing.Point(461, 83);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(166, 27);
            this.cb_tt.TabIndex = 118;
            // 
            // txt_ttb
            // 
            this.txt_ttb.Location = new System.Drawing.Point(161, 32);
            this.txt_ttb.Name = "txt_ttb";
            this.txt_ttb.Size = new System.Drawing.Size(166, 26);
            this.txt_ttb.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 116;
            this.label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 116;
            this.label3.Text = "Phòng số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 116;
            this.label2.Text = "Vị trí";
            // 
            // lb_ttb
            // 
            this.lb_ttb.AutoSize = true;
            this.lb_ttb.Location = new System.Drawing.Point(72, 39);
            this.lb_ttb.Name = "lb_ttb";
            this.lb_ttb.Size = new System.Drawing.Size(83, 19);
            this.lb_ttb.TabIndex = 116;
            this.lb_ttb.Text = "Tên Thiết Bị";
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(599, 143);
            this.btnthem.MaximumSize = new System.Drawing.Size(300, 100);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 31);
            this.btnthem.TabIndex = 113;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(750, 143);
            this.btnsua.MaximumSize = new System.Drawing.Size(300, 100);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(60, 31);
            this.btnsua.TabIndex = 115;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(676, 143);
            this.btnxoa.MaximumSize = new System.Drawing.Size(300, 100);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(68, 31);
            this.btnxoa.TabIndex = 114;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 241);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG THIẾT BỊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dtg_content);
            this.panel3.Location = new System.Drawing.Point(34, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 172);
            this.panel3.TabIndex = 0;
            // 
            // dtg_content
            // 
            this.dtg_content.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_content.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_content.Location = new System.Drawing.Point(0, 0);
            this.dtg_content.Name = "dtg_content";
            this.dtg_content.Size = new System.Drawing.Size(816, 172);
            this.dtg_content.TabIndex = 0;
            this.dtg_content.SelectionChanged += new System.EventHandler(this.dtg_content_SelectionChanged_1);
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Kho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.Kho_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.ComboBox cb_ps;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.TextBox txt_ttb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ttb;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtg_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_vt;
    }
}