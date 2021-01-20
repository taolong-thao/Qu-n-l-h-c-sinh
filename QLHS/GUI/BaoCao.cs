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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void BaoCao_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);

            HienThi();

        }

        public void HienThi()
        {
            con.Open();
            IDMHcbb.Items.Clear();
            string sqlselect = @"select IDMONHOC from MONHOC";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                IDMHcbb.Items.Add(SqlDataReader[0].ToString());
            }
            con.Close();
        }
        private void IDMHcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"select TENMONHOC from MONHOC where IDMONHOC =  @IDMN";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@IDMN", IDMHcbb.SelectedItem);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();

            while (SqlDataReader.Read())
            {
                TenMHtxt.Text = SqlDataReader[0].ToString();
            }
            con.Close();



            con.Open();
            string sqlselect4 = @"select * from KETQUA where IDMONHOC = @ID";
            SqlCommand cmd4 = new SqlCommand(sqlselect4, con);
            cmd4.Parameters.AddWithValue("@ID", IDMHcbb.SelectedItem);

            adapter.SelectCommand = cmd4;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            ListDiem.DataSource = table;
            con.Close();

        }

    
    }
}
