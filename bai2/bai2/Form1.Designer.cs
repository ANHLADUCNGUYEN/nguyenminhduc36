namespace bai2
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
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            radThap = new RadioButton();
            radTrungBinh = new RadioButton();
            radKhanCap = new RadioButton();
            groupBox1 = new GroupBox();
            cmbLoaiSuCo = new ComboBox();
            chkPC = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            lblMaPhieu = new Label();
            lblNguoiYeuCau = new Label();
            lblNgayGhiNhan = new Label();
            lblLoaiSuCo = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(367, 72);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(125, 27);
            txtMaPhieu.TabIndex = 0;
            txtMaPhieu.TextChanged += txtMaPhieu_TextChanged;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(123, 76);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(131, 27);
            txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Location = new Point(176, 140);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(228, 27);
            dtpNgayGhiNhan.TabIndex = 2;
            dtpNgayGhiNhan.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radThap
            // 
            radThap.AutoSize = true;
            radThap.Location = new Point(11, 36);
            radThap.Name = "radThap";
            radThap.Size = new Size(63, 24);
            radThap.TabIndex = 3;
            radThap.TabStop = true;
            radThap.Text = "Thấp";
            radThap.UseVisualStyleBackColor = true;
            radThap.CheckedChanged += radThap_CheckedChanged;
            // 
            // radTrungBinh
            // 
            radTrungBinh.AutoSize = true;
            radTrungBinh.Location = new Point(80, 37);
            radTrungBinh.Name = "radTrungBinh";
            radTrungBinh.Size = new Size(100, 24);
            radTrungBinh.TabIndex = 4;
            radTrungBinh.TabStop = true;
            radTrungBinh.Text = "Trung bình";
            radTrungBinh.UseVisualStyleBackColor = true;
            radTrungBinh.CheckedChanged += radTrungBinh_CheckedChanged;
            // 
            // radKhanCap
            // 
            radKhanCap.AutoSize = true;
            radKhanCap.Location = new Point(186, 37);
            radKhanCap.Name = "radKhanCap";
            radKhanCap.Size = new Size(91, 24);
            radKhanCap.TabIndex = 5;
            radKhanCap.TabStop = true;
            radKhanCap.Text = "Khẩn cấp";
            radKhanCap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radKhanCap);
            groupBox1.Controls.Add(radThap);
            groupBox1.Controls.Add(radTrungBinh);
            groupBox1.Location = new Point(233, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 64);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mức độ ưu tiên";
            // 
            // cmbLoaiSuCo
            // 
            cmbLoaiSuCo.FormattingEnabled = true;
            cmbLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cmbLoaiSuCo.Location = new Point(22, 237);
            cmbLoaiSuCo.Name = "cmbLoaiSuCo";
            cmbLoaiSuCo.Size = new Size(177, 28);
            cmbLoaiSuCo.TabIndex = 7;
            // 
            // chkPC
            // 
            chkPC.AutoSize = true;
            chkPC.Location = new Point(22, 286);
            chkPC.Name = "chkPC";
            chkPC.Size = new Size(117, 24);
            chkPC.TabIndex = 8;
            chkPC.Text = "Máy tính bàn";
            chkPC.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(145, 286);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 9;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(22, 328);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 10;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(123, 328);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 11;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(290, 286);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(217, 96);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 12;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(378, 409);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 13;
            btnTaiAnh.Text = "tải ảnh";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.Location = new Point(70, 409);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(94, 29);
            btnGuiYeuCau.TabIndex = 14;
            btnGuiYeuCau.Text = "gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(213, 409);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(94, 29);
            btnNhapLai.TabIndex = 15;
            btnNhapLai.Text = "nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(290, 79);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(71, 20);
            lblMaPhieu.TabIndex = 16;
            lblMaPhieu.Text = "Mã phiếu";
            // 
            // lblNguoiYeuCau
            // 
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(12, 79);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(105, 20);
            lblNguoiYeuCau.TabIndex = 17;
            lblNguoiYeuCau.Text = "Người yêu cầu";
            // 
            // lblNgayGhiNhan
            // 
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(12, 145);
            lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            lblNgayGhiNhan.Size = new Size(105, 20);
            lblNgayGhiNhan.TabIndex = 18;
            lblNgayGhiNhan.Text = "Ngày ghi nhận";
            // 
            // lblLoaiSuCo
            // 
            lblLoaiSuCo.AutoSize = true;
            lblLoaiSuCo.Location = new Point(22, 214);
            lblLoaiSuCo.Name = "lblLoaiSuCo";
            lblLoaiSuCo.Size = new Size(76, 20);
            lblLoaiSuCo.TabIndex = 19;
            lblLoaiSuCo.Text = "Loại sự cố";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(lblLoaiSuCo);
            Controls.Add(lblNgayGhiNhan);
            Controls.Add(lblNguoiYeuCau);
            Controls.Add(lblMaPhieu);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(chkDienThoai);
            Controls.Add(chkMayIn);
            Controls.Add(chkLaptop);
            Controls.Add(chkPC);
            Controls.Add(cmbLoaiSuCo);
            Controls.Add(groupBox1);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;
        private RadioButton radThap;
        private RadioButton radTrungBinh;
        private RadioButton radKhanCap;
        private GroupBox groupBox1;
        private ComboBox cmbLoaiSuCo;
        private CheckBox chkPC;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
        private Label lblMaPhieu;
        private Label lblNguoiYeuCau;
        private Label lblNgayGhiNhan;
        private Label lblLoaiSuCo;
    }
}
