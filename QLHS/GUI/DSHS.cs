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
    public partial class DSHS : Form
    {
        public DSHS()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void DSHS_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            HienThi();
            IDHS.Enabled = false;
            IDLHtxt.Enabled = false;
        }


        private void HienThi()
        {
            con.Open();
            string sqlselect = @"select * from HOCSINH";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            ListHS.DataSource = table;
            con.Close();
        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"select * from HOCSINH where IDHOCSINH = @ID";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@ID", IDhstxt.Text);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            ListHS.DataSource = table;
            con.Close();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            HoSoHocSinh HS = new HoSoHocSinh();
            this.Visible = false;
            HS.ShowDialog();
            this.Visible = true;
        }

        private void ListHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = ListHS.CurrentRow.Index;
            IDHS.Text = ListHS.Rows[i].Cells[0].Value.ToString();
            Tentxt.Text = ListHS.Rows[i].Cells[1].Value.ToString();
            IDLHtxt.Text = ListHS.Rows[i].Cells[4].Value.ToString();
            NStxt.Text = ListHS.Rows[i].Cells[2].Value.ToString();
            DCtxt.Text = ListHS.Rows[i].Cells[3].Value.ToString();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = @"update HOCSINH set TENHOCSINH=@Ten, NGAYSINH=@NgaySinh, DIACHI=@DC where IDHOCSINH=@ID";
            adapter.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@Ten", Tentxt.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", NStxt.Text);
            cmd.Parameters.AddWithValue("@DC", DCtxt.Text);
            cmd.Parameters.AddWithValue("@ID", IDHS.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cập Nhật Thành Công!");
        }
    }
}
