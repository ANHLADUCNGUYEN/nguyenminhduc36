namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                ListViewItem dongDaChon = lsvDanhSach.SelectedItems[0];

                // Đẩy dữ liệu ngược lên
                txtMaVT.Text = dongDaChon.Text;                  // Cột 1
                txtTenVT.Text = dongDaChon.SubItems[1].Text;     // Cột 2
                cmbDVT.Text = dongDaChon.SubItems[2].Text;       // Cột 3
                txtDonGia.Text = dongDaChon.SubItems[3].Text.Replace(",", ""); // Cột 4 (Bỏ dấu phẩy để dễ sửa)

                // Khóa ô Mã VT không cho sửa (để làm khóa chính cập nhật)
                txtMaVT.Enabled = false;
            }
            else
            {
                // Mở khóa lại nếu không chọn dòng nào
                txtMaVT.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text) ||
                cmbDVT.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Đơn giá phải là số
            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là một số lớn hơn hoặc bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            string maVT = txtMaVT.Text.Trim();

            // Validate: Không cho phép thêm nếu Mã VT đã tồn tại
            foreach (ListViewItem item in lsvDanhSach.Items)
            {
                if (item.Text == maVT) // Cột đầu tiên (Mã VT) chính là thuộc tính Text của ListViewItem
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại! Vui lòng nhập mã khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.Focus();
                    return;
                }
            }

            // Tạo một dòng mới cho ListView (ListViewItem)
            ListViewItem dongMoi = new ListViewItem(maVT);            // Cột 1: Mã VT
            dongMoi.SubItems.Add(txtTenVT.Text.Trim());               // Cột 2: Tên VT
            dongMoi.SubItems.Add(cmbDVT.Text);                        // Cột 3: ĐVT
            dongMoi.SubItems.Add(donGia.ToString("N0"));              // Cột 4: Đơn giá (định dạng số)

            // Thêm dòng đó vào ListView
            lsvDanhSach.Items.Add(dongMoi);

            // Làm sạch ô nhập liệu sau khi thêm
            LamMoiNhapLieu();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật lại thông tin cho dòng đang được chọn
                ListViewItem dongDaChon = lsvDanhSach.SelectedItems[0];
                // Không cập nhật Mã VT vì nó là khóa
                dongDaChon.SubItems[1].Text = txtTenVT.Text.Trim();
                dongDaChon.SubItems[2].Text = cmbDVT.Text;
                dongDaChon.SubItems[3].Text = donGia.ToString("N0");

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiNhapLieu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                // Hiện thông báo xác nhận dạng Yes/No
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hoiXoa == DialogResult.Yes)
                {
                    // Xóa dòng đang chọn
                    lsvDanhSach.Items.Remove(lsvDanhSach.SelectedItems[0]);
                    LamMoiNhapLieu();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Xóa toàn bộ danh sách. Bạn có chắc không?", "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (hoiXoa == DialogResult.Yes)
                {
                    lsvDanhSach.Items.Clear(); // Lệnh xóa tất cả các dòng
                    LamMoiNhapLieu();
                }
            }
        }
        private void LamMoiNhapLieu()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cmbDVT.SelectedIndex = -1;
            txtDonGia.Clear();
            txtMaVT.Enabled = true; // Mở khóa lại ô Mã VT
            txtMaVT.Focus();
        }
    }
}
