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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sB, iR, dArs, dAfp, sN;
            sB = double.Parse(textBox1.Text);
            dArs = sB * 0.0304;
            dAfp = sB * 0.0287;
            if (sB > 34685)
            {
                if (sB > 52027)
                {
                    if (sB > 72260)
                    {
                        iR = (sB - 72260) * 0.25 + 6648;
                    }
                    else { iR = (sB - 52027) * 0.20 + 2600; }
                }
                else { iR = (sB - 34685) * 0.15; }
            }
            else { iR = 0; }
            sN = sB - iR - dArs - dAfp;
            label2.Text = "$" + dArs.ToString();
            label11.Text = "$" + dAfp.ToString();
            label3.Text = "$" + iR.ToString();
            label4.Text = "$" + sN.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}