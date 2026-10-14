namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(323, 114);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(210, 27);
            txtDonGia.TabIndex = 0;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(323, 156);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(210, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(323, 193);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(210, 27);
            txtGiamGia.TabIndex = 2;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = SystemColors.ControlDark;
            lblTongTien.Location = new Point(323, 232);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(210, 42);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            lblTongTien.Click += lblTongTien_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(323, 290);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(439, 290);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 117);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 6;
            label1.Text = "Đơn giá dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 159);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 7;
            label2.Text = "Số lượng khách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 200);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 8;
            label3.Text = "% giảm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 408);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
