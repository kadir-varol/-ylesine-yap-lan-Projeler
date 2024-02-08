using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myProject1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }



        public void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 599)
            {
                timer1.Stop();

            }
            if (panel2.Width >= 0)
                label1.Text = "Hesaplamalar yapılıyor";
            if (panel2.Width >= 100)
                label1.Text = "Yapay zekamız uğraşıyor";
            if (panel2.Width >= 200)
                label1.Text = "İnternetde nerelerde dolandığınıza bakınılıyor";
            if (panel2.Width >= 300)
                label1.Text = "Az kaldı";
            if (panel2.Width >= 400)
                label1.Text = "Son İncelemeler yapılıyor";
            if (panel2.Width >= 599)
            {
                label1.Text = "Cevabınız =";
                label2.Text = Form1.gdveri;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
