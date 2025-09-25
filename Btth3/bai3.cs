using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btth3
{
    public partial class FrmUocSo : Form
    {
        public FrmUocSo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(txtSo.Text);
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void lstUocSo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void grpNhapSo_Enter(object sender, EventArgs e)
        {

        }

        private void grpUocSo_Enter(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {

        }

        private void btnChan_Click(object sender, EventArgs e)
        {

        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
