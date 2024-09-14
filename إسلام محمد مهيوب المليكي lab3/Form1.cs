using System;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = txtOperation1.Text;
            string operation2 = txtOperation2.Text;
            string intermediateResult = "";
            string finalResult = "";

            // التأكد من صحة المدخلات
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2) && double.TryParse(txtNumber3.Text, out number3))
            {
                // تحديد أولويات العمليات
                if (HasHigherPriority(operation1, operation2))
                {
                    // إجراء العملية الأولى أولاً
                    intermediateResult = PerformOperation(number1, number2, operation1).ToString();
                    if (intermediateResult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الأولى غير صحيحة", " تحذير ");
                        txtOperation1.Text = "";
                        txtOperation1.Focus();
                        return;
                    }

                    // إجراء العملية الثانية على الناتج الوسيط
                    finalResult = PerformOperation(Convert.ToDouble(intermediateResult), number3, operation2).ToString();
                    if (finalResult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الثانية غير صحيحة.", " تحذير ");
                        txtOperation2.Text = "";
                        txtOperation2.Focus();
                        return;
                    }
                }
                else
                {
                    // إجراء العملية الثانية أولاً
                    intermediateResult = PerformOperation(number2, number3, operation2).ToString();
                    if (intermediateResult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الثانية غير صحيحة", " تحذير ");
                        txtOperation2.Text = "";
                        txtOperation2.Focus();
                        return;
                    }

                    // إجراء العملية الأولى على الناتج الوسيط
                    finalResult = PerformOperation(number1, Convert.ToDouble(intermediateResult), operation1).ToString();
                    if (finalResult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الأولى غير صحيحة.", " تحذير ");
                        txtOperation1.Text = "";
                        txtOperation1.Focus();
                        return;
                    }
                }

                txtResult.Text = finalResult.ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم صحيحة."," تحذير ");
            }
        }

        private double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    // إرجاع أي قيمة للتحقق من خطأ
                    return double.NaN; // عملية غير صحيحة
            }
        }

        // دالة لتحديد الأولوية بين العمليتين
        private bool HasHigherPriority(string op1, string op2)
        {
            if ((op1 == "*" || op1 == "/") && (op2 == "+" || op2 == "-"))
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
