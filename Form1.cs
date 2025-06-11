using System;
using System.Windows.Forms;

namespace Billing_Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isValidName = true;
            foreach (char c in textBox2.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    isValidName = false;
                    break;
                }
            }

            if (!isValidName)
            {
                MessageBox.Show("Customer Name must contain only alphabets and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(textBox3.Text, out _) || textBox3.Text.Length != 10)
            {
                MessageBox.Show("Phone Number must be 10 digits. Please Enter Valid Phone Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerDetails = $"Customer ID: {textBox1.Text}\nCustomer Name: {textBox2.Text}\nPhone Number: {textBox3.Text}";
            if (MessageBox.Show(customerDetails, "Confirm Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                new Form2().Show();
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
