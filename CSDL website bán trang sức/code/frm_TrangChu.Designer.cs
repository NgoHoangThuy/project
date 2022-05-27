
namespace BaiTapLonCSDL
{
    partial class frm_TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_qlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_qllh = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_qlncc = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_qltk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.quanLyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1111, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbi_DangXuat,
            this.mbi_Exit});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.quanLyToolStripMenuItem.Text = "Tài khoản";
            // 
            // mbi_DangXuat
            // 
            this.mbi_DangXuat.Name = "mbi_DangXuat";
            this.mbi_DangXuat.Size = new System.Drawing.Size(160, 26);
            this.mbi_DangXuat.Text = "Đăng xuất";
            this.mbi_DangXuat.Click += new System.EventHandler(this.mbi_DangXuat_Click);
            // 
            // mbi_Exit
            // 
            this.mbi_Exit.Name = "mbi_Exit";
            this.mbi_Exit.Size = new System.Drawing.Size(160, 26);
            this.mbi_Exit.Text = "Thoát";
            this.mbi_Exit.Click += new System.EventHandler(this.mbi_Exit_Click);
            // 
            // quanLyToolStripMenuItem1
            // 
            this.quanLyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbi_qlnv,
            this.mbi_qlsp,
            this.mbi_qllh,
            this.mbi_qlncc,
            this.mbi_qltk});
            this.quanLyToolStripMenuItem1.Name = "quanLyToolStripMenuItem1";
            this.quanLyToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.quanLyToolStripMenuItem1.Text = "Quản lý";
            // 
            // mbi_qlnv
            // 
            this.mbi_qlnv.Name = "mbi_qlnv";
            this.mbi_qlnv.Size = new System.Drawing.Size(234, 26);
            this.mbi_qlnv.Text = "Quản lý nhân viên";
            this.mbi_qlnv.Click += new System.EventHandler(this.mbi_Muon_Click);
            // 
            // mbi_qlsp
            // 
            this.mbi_qlsp.Name = "mbi_qlsp";
            this.mbi_qlsp.Size = new System.Drawing.Size(234, 26);
            this.mbi_qlsp.Text = "Quản lý sản phẩm";
            this.mbi_qlsp.Click += new System.EventHandler(this.mbi_Tra_Click);
            // 
            // mbi_qllh
            // 
            this.mbi_qllh.Name = "mbi_qllh";
            this.mbi_qllh.Size = new System.Drawing.Size(234, 26);
            this.mbi_qllh.Text = "Quản lý loại hàng";
            this.mbi_qllh.Click += new System.EventHandler(this.mbi_QuanLyNhanVien_Click);
            // 
            // mbi_qlncc
            // 
            this.mbi_qlncc.Name = "mbi_qlncc";
            this.mbi_qlncc.Size = new System.Drawing.Size(234, 26);
            this.mbi_qlncc.Text = "Quản lý nhà cung cấp";
            this.mbi_qlncc.Click += new System.EventHandler(this.mbi_QuanLySach_Click);
            // 
            // mbi_qltk
            // 
            this.mbi_qltk.Name = "mbi_qltk";
            this.mbi_qltk.Size = new System.Drawing.Size(234, 26);
            this.mbi_qltk.Text = "Quản lý thống kê";
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 666);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbi_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbi_qlnv;
        private System.Windows.Forms.ToolStripMenuItem mbi_Tra;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem mbi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLySach;
        private System.Windows.Forms.ToolStripMenuItem mbi_qlsp;
        private System.Windows.Forms.ToolStripMenuItem mbi_qllh;
        private System.Windows.Forms.ToolStripMenuItem mbi_qlncc;
        private System.Windows.Forms.ToolStripMenuItem mbi_qltk;
    }
}