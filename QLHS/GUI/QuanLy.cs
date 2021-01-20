using QLHS.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void NBDMbutton_Click(object sender, EventArgs e)
        {
            NhapDiem ND = new NhapDiem();
            this.Visible = false;
            ND.ShowDialog();
            this.Visible = true;
        }

        private void AddHSbutton_Click(object sender, EventArgs e)
        {
            HoSoHocSinh HS = new HoSoHocSinh();
            this.Visible = false;
            HS.ShowDialog();
            this.Visible = true;
        }

        private void Tracuubutton_Click(object sender, EventArgs e)
        {
            TraCuu TC = new TraCuu();
            this.Visible = false;
            TC.ShowDialog();
            this.Visible = true;
        }

        private void lapbctkbutton_Click(object sender, EventArgs e)
        {
            BaoCao BC = new BaoCao();
            this.Visible = false;
            BC.ShowDialog();
            this.Visible = true;
        }

        private void DSHSbutton_Click(object sender, EventArgs e)
        {
            DSHS DSHS = new DSHS();
            this.Visible = false;
            DSHS.ShowDialog();
            this.Visible = true;
        }

        private void DSLopbutton_Click(object sender, EventArgs e)
        {
            DSLH DSLH = new DSLH();
            this.Visible = false;
            DSLH.ShowDialog();
            this.Visible = true;
        }
    }
}
