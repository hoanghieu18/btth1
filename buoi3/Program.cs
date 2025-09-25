using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DangNhapApp
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: " + this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: " + this.txtPass.Text;

            if (this.chkNho.Checked == true)
            {
                thongbao += "\n\rBạn có ghi nhớ.";
            }

            MessageBox.Show(thongbao, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện khi nhấn nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
        }

        // Sự kiện khi nhấn nút Dừng
        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
