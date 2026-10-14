namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radThap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTrungBinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file
            OpenFileDialog openFile = new OpenFileDialog();
            // Chỉ cho phép chọn file định dạng hình ảnh (.jpg, .png)
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFile.Title = "Chọn ảnh chụp lỗi";

            // Nếu người dùng chọn file và bấm OK
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Load ảnh lên PictureBox
                picAnhLoi.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Lấy thông tin cơ bản
            string maPhieu = txtMaPhieu.Text;
            string nguoiYeuCau = txtNguoiYeuCau.Text;
            string ngayGhiNhan = dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy"); // Lấy ngày theo định dạng

            // Lấy mức độ ưu tiên
            string mucDo = "Chưa xác định";
            if (radThap.Checked) mucDo = "Thấp";
            else if (radTrungBinh.Checked) mucDo = "Trung bình";
            else if (radKhanCap.Checked) mucDo = "Khẩn cấp";

            // Lấy loại sự cố từ ComboBox
            string loaiSuCo = cmbLoaiSuCo.Text;

            // Lấy danh sách thiết bị từ CheckBox
            string thietBi = "";
            if (chkPC.Checked) thietBi += "- Máy tính bàn\n";
            if (chkLaptop.Checked) thietBi += "- Laptop\n";
            if (chkMayIn.Checked) thietBi += "- Máy in\n";
            if (chkDienThoai.Checked) thietBi += "- Điện thoại\n";

            // Kiểm tra xem đã chọn thiết bị nào chưa
            if (thietBi == "") thietBi = "Không có thiết bị cụ thể\n";

            // Gom toàn bộ thông tin thành một chuỗi tóm tắt
            string thongTinTomTat = $"MÃ PHIẾU: {maPhieu}\n" +
                                    $"NGƯỜI YÊU CẦU: {nguoiYeuCau}\n" +
                                    $"NGÀY GHI NHẬN: {ngayGhiNhan}\n" +
                                    $"MỨC ĐỘ ƯU TIÊN: {mucDo}\n" +
                                    $"LOẠI SỰ CỐ: {loaiSuCo}\n\n" +
                                    $"THIẾT BỊ ẢNH HƯỞNG:\n{thietBi}";

            // Hiển thị hộp thoại thông báo
            MessageBox.Show(thongTinTomTat, "Tóm tắt yêu cầu sự cố", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }
}
