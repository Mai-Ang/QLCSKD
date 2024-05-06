namespace QLCSKD.ChildForm.KhachChild
{
    partial class QuanLyHopDong
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
            this.dtgvHopDong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.txtThongTinLienHe = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lab7 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.lab8 = new System.Windows.Forms.Label();
            this.dtpkBegin = new System.Windows.Forms.DateTimePicker();
            this.lab5 = new System.Windows.Forms.Label();
            this.txtKhach = new System.Windows.Forms.TextBox();
            this.lab4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHopDong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvHopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 237);
            this.panel1.TabIndex = 0;
            // 
            // dtgvHopDong
            // 
            this.dtgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHopDong.Location = new System.Drawing.Point(0, 0);
            this.dtgvHopDong.Name = "dtgvHopDong";
            this.dtgvHopDong.Size = new System.Drawing.Size(630, 237);
            this.dtgvHopDong.TabIndex = 0;
            this.dtgvHopDong.SelectionChanged += new System.EventHandler(this.dtgvHopDong_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 62);
            this.panel2.TabIndex = 2;
            // 
            // lab1
            // 
            this.lab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(159, 9);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(318, 56);
            this.lab1.TabIndex = 43;
            this.lab1.Text = "Họp đồng thuê phòng trọ";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 134);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lab2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCCCD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtThongTinLienHe, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSoPhong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbLoai, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpkBegin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lab5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtKhach, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGia, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lab2
            // 
            this.lab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab2.Location = new System.Drawing.Point(3, 0);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(120, 33);
            this.lab2.TabIndex = 23;
            this.lab2.Text = "Tên khách hàng: ";
            this.lab2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lab6
            // 
            this.lab6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab6.Location = new System.Drawing.Point(255, 0);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(88, 33);
            this.lab6.TabIndex = 31;
            this.lab6.Text = "Số CCCD";
            this.lab6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCCCD.Location = new System.Drawing.Point(349, 3);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(62, 26);
            this.txtCCCD.TabIndex = 32;
            // 
            // lab3
            // 
            this.lab3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.Location = new System.Drawing.Point(20, 33);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(103, 33);
            this.lab3.TabIndex = 33;
            this.lab3.Text = "Thông tin liên hệ:";
            this.lab3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtThongTinLienHe
            // 
            this.txtThongTinLienHe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThongTinLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThongTinLienHe.ForeColor = System.Drawing.Color.Black;
            this.txtThongTinLienHe.Location = new System.Drawing.Point(129, 36);
            this.txtThongTinLienHe.Name = "txtThongTinLienHe";
            this.txtThongTinLienHe.Size = new System.Drawing.Size(118, 26);
            this.txtThongTinLienHe.TabIndex = 34;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoPhong.Location = new System.Drawing.Point(129, 69);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(118, 26);
            this.txtSoPhong.TabIndex = 36;
            // 
            // lab7
            // 
            this.lab7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab7.AutoSize = true;
            this.lab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab7.Location = new System.Drawing.Point(285, 66);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(58, 33);
            this.lab7.TabIndex = 37;
            this.lab7.Text = "Loại phòng:";
            this.lab7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbLoai
            // 
            this.cmbLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "KIOT",
            "Thường"});
            this.cmbLoai.Location = new System.Drawing.Point(349, 69);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(62, 28);
            this.cmbLoai.TabIndex = 38;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged);
            // 
            // lab8
            // 
            this.lab8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab8.AutoSize = true;
            this.lab8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab8.Location = new System.Drawing.Point(457, 66);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(74, 33);
            this.lab8.TabIndex = 39;
            this.lab8.Text = "Giá thuê:";
            this.lab8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpkBegin
            // 
            this.dtpkBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpkBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkBegin.Location = new System.Drawing.Point(129, 102);
            this.dtpkBegin.Name = "dtpkBegin";
            this.dtpkBegin.Size = new System.Drawing.Size(118, 26);
            this.dtpkBegin.TabIndex = 42;
            // 
            // lab5
            // 
            this.lab5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab5.Location = new System.Drawing.Point(20, 99);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(103, 35);
            this.lab5.TabIndex = 41;
            this.lab5.Text = "Ngày bắt đầu hợp đồng:";
            this.lab5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKhach
            // 
            this.txtKhach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKhach.Location = new System.Drawing.Point(129, 3);
            this.txtKhach.Name = "txtKhach";
            this.txtKhach.Size = new System.Drawing.Size(118, 26);
            this.txtKhach.TabIndex = 30;
            // 
            // lab4
            // 
            this.lab4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab4.Location = new System.Drawing.Point(41, 66);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(82, 33);
            this.lab4.TabIndex = 35;
            this.lab4.Text = "Số phòng:";
            this.lab4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGia.Location = new System.Drawing.Point(537, 69);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(84, 26);
            this.txtGia.TabIndex = 43;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(255, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 29);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(443, 102);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 29);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(349, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 29);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // QuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHopDong";
            this.Text = "QuanLyHopDong";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHopDong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvHopDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txtKhach;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.TextBox txtThongTinLienHe;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.DateTimePicker dtpkBegin;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}