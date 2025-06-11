namespace Billing_Invoice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            numericUpDown1.ValueChanged += UpdateValues;
            numericUpDown2.ValueChanged += UpdateValues;
            numericUpDown3.ValueChanged += UpdateValues;
            numericUpDown4.ValueChanged += UpdateValues;

            //button1.Click += Checkout;
        }

        private void UpdateValues(object? sender, EventArgs e)
        {

            const int samsungTabPrice = 2000;
            const int stylusPenPrice = 1000;
            const int stylusTipsPrice = 1500;
            const int screenProtectorPrice = 1800;

            int qtySamsungTab = (int)numericUpDown1.Value;
            int qtyStylusPen = (int)numericUpDown2.Value;
            int qtyStylusTips = (int)numericUpDown3.Value;
            int qtyScreenProtector = (int)numericUpDown4.Value;

            int totalSamsungTab = qtySamsungTab * samsungTabPrice;
            int totalStylusPen = qtyStylusPen * stylusPenPrice;
            int totalStylusTips = qtyStylusTips * stylusTipsPrice;
            int totalScreenProtector = qtyScreenProtector * screenProtectorPrice;

            textBox1.Text = totalSamsungTab.ToString();
            textBox2.Text = totalStylusPen.ToString();
            textBox3.Text = totalStylusTips.ToString();
            textBox4.Text = totalScreenProtector.ToString();

            int overallTotal = totalSamsungTab + totalStylusPen + totalStylusTips + totalScreenProtector;
            textBox6.Text = overallTotal.ToString();

            double discountPercentage = 0;
            if (overallTotal > 20000)
                discountPercentage = 20;
            else if (overallTotal > 15000)
                discountPercentage = 15;
            else if (overallTotal > 10000)
                discountPercentage = 10;
            else if (overallTotal > 5000)
                discountPercentage = 5;

            double discountAmount = overallTotal * (discountPercentage / 100);
            double finalPrice = overallTotal - discountAmount;

            textBox7.Text = $"{discountPercentage}%";
            textBox5.Text = finalPrice.ToString("F2");

            if (overallTotal == 0)
            {
                MessageBox.Show("Please select at least one product quantity to calculate the total.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void Checkout(object? sender, EventArgs e)
        //{
        //    Form3 form3 = new Form3();
        //    form3.Show();
        //    this.Hide();
        //}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
