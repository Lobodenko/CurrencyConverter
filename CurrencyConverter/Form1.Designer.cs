namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(108, 72);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountTextBox.TabIndex = 0;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(402, 70);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(121, 24);
            this.currencyComboBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Transfer in hryvnias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(105, 167);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(44, 16);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Transfer to another currency";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Name = "CurrencyConverter";
            this.Text = "CurrencyConverter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button2;
    }
}

