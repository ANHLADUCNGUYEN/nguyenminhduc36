namespace bai3
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbDVT = new ComboBox();
            txtTenVT = new TextBox();
            txtMaVT = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoaDong = new Button();
            btnXoaHet = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lsvDanhSach = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbDVT);
            groupBox1.Controls.Add(txtTenVT);
            groupBox1.Controls.Add(txtMaVT);
            groupBox1.Location = new Point(13, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhập liệu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Đơn giá nhập:";
            label4.Click += label4_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(119, 172);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Đơn vị tính:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên vật tư:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã vật tư:";
            // 
            // cmbDVT
            // 
            cmbDVT.FormattingEnabled = true;
            cmbDVT.Items.AddRange(new object[] { "Cái ", "Bộ", "Kg", "Mét" });
            cmbDVT.Location = new Point(119, 128);
            cmbDVT.Name = "cmbDVT";
            cmbDVT.Size = new Size(125, 28);
            cmbDVT.TabIndex = 2;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(119, 83);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(125, 27);
            txtTenVT.TabIndex = 1;
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(119, 40);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(125, 27);
            txtMaVT.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(27, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(141, 32);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(27, 79);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(94, 29);
            btnXoaDong.TabIndex = 3;
            btnXoaDong.Text = "Xoá dòng ";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Location = new Point(141, 79);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(94, 29);
            btnXoaHet.TabIndex = 4;
            btnXoaHet.Text = "Xoá toàn bộ";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Click += btnXoaHet_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnXoaDong);
            groupBox2.Controls.Add(btnXoaHet);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(12, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 112);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsvDanhSach);
            groupBox3.Location = new Point(352, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 324);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách vật tư";
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader1 });
            lsvDanhSach.FullRowSelect = true;
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(26, 53);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(404, 248);
            lsvDanhSach.TabIndex = 0;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            lsvDanhSach.SelectedIndexChanged += lsvDanhSach_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Đơn vị tính";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Đơn giá";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Mã VT";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "  ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox txtTenVT;
        private TextBox txtMaVT;
        private ComboBox cmbDVT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoaDong;
        private Button btnXoaHet;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView lsvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
