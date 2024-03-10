using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
         
            currencyComboBox.Items.Add("USD");
            currencyComboBox.Items.Add("EUR");
            currencyComboBox.Items.Add("GBP");

           
            currencyComboBox.SelectedItem = "UAN";
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо введену суму
            if (double.TryParse(amountTextBox.Text, out double amount))
            {
                // Конвертуємо валюту
                double convertedAmount = ConvertCurrency(amount, currencyComboBox.SelectedItem.ToString());

                // Виводимо результат
                resultLabel.Text = $"{amount} {currencyComboBox.SelectedItem} = {convertedAmount:F2} UAH";
            }
            else
            {
                MessageBox.Show("Enter the correct amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double ConvertCurrency(double amount, string currency)
        {
            // Спростимо конвертацію: 1 USD = 27 UAH, 1 EUR = 32 UAH, 1 GBP = 35 UAH
            switch (currency)
            {
                case "USD":
                    return amount * 38;
                case "EUR":
                    return amount * 40;
                case "GBP":
                    return amount * 49;
                default:
                    return amount;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Отримуємо введену суму
            if (double.TryParse(amountTextBox.Text, out double amount))
            {
                // Конвертуємо валюту
                double convertedAmount = ConvertToUAH(amount, currencyComboBox.SelectedItem.ToString());

                // Виводимо результат
                resultLabel.Text = $"{amount} {currencyComboBox.SelectedItem} = {convertedAmount:F2} UAH";
            }
            else
            {
                MessageBox.Show("Enter the correct amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double ConvertToUAH(double amount, string currency)
        {
            // Спростимо конвертацію: 1 USD = 27 UAH, 1 EUR = 32 UAH, 1 GBP = 35 UAH
            switch (currency)
            {
                case "USD":
                    return amount / 27;
                case "EUR":
                    return amount / 32;
                case "GBP":
                    return amount / 35;
                default:
                    return amount;
            }
        }
    }
}
