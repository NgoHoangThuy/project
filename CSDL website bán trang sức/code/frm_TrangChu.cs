﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSDL
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void mbi_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
           
        }

        private void mbi_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mbi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mbi_Muon_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mbi_Tra_Click(object sender, EventArgs e)
        {
            frm_QuanLySach frm = new frm_QuanLySach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mbi_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_QuanLylh frm = new frm_QuanLylh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mbi_QuanLyDocGia_Click(object sender, EventArgs e)
        {
           
        }

        private void mbi_QuanLySach_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
