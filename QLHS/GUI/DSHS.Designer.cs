namespace QLHS.GUI
{
    partial class DSHS
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
            this.ListHS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDhstxt = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.NStxt = new System.Windows.Forms.DateTimePicker();
            this.DCtxt = new System.Windows.Forms.TextBox();
            this.IDLHtxt = new System.Windows.Forms.TextBox();
            this.Tentxt = new System.Windows.Forms.TextBox();
            this.IDHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListHS)).BeginInit();
            this.SuspendLayout();
            // 
            // ListHS
            // 
            this.ListHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListHS.Location = new System.Drawing.Point(12, 54);
            this.ListHS.Name = "ListHS";
            this.ListHS.RowHeadersWidth = 51;
            this.ListHS.RowTemplate.Height = 24;
            this.ListHS.Size = new System.Drawing.Size(436, 260);
            this.ListHS.TabIndex = 0;
            this.ListHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListHS_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Học Sinh:";
            // 
            // IDhstxt
            // 
            this.IDhstxt.Location = new System.Drawing.Point(104, 19);
            this.IDhstxt.Name = "IDhstxt";
            this.IDhstxt.Size = new System.Drawing.Size(170, 22);
            this.IDhstxt.TabIndex = 2;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(301, 17);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(82, 24);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Seacrh";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(670, 273);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 29;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // NStxt
            // 
            this.NStxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NStxt.Location = new System.Drawing.Point(576, 198);
            this.NStxt.Name = "NStxt";
            this.NStxt.Size = new System.Drawing.Size(183, 22);
            this.NStxt.TabIndex = 28;
            // 
            // DCtxt
            // 
            this.DCtxt.Location = new System.Drawing.Point(576, 235);
            this.DCtxt.Name = "DCtxt";
            this.DCtxt.Size = new System.Drawing.Size(183, 22);
            this.DCtxt.TabIndex = 27;
            // 
            // IDLHtxt
            // 
            this.IDLHtxt.Location = new System.Drawing.Point(576, 161);
            this.IDLHtxt.Name = "IDLHtxt";
            this.IDLHtxt.Size = new System.Drawing.Size(183, 22);
            this.IDLHtxt.TabIndex = 26;
            // 
            // Tentxt
            // 
            this.Tentxt.Location = new System.Drawing.Point(576, 128);
            this.Tentxt.Name = "Tentxt";
            this.Tentxt.Size = new System.Drawing.Size(183, 22);
            this.Tentxt.TabIndex = 25;
            // 
            // IDHS
            // 
            this.IDHS.Location = new System.Drawing.Point(576, 92);
            this.IDHS.Name = "IDHS";
            this.IDHS.Size = new System.Drawing.Size(183, 22);
            this.IDHS.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID Lớp Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên Học Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Học Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin học sinh:";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(549, 273);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 30;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // DSHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.NStxt);
            this.Controls.Add(this.DCtxt);
            this.Controls.Add(this.IDLHtxt);
            this.Controls.Add(this.Tentxt);
            this.Controls.Add(this.IDHS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.IDhstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListHS);
            this.Name = "DSHS";
            this.Text = "Danh Sách Học Sinh";
            this.Load += new System.EventHandler(this.DSHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDhstxt;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.DateTimePicker NStxt;
        private System.Windows.Forms.TextBox DCtxt;
        private System.Windows.Forms.TextBox IDLHtxt;
        private System.Windows.Forms.TextBox Tentxt;
        private System.Windows.Forms.TextBox IDHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addbutton;
    }
}