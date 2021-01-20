namespace QLHS.GUI
{
    partial class BaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDMHcbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenMHtxt = new System.Windows.Forms.TextBox();
            this.ListDiem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Môn Học:";
            // 
            // IDMHcbb
            // 
            this.IDMHcbb.FormattingEnabled = true;
            this.IDMHcbb.Location = new System.Drawing.Point(103, 16);
            this.IDMHcbb.Name = "IDMHcbb";
            this.IDMHcbb.Size = new System.Drawing.Size(165, 24);
            this.IDMHcbb.TabIndex = 1;
            this.IDMHcbb.SelectedIndexChanged += new System.EventHandler(this.IDMHcbb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Môn Học:";
            // 
            // TenMHtxt
            // 
            this.TenMHtxt.Location = new System.Drawing.Point(409, 16);
            this.TenMHtxt.Name = "TenMHtxt";
            this.TenMHtxt.Size = new System.Drawing.Size(165, 22);
            this.TenMHtxt.TabIndex = 3;
            // 
            // ListDiem
            // 
            this.ListDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDiem.Location = new System.Drawing.Point(28, 80);
            this.ListDiem.Name = "ListDiem";
            this.ListDiem.RowHeadersWidth = 51;
            this.ListDiem.RowTemplate.Height = 24;
            this.ListDiem.Size = new System.Drawing.Size(546, 285);
            this.ListDiem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả:";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListDiem);
            this.Controls.Add(this.TenMHtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDMHcbb);
            this.Controls.Add(this.label1);
            this.Name = "BaoCao";
            this.Text = "Báo Cáo Tổng Kết Môn Học";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDMHcbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenMHtxt;
        private System.Windows.Forms.DataGridView ListDiem;
        private System.Windows.Forms.Label label3;
    }
}