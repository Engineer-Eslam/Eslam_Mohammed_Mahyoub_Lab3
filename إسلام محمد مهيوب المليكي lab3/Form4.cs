using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true; // منع إدخال أي حرف غير رقمي
            }
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {
            btnTotal.Enabled = btnFact.Enabled = btnSqrt.Enabled = (txtN.Text.Trim() != "");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btnTotal.Enabled = btnFact.Enabled = btnSqrt.Enabled = false;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total of number = " + (Convert.ToInt32(txtN.Text) * (Convert.ToInt32(txtN.Text) + 1) / 2).ToString());
            txtN.Clear();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(txtN.Text);
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            MessageBox.Show("The Factorial of a number = " + result.ToString());
            txtN.Clear();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Square root of a a number = " + (Math.Sqrt(Convert.ToDouble(txtN.Text))).ToString());
            txtN.Clear();
        }
    }
}
