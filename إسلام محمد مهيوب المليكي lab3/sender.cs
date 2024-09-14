using System;
using System.Drawing;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab3
{
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
            // ربط الأزرار بالأحداث
            btnYellow.Click += new EventHandler(traingforsender);
            btnRed.Click += new EventHandler(traingforsender);
            btnGreen.Click += new EventHandler(traingforsender);

            // ربط الـ Labels بالأحداث
            device1.Click += new EventHandler(traingforsender);
            device2.Click += new EventHandler(traingforsender);
        }
        // الدالة التي تتعامل مع الضغط على الأزرار
        // الدالة التي تتعامل مع الضغط على الأزرار أو الـ Labels
        private void traingforsender(object sender, EventArgs e)
        {
            if (sender == btnYellow)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (sender == btnRed)
            {
                button1.BackColor = Color.Red;
            }
            else if (sender == btnGreen)
            {
                button1.BackColor = Color.Green;
            }
            else if (sender == device1)
            {
                button1.Text = device1.Text;
            }
            else if (sender == device2)
            {
                button1.Text = device2.Text;
            }
        }
    }
}
