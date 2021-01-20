namespace QLHS
{
    partial class QuanLy
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
            this.AddHSbutton = new System.Windows.Forms.Button();
            this.DSHSbutton = new System.Windows.Forms.Button();
            this.NBDMbutton = new System.Windows.Forms.Button();
            this.Tracuubutton = new System.Windows.Forms.Button();
            this.DSLopbutton = new System.Windows.Forms.Button();
            this.lapbctkbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddHSbutton
            // 
            this.AddHSbutton.Location = new System.Drawing.Point(12, 12);
            this.AddHSbutton.Name = "AddHSbutton";
            this.AddHSbutton.Size = new System.Drawing.Size(139, 42);
            this.AddHSbutton.TabIndex = 0;
            this.AddHSbutton.Text = "Thêm Học Sinh";
            this.AddHSbutton.UseVisualStyleBackColor = true;
            this.AddHSbutton.Click += new System.EventHandler(this.AddHSbutton_Click);
            // 
            // DSHSbutton
            // 
            this.DSHSbutton.Location = new System.Drawing.Point(12, 61);
            this.DSHSbutton.Name = "DSHSbutton";
            this.DSHSbutton.Size = new System.Drawing.Size(139, 42);
            this.DSHSbutton.TabIndex = 1;
            this.DSHSbutton.Text = "Danh Sách Học Sinh";
            this.DSHSbutton.UseVisualStyleBackColor = true;
            this.DSHSbutton.Click += new System.EventHandler(this.DSHSbutton_Click);
            // 
            // NBDMbutton
            // 
            this.NBDMbutton.Location = new System.Drawing.Point(326, 60);
            this.NBDMbutton.Name = "NBDMbutton";
            this.NBDMbutton.Size = new System.Drawing.Size(139, 42);
            this.NBDMbutton.TabIndex = 2;
            this.NBDMbutton.Text = "Nhận Bảng Điểm Môn";
            this.NBDMbutton.UseVisualStyleBackColor = true;
            this.NBDMbutton.Click += new System.EventHandler(this.NBDMbutton_Click);
            // 
            // Tracuubutton
            // 
            this.Tracuubutton.Location = new System.Drawing.Point(171, 12);
            this.Tracuubutton.Name = "Tracuubutton";
            this.Tracuubutton.Size = new System.Drawing.Size(139, 42);
            this.Tracuubutton.TabIndex = 3;
            this.Tracuubutton.Text = "Tra Cứu Học Sinh";
            this.Tracuubutton.UseVisualStyleBackColor = true;
            this.Tracuubutton.Click += new System.EventHandler(this.Tracuubutton_Click);
            // 
            // DSLopbutton
            // 
            this.DSLopbutton.Location = new System.Drawing.Point(171, 61);
            this.DSLopbutton.Name = "DSLopbutton";
            this.DSLopbutton.Size = new System.Drawing.Size(139, 42);
            this.DSLopbutton.TabIndex = 4;
            this.DSLopbutton.Text = "Danh Sách Lớp";
            this.DSLopbutton.UseVisualStyleBackColor = true;
            this.DSLopbutton.Click += new System.EventHandler(this.DSLopbutton_Click);
            // 
            // lapbctkbutton
            // 
            this.lapbctkbutton.Location = new System.Drawing.Point(326, 12);
            this.lapbctkbutton.Name = "lapbctkbutton";
            this.lapbctkbutton.Size = new System.Drawing.Size(139, 42);
            this.lapbctkbutton.TabIndex = 7;
            this.lapbctkbutton.Text = "Báo Cáo Tổng Kết Môn";
            this.lapbctkbutton.UseVisualStyleBackColor = true;
            this.lapbctkbutton.Click += new System.EventHandler(this.lapbctkbutton_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 115);
            this.Controls.Add(this.lapbctkbutton);
            this.Controls.Add(this.DSLopbutton);
            this.Controls.Add(this.Tracuubutton);
            this.Controls.Add(this.NBDMbutton);
            this.Controls.Add(this.DSHSbutton);
            this.Controls.Add(this.AddHSbutton);
            this.Name = "QuanLy";
            this.Text = "Quản Lý";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddHSbutton;
        private System.Windows.Forms.Button DSHSbutton;
        private System.Windows.Forms.Button NBDMbutton;
        private System.Windows.Forms.Button Tracuubutton;
        private System.Windows.Forms.Button DSLopbutton;
        private System.Windows.Forms.Button lapbctkbutton;
    }
}

