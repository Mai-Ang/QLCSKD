namespace QLCSKD.ChildForm
{
    partial class Khach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khach));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.pnlKhachChild = new System.Windows.Forms.Panel();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnDanhSach);
            this.bunifuPanel1.Controls.Add(this.btnHopDong);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(646, 57);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(13, 12);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(140, 32);
            this.btnDanhSach.TabIndex = 3;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHopDong.Location = new System.Drawing.Point(494, 12);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(140, 32);
            this.btnHopDong.TabIndex = 2;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // pnlKhachChild
            // 
            this.pnlKhachChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKhachChild.BackColor = System.Drawing.Color.White;
            this.pnlKhachChild.Location = new System.Drawing.Point(12, 89);
            this.pnlKhachChild.Name = "pnlKhachChild";
            this.pnlKhachChild.Size = new System.Drawing.Size(646, 472);
            this.pnlKhachChild.TabIndex = 2;
            // 
            // Khach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(670, 573);
            this.Controls.Add(this.pnlKhachChild);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "Khach";
            this.Text = "Khach";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Panel pnlKhachChild;
        private System.Windows.Forms.Button btnDanhSach;
    }
}