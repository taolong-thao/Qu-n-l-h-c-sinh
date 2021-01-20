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
    public partial class NhapDiem : Form
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            HienThi1();
            HienThi2();
        }



        public void HienThi1()
        {
            con.Open();
            HocSinhCBB.Items.Clear();
            string sqlselect = @"select IDHOCSINH from HOCSINH";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                HocSinhCBB.Items.Add(SqlDataReader[0].ToString());
            }
            con.Close();
        }


        public void HienThi2()
        {
            con.Open();
            MonHocCBB.Items.Clear();
            string sqlselect = @"select IDMONHOC from MONHOC";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                MonHocCBB.Items.Add(SqlDataReader[0].ToString());
            }
            con.Close();
        }

        private void HocSinhCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"select TENHOCSINH from HOCSINH where IDHOCSINH =  @IDHS";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@IDHS", HocSinhCBB.SelectedItem);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();

            while (SqlDataReader.Read())
            {
                tenhstxt.Text = SqlDataReader[0].ToString();
            }
            con.Close();
        }

        private void MonHocCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"select TENMONHOC from MONHOC where IDMONHOC =  @IDMN";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@IDMN", MonHocCBB.SelectedItem);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();

            while (SqlDataReader.Read())
            {
                tenmhtxt.Text = SqlDataReader[0].ToString();
            }
            con.Close();
        }

        private void NhapDiembutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlselect = @"INSERT into KETQUA values (@IDHS, @IDMH, @Diem)";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("@IDHS", HocSinhCBB.Text);
            cmd.Parameters.AddWithValue("@IDMH", MonHocCBB.SelectedItem);
            cmd.Parameters.AddWithValue("@Diem", Diemtxt.Text);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Nhập Điểm Thành Công!");

        }
    }
}
