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
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataReader SqlDataReader;

        private void HoSoHocSinh_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            con.Close();
        }

        public void HienThi()
        {
            SexCBB.Items.Add("Nam");
            SexCBB.Items.Add("Nữ");
            LHCBB.Items.Clear();
            string sqlselect = @"select IDLOPHOC from LOPHOC";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                LHCBB.Items.Add(SqlDataReader[0].ToString());
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"INSERT into HOCSINH values (@IDHS, @Ten, @NS, @DiaChi, @LH)";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@IDHS", IDtxt.Text);
            cmd.Parameters.AddWithValue("@Ten", Nametxt.Text);
            cmd.Parameters.AddWithValue("@NS", NgaySinhtxt.Text);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChitxt.Text);
            cmd.Parameters.AddWithValue("@LH", LHCBB.SelectedItem);
            SqlDataReader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Đã Tiếp Nhận Học Sinh!");
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            IDtxt.Clear();
            Nametxt.Clear();
            DiaChitxt.Clear();
            Emailtxt.Clear();
        }
    }
}
