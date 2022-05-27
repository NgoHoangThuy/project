using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLonCSDL
{
    public partial class frm_QuanLySach : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-STN8R37\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from SANPHAM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public frm_QuanLySach()
        {
            InitializeComponent();
            
        }

        

        private void btnXem_Click(object sender, EventArgs e)
        {
            txtidsp.Text = "";
            txttensp.Text = "";
            Txtncc.Text = "";
            txtgianhap.Text = "";
            txtidlh.Text = "";
            txtSoluong.Text = "";
            txtmota.Text = "";
            txtngungban.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "insert into SANPHAM values('"+txtidsp.Text+"','"+txttensp.Text+ "','"+Txtncc.Text+ "','"+txtidlh.Text+ "','"+txtgianhap.Text+ "','"+txtSoluong.Text+"','"+txtmota.Text+"','"+txtngungban+"')";
            command.ExecuteNonQuery();
            loaddata();
        }
        

        private void frm_QuanLySach_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidsp.ReadOnly = true;
            txtgianhap.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtidsp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttensp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            Txtncc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtgianhap.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtidlh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoluong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtmota.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtngungban.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from SANPHAM where IDSP = '" +txtidsp.Text+ "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update SANPHAM set tensp='"+txttensp.Text+"',idncc = '"+Txtncc.Text+"',idlh ='"+txtidlh.Text+"',soluongcon = '"+txtSoluong.Text+"',mota='"+txtmota+"',ngungban = '"+txtngungban+"' where IDSP = '"+txtidsp.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void txtMasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
