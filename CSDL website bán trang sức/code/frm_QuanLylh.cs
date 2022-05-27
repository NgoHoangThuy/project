using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSDL
{
    public partial class frm_QuanLylh : Form
    {
        SqlConnection conn = new SqlConnection(ConnectionString.con);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public frm_QuanLylh()
        {
            InitializeComponent();
            


        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            dtgQuanLyDocGia.DataSource = getQuanLyDocGia().Tables[0];
            dtgQuanLyDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgQuanLyDocGia.Enabled = false;
        }

        DataSet getQuanLyDocGia()
        {
            DataSet data = new DataSet();
            string query = "select * from loaihang";
            
            using (conn)
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                conn.Close();
                adapter.Fill(data);

            }
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("insert into loaihang values ('"+ txtMaNM.Text + " ',' " + txtTenNM.Text + " " +
                ") ", conn);
            cmd.ExecuteNonQuery();
              
                conn.Close();

            
            getQuanLyDocGia();

            
        }

        private void txtMaNM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtgQuanLyDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
