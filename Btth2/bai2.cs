using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btth2
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblKieuChu_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;
            this.txtHoTen.Focus();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoTen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void grpKieuChu_Enter(object sender, EventArgs e)
        {

        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBai2_Load(object sender, EventArgs e)
        {

        }
    }
}
