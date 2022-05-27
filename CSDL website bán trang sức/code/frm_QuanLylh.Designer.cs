
namespace BaiTapLonCSDL
{
    partial class frm_QuanLylh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNM = new System.Windows.Forms.TextBox();
            this.txtTenNM = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.dtgQuanLyDocGia = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDLH:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên loại hàng:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMaNM
            // 
            this.txtMaNM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNM.Location = new System.Drawing.Point(199, 16);
            this.txtMaNM.Name = "txtMaNM";
            this.txtMaNM.Size = new System.Drawing.Size(165, 34);
            this.txtMaNM.TabIndex = 8;
            this.txtMaNM.TextChanged += new System.EventHandler(this.txtMaNM_TextChanged);
            // 
            // txtTenNM
            // 
            this.txtTenNM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNM.Location = new System.Drawing.Point(199, 76);
            this.txtTenNM.Name = "txtTenNM";
            this.txtTenNM.Size = new System.Drawing.Size(166, 34);
            this.txtTenNM.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(199, 132);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(166, 74);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.Text = "";
            // 
            // dtgQuanLyDocGia
            // 
            this.dtgQuanLyDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgQuanLyDocGia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgQuanLyDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuanLyDocGia.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgQuanLyDocGia.Location = new System.Drawing.Point(12, 212);
            this.dtgQuanLyDocGia.Name = "dtgQuanLyDocGia";
            this.dtgQuanLyDocGia.RowHeadersWidth = 51;
            this.dtgQuanLyDocGia.RowTemplate.Height = 25;
            this.dtgQuanLyDocGia.Size = new System.Drawing.Size(988, 245);
            this.dtgQuanLyDocGia.TabIndex = 15;
            this.dtgQuanLyDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuanLyDocGia_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(568, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(878, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(730, 96);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frm_QuanLylh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 469);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgQuanLyDocGia);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNM);
            this.Controls.Add(this.txtMaNM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QuanLylh";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frm_QuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNM;
        private System.Windows.Forms.TextBox txtTenNM;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dtgQuanLyDocGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}