namespace Billing_Invoice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 47);
            label1.Name = "label1";
            label1.Size = new Size(218, 48);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F);
            label2.Location = new Point(290, 121);
            label2.Name = "label2";
            label2.Size = new Size(296, 35);
            label2.TabIndex = 1;
            label2.Text = "Customer Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 212);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 2;
            label3.Text = "Customer ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(166, 269);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 3;
            label4.Text = "Customer Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(175, 326);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 326);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(324, 397);
            button1.Name = "button1";
            button1.Size = new Size(109, 35);
            button1.TabIndex = 8;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.Premium_Vector___Modern_Abstract_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 500);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
