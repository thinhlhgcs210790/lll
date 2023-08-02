namespace DOAN_QLBH.GUI
{
    partial class frm_thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongke));
            this.DGV_thongke = new System.Windows.Forms.DataGridView();
            this.btnTimTheoKhoangtg = new System.Windows.Forms.Button();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.txt_tong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_thongke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_thongke
            // 
            this.DGV_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_thongke.Location = new System.Drawing.Point(16, 245);
            this.DGV_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_thongke.Name = "DGV_thongke";
            this.DGV_thongke.RowHeadersWidth = 51;
            this.DGV_thongke.Size = new System.Drawing.Size(1129, 294);
            this.DGV_thongke.TabIndex = 89;
            // 
            // btnTimTheoKhoangtg
            // 
            this.btnTimTheoKhoangtg.BackColor = System.Drawing.Color.Chocolate;
            this.btnTimTheoKhoangtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTheoKhoangtg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoKhoangtg.Location = new System.Drawing.Point(8, 81);
            this.btnTimTheoKhoangtg.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimTheoKhoangtg.Name = "btnTimTheoKhoangtg";
            this.btnTimTheoKhoangtg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTimTheoKhoangtg.Size = new System.Drawing.Size(149, 59);
            this.btnTimTheoKhoangtg.TabIndex = 4;
            this.btnTimTheoKhoangtg.Text = "Tìm";
            this.btnTimTheoKhoangtg.UseVisualStyleBackColor = false;
            this.btnTimTheoKhoangtg.Click += new System.EventHandler(this.btnTimTheoKhoangtg_Click);
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "dd/MM/yyyy";
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(8, 36);
            this.dt_timetruoc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(167, 26);
            this.dt_timetruoc.TabIndex = 84;
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "dd/MM/yyyy";
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(177, 36);
            this.dt_timesau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(167, 26);
            this.dt_timesau.TabIndex = 85;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Chocolate;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(184, 81);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(143, 59);
            this.btn_load.TabIndex = 86;
            this.btn_load.Text = "Tìm tất cả hóa đơn";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_timesau);
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.dt_timetruoc);
            this.groupBox3.Controls.Add(this.btnTimTheoKhoangtg);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(353, 148);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Theo Thời Gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 48);
            this.label2.TabIndex = 93;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Chocolate;
            this.btn_tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtong.Location = new System.Drawing.Point(496, 181);
            this.btn_tinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(187, 49);
            this.btn_tinhtong.TabIndex = 94;
            this.btn_tinhtong.Text = "Tính Tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(691, 194);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(271, 34);
            this.txt_tong.TabIndex = 95;
            this.txt_tong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 554);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_thongke);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_thongke";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_thongke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_thongke;
        private System.Windows.Forms.Button btnTimTheoKhoangtg;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.TextBox txt_tong;
    }
}