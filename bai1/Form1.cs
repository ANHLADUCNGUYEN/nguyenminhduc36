namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra dữ liệu đầu vào có bị trống hoặc nhập chữ không
            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // Mặc định giảm giá là 0 nếu người dùng không nhập gì
            double giamGia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {

                if (!double.TryParse(txtGiamGia.Text, out giamGia) || giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("Vui lòng nhập % giảm giá là một số từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            // Tự động tính: Tổng tiền = (Đơn giá × Số lượng) × (100 - % Giảm) / 100
            double tongTien = (donGia * soLuong) * (100 - giamGia) / 100;

            // Hiển thị kết quả (định dạng phân cách hàng nghìn)
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();

            // Đặt lại kết quả hiển thị
            lblTongTien.Text = "0 VNĐ";

            // Đưa con trỏ chuột về ô Đơn giá
            txtDonGia.Focus();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

