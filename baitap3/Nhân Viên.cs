using System.Windows.Forms;
using System;

namespace baitap3
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string Ten { get; set; }
        public string Luong { get; set; }

        // Constructor mặc định
        public Form2()
        {
            InitializeComponent();
        }

        // Constructor có tham số cho việc sửa
        public Form2(string msnv, string ten, string luong)
        {
            InitializeComponent();
            MSNV = msnv;
            Ten = ten;
            Luong = luong;

            // Hiển thị dữ liệu trên TextBox để chỉnh sửa
            textBox1.Text = MSNV;
            textBox2.Text = Ten;
            textBox3.Text = Luong;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox sau khi chỉnh sửa hoặc nhập mới
            MSNV = textBox1.Text;
            Ten = textBox2.Text;
            Luong = textBox3.Text;

            DialogResult = DialogResult.OK; // Trả về OK để form cha (Form1) xử lý
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form2 mà không lưu gì
        }
    }
}
