using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chatdemo
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbrepass.Text != txbpass.Text)
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbpass.Text.Length < 10)
            {   
                MessageBox.Show("Mật khẩu quá đơn giản!\n     Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   

                this.Close();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số từ 0-9, /
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }

            // Kiểm tra xem đã đủ số ký tự để tạo thành ngày (dd/MM/yyyy) chưa
            if (!char.IsControl(e.KeyChar) && txbDate.Text.Length >= 10)
            {
                e.Handled = true; // Loại bỏ ký tự nếu vượt quá độ dài
                this.Close(); //Thoát tab đăng kí
            }
        }
    }
}
