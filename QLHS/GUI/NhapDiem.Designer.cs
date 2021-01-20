namespace QLHS.GUI
{
    partial class NhapDiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HocSinhCBB = new System.Windows.Forms.ComboBox();
            this.MonHocCBB = new System.Windows.Forms.ComboBox();
            this.Diemtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tenhstxt = new System.Windows.Forms.TextBox();
            this.tenmhtxt = new System.Windows.Forms.TextBox();
            this.NhapDiembutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Học Sinh:";
            // 
            // HocSinhCBB
            // 
            this.HocSinhCBB.FormattingEnabled = true;
            this.HocSinhCBB.Location = new System.Drawing.Point(116, 45);
            this.HocSinhCBB.Name = "HocSinhCBB";
            this.HocSinhCBB.Size = new System.Drawing.Size(145, 24);
            this.HocSinhCBB.TabIndex = 5;
            this.HocSinhCBB.SelectedIndexChanged += new System.EventHandler(this.HocSinhCBB_SelectedIndexChanged);
            // 
            // MonHocCBB
            // 
            this.MonHocCBB.FormattingEnabled = true;
            this.MonHocCBB.Location = new System.Drawing.Point(116, 106);
            this.MonHocCBB.Name = "MonHocCBB";
            this.MonHocCBB.Size = new System.Drawing.Size(145, 24);
            this.MonHocCBB.TabIndex = 6;
            this.MonHocCBB.SelectedIndexChanged += new System.EventHandler(this.MonHocCBB_SelectedIndexChanged);
            // 
            // Diemtxt
            // 
            this.Diemtxt.Location = new System.Drawing.Point(116, 161);
            this.Diemtxt.Name = "Diemtxt";
            this.Diemtxt.Size = new System.Drawing.Size(145, 22);
            this.Diemtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên Học Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Môn Học:";
            // 
            // tenhstxt
            // 
            this.tenhstxt.Location = new System.Drawing.Point(425, 45);
            this.tenhstxt.Name = "tenhstxt";
            this.tenhstxt.Size = new System.Drawing.Size(152, 22);
            this.tenhstxt.TabIndex = 10;
            // 
            // tenmhtxt
            // 
            this.tenmhtxt.Location = new System.Drawing.Point(425, 106);
            this.tenmhtxt.Name = "tenmhtxt";
            this.tenmhtxt.Size = new System.Drawing.Size(152, 22);
            this.tenmhtxt.TabIndex = 11;
            // 
            // NhapDiembutton
            // 
            this.NhapDiembutton.Location = new System.Drawing.Point(362, 154);
            this.NhapDiembutton.Name = "NhapDiembutton";
            this.NhapDiembutton.Size = new System.Drawing.Size(152, 37);
            this.NhapDiembutton.TabIndex = 12;
            this.NhapDiembutton.Text = "Nhập Điểm";
            this.NhapDiembutton.UseVisualStyleBackColor = true;
            this.NhapDiembutton.Click += new System.EventHandler(this.NhapDiembutton_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 229);
            this.Controls.Add(this.NhapDiembutton);
            this.Controls.Add(this.tenmhtxt);
            this.Controls.Add(this.tenhstxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Diemtxt);
            this.Controls.Add(this.MonHocCBB);
            this.Controls.Add(this.HocSinhCBB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HocSinhCBB;
        private System.Windows.Forms.ComboBox MonHocCBB;
        private System.Windows.Forms.TextBox Diemtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tenhstxt;
        private System.Windows.Forms.TextBox tenmhtxt;
        private System.Windows.Forms.Button NhapDiembutton;
    }
}