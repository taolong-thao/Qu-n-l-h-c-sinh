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
    public partial class TraCuu : Form
    {
        public TraCuu()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void TraCuu_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            IDHS.Enabled = false;
            IDLHtxt.Enabled = false;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            IDHS.Text = IDHStxt.Text;
            con.Open();
            string sqlselect = @"select TENHOCSINH from HOCSINH where IDHOCSINH = @ID";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@ID", IDHStxt.Text);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                Tentxt.Text = SqlDataReader[0].ToString();
            }
            con.Close();


            con.Open();
            string sqlselect1 = @"select IDLOPHOC from HOCSINH where IDHOCSINH = @ID";
            SqlCommand cmd1 = new SqlCommand(sqlselect1, con);
            cmd1.Parameters.AddWithValue("@ID", IDHStxt.Text);
            SqlDataReader SqlDataReader1 = cmd1.ExecuteReader();
            while (SqlDataReader1.Read())
            {
                IDLHtxt.Text = SqlDataReader1[0].ToString();
            }
            con.Close();


            con.Open();
            string sqlselect2 = @"select NGAYSINH from HOCSINH where IDHOCSINH = @ID";
            SqlCommand cmd2 = new SqlCommand(sqlselect2, con);
            cmd2.Parameters.AddWithValue("@ID", IDHStxt.Text);
            SqlDataReader SqlDataReader2 = cmd2.ExecuteReader();
            while (SqlDataReader2.Read())
            {
                NStxt.Text = SqlDataReader2[0].ToString();
            }
            con.Close();

            con.Open();
            string sqlselect3 = @"select DIACHI from HOCSINH where IDHOCSINH = @ID";
            SqlCommand cmd3 = new SqlCommand(sqlselect3, con);
            cmd3.Parameters.AddWithValue("@ID", IDHStxt.Text);
            SqlDataReader SqlDataReader3 = cmd3.ExecuteReader();
            while (SqlDataReader3.Read())
            {
                DCtxt.Text = SqlDataReader3[0].ToString();
            }
            con.Close();


            con.Open();
            string sqlselect4 = @"select * from KETQUA where IDHOCSINH = @ID";
            SqlCommand cmd4 = new SqlCommand(sqlselect4, con);
            cmd4.Parameters.AddWithValue("@ID", IDHStxt.Text);
            
            adapter.SelectCommand = cmd4;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dataGridViewDiem.DataSource = table;
            con.Close();

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd5 = new SqlCommand();
            cmd5 = con.CreateCommand();
            cmd5.CommandText = @"update HOCSINH set TENHOCSINH=@Ten, NGAYSINH=@NgaySinh, DIACHI=@DC where IDHOCSINH=@ID";
            adapter.SelectCommand = cmd5;
            cmd5.Parameters.AddWithValue("@Ten", Tentxt.Text);
            cmd5.Parameters.AddWithValue("@NgaySinh", NStxt.Text);
            cmd5.Parameters.AddWithValue("@DC", DCtxt.Text);
            cmd5.Parameters.AddWithValue("@ID", IDHStxt.Text);
            cmd5.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cập Nhật Thành Công!");
        }
    }
}
