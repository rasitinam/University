using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy;
            double kilo;
            string cins;
            boy = Convert.ToDouble(textBox2.Text);
            kilo = Convert.ToDouble(textBox3.Text);
            cins = Convert.ToString(textBox1.Text);
            double idealkilo;
            if (cins == "E")
            {
                double idealkilo2 = 50 + 2.3 * (boy / 2.54 - 60);

                if (kilo == idealkilo2)
                {
                    sonucbox.Text = "�deal kilodas�n�z.";

                }
                else if (kilo < idealkilo2)
                {
                    sonucbox.Text = "�deal kilonun alt�ndas�n�z.�deal kilonuz" + idealkilo2.ToString("f2") + "kg olmal�.";

                }
                else if (kilo > idealkilo2)
                {
                    sonucbox.Text = "�deal kilonun �st�ndesiniz.�deal kilonuz" + idealkilo2.ToString("f2") + "kg olmal�.";

                }
            }
            else if (cins == "K")
            {
                double idealkilo1 = 45.5 + 2.3 * (boy / 2.54 - 60);

                if (kilo == idealkilo1)
                {
                    sonucbox.Text = "�deal kilodas�n�z.";

                }
                else if (kilo < idealkilo1)
                {
                    sonucbox.Text = "�deal kilonun alt�ndas�n�z.�deal kilonuz" + idealkilo1.ToString("f2") + "kg olmal�.";

                }
                else if (kilo > idealkilo1)
                {
                    sonucbox.Text = "�deal kilonun �st�ndesiniz.�deal kilonuz" + idealkilo1.ToString("f2") + "kg olmal�.";

                }
            }
            else
            {
                Console.WriteLine("Ge�ersiz karakter girdiniz.");
            }
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {


        }
    }
}