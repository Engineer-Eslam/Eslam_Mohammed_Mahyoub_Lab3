using System;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab3
{
    public partial class Form3 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form3()
        {
            InitializeComponent();
            this.listBox1.Items.AddRange(op);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtr.ReadOnly = true;
            txtn1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn2.Text = txtr.Text = "";
            txtn1.Focus();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool validInput = true; // للتحقق من صحة الإدخال
            bool operationSelected = true; // للتحقق من تحديد عملية حسابية
            
            if (txtn1.Text.Trim() != "" && txtn2.Text.Trim() != "")
            {
                try
                {
                    x = Convert.ToDouble(txtn1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("العدد الأول غير صالح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtn1.Clear();
                    txtn1.Focus();
                    validInput = false;
                }

                try
                {
                    y = Convert.ToDouble(txtn2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("العدد الثاني غير صالح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtn2.Clear();
                    txtn2.Focus();
                    validInput = false;
                }

                if (validInput)
                {
                    switch (listBox1.SelectedIndex)
                    {
                        case 0: z = x + y; break;
                        case 1: z = x - y; break;
                        case 2: z = x * y; break;
                        case 3:
                            if (y != 0)
                            {
                                z = x / y;
                            }
                            else
                            {
                                MessageBox.Show("لا يمكن القسمة على صفر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                operationSelected = false;
                            }
                            break;
                        default:
                            MessageBox.Show("يرجى اختيار عملية حسابية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            operationSelected = false;
                            break;
                    }

                    if (operationSelected)
                    {
                        txtr.Text = z.ToString();
                    }
                    else
                    {
                        txtr.Clear(); // إفراغ مربع النص إذا لم يتم إجراء العملية
                    }
                }
            }
        }
    }
}
        



    
