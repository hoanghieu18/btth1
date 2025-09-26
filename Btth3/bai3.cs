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
        bool IsPrime(int so)
        {
            if (so < 2) return false;

            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                    return false;
            }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtSo.Text, out number))
            {
                cboSo.Items.Add(number);
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không phải là số hợp lệ!");
            }
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(txtSo.Text);
            for (int i = 1; i <= so; i++)
            {
                if ((so % i) == 0)
                {
                    listTinh.Items.Add(i);
                }
            }
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
            int so = int.Parse(cboSo.Text);
            int sum = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    sum += i;
                }
            }
            MessageBox.Show("Tổng các ước của " + so + " là: " + sum);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int count = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Số các ước của " + so + " là: " + count);
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int count = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    if (IsPrime(i))
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("Số các số nguyên tố của " + so + " là: " + count);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmUocSo_Load(object sender, EventArgs e)
        {

        }
    }
}
