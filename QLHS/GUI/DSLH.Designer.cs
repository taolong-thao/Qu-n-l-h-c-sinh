namespace QLHS.GUI
{
    partial class DSLH
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
            this.ListLH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.GVCNtxt = new System.Windows.Forms.TextBox();
            this.SStxt = new System.Windows.Forms.TextBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListLH)).BeginInit();
            this.SuspendLayout();
            // 
            // ListLH
            // 
            this.ListLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListLH.Location = new System.Drawing.Point(12, 12);
            this.ListLH.Name = "ListLH";
            this.ListLH.RowHeadersWidth = 51;
            this.ListLH.RowTemplate.Height = 24;
            this.ListLH.Size = new System.Drawing.Size(508, 233);
            this.ListLH.TabIndex = 3;
            this.ListLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListLH_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Lớp học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "GVCN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sĩ Số:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(622, 22);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(151, 22);
            this.IDtxt.TabIndex = 7;
            // 
            // GVCNtxt
            // 
            this.GVCNtxt.Location = new System.Drawing.Point(622, 60);
            this.GVCNtxt.Name = "GVCNtxt";
            this.GVCNtxt.Size = new System.Drawing.Size(151, 22);
            this.GVCNtxt.TabIndex = 8;
            // 
            // SStxt
            // 
            this.SStxt.Location = new System.Drawing.Point(622, 97);
            this.SStxt.Name = "SStxt";
            this.SStxt.Size = new System.Drawing.Size(151, 22);
            this.SStxt.TabIndex = 9;
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(612, 156);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(115, 32);
            this.Updatebutton.TabIndex = 10;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // DSLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 255);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.SStxt);
            this.Controls.Add(this.GVCNtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListLH);
            this.Name = "DSLH";
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.DSLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox GVCNtxt;
        private System.Windows.Forms.TextBox SStxt;
        private System.Windows.Forms.Button Updatebutton;
    }
}