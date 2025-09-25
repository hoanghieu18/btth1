using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btth1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)

            { thongbao += "\n\rBạn có ghi nhớ."; }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear(); this.txtPass.Clear(); this.txtUser.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}