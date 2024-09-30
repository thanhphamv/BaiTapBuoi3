using System.Windows.Forms;
using System;

namespace baitap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nút Thêm
        private void bthThem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); // Mở Form2 để thêm mới
            if (form.ShowDialog() == DialogResult.OK) // Nếu Form2 trả về OK
            {
                // Thêm dữ liệu mới vào DataGridView
                dataGridView1.Rows.Add(form.MSNV, form.Ten, form.Luong);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) // Kiểm tra xem có dòng nào được chọn không
            {
                // Lấy dữ liệu từ hàng hiện tại
                string msnv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string ten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string luong = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // Mở Form2 với dữ liệu để sửa
                Form2 form = new Form2(msnv, ten, luong);
                if (form.ShowDialog() == DialogResult.OK) // Nếu Form2 trả về OK
                {
                    // Cập nhật dữ liệu của hàng hiện tại sau khi sửa
                    dataGridView1.CurrentRow.Cells[0].Value = form.MSNV;
                    dataGridView1.CurrentRow.Cells[1].Value = form.Ten;
                    dataGridView1.CurrentRow.Cells[2].Value = form.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Xóa dòng được chọn
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        // Nút Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form1
        }
    }
}
