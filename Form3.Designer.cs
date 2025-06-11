namespace Billing_Invoice
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20F);
            label1.Location = new Point(224, 289);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(468, 40);
            label1.TabIndex = 0;
            label1.Text = "Thank you for shopping!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 20F);
            label2.Location = new Point(192, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(540, 40);
            label2.TabIndex = 1;
            label2.Text = "Your Order Has Been Placed!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.Premium_Vector___Modern_Abstract_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}