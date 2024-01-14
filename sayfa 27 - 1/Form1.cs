using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace otoparkv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sure;
            string tur;
            tur = Convert.ToString(textBox1.Text);
            sure = Convert.ToInt16(textBox2.Text);
            int hesaplanangün = sure / 24;
            int hesaplanansaat = sure % 24;
            int ödeme = 0;
            
            if (sure > 0 || sure <= 2)
            {
                if (tur == "O" || tur == "o")
                {
                    ödeme = 5;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");

                }
                if (tur == "K" || tur == "k")
                {
                    ödeme = 8;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");

                }
                if (tur == "I" || tur == "i" || tur == "ı")
                {
                    ödeme = 12;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");

                }
            }

            if (sure > 2 || sure < 10)       /*if (saat > 2 || saat < 10)*/
            {
                if (tur == "O" || tur == "o")
                {
                    ödeme = 5 + ((sure - 2) * 1);
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "K" || tur == "k")
                {
                    ödeme = 8 + ((sure - 2) * 2);
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "I" || tur == "i" || tur == "ı")
                {
                    ödeme = 12 + ((sure - 2) * 3);
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
            }
            if (sure >= 10 || sure <= 24)
            {
                if (tur == "O" || tur == "o")
                {
                    ödeme = 13;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "K" || tur == "k")
                {
                    ödeme = 18;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "I" || tur == "i" || tur == "ı")
                {
                    ödeme = 25;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }

            }
            if (sure > 24)
            {
                //if (saat >= 25 || saat<= 26)
                if (tur == "O" || tur == "o")
                {
                    hesaplanangün = (sure / 24) * 13; hesaplanansaat = ((sure % 24) - 2) * 1;
                    ödeme = hesaplanangün + hesaplanansaat + 5;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "K" || tur == "k")
                {
                    hesaplanangün = (sure / 24) * 18; hesaplanansaat = ((sure % 24) - 2) * 2;
                    ödeme = hesaplanangün + hesaplanansaat + 8;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
                if (tur == "I" || tur == "i" || tur == "ı")
                {
                    hesaplanangün = (sure / 24) * 25; hesaplanansaat = ((sure % 24) - 2) * 3;
                    ödeme = hesaplanangün + hesaplanansaat + 12;
                    textBox3.Text = (tur + " olduğu için " + ödeme + "Tl ödeme yapacaksınız.");
                }
            }
        }

        private void _TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
