using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.GUI
{
    public partial class DSLH : Form
    {
        public DSLH()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void DSLH_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            HienThi();
            IDtxt.Enabled = false;
        }

        private void HienThi()
        {
            con.Open();
            string sqlselect = @"select * from LOPHOC";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            ListLH.DataSource = table;
            con.Close();
        }

        private void ListLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = ListLH.CurrentRow.Index;
            IDtxt.Text = ListLH.Rows[i].Cells[0].Value.ToString();
            GVCNtxt.Text = ListLH.Rows[i].Cells[1].Value.ToString();
            SStxt.Text = ListLH.Rows[i].Cells[2].Value.ToString();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = @"update LOPHOC set GVCN=@GV, SISO=@SS where IDLOPHOC=@ID";
            adapter.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@GV", GVCNtxt.Text);
            cmd.Parameters.AddWithValue("@SS", SStxt.Text);
            cmd.Parameters.AddWithValue("@ID", IDtxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cập Nhật Thành Công!");
        }
    }
}
