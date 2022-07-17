using System.Windows.Forms;
using HtmlAgilityPack;
using System.Drawing;
using System;

namespace FormsTask8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _operationName;
        private string _currencyName;

        private void CheckedRadioButtonColor(RadioButton rb)
        {
            if (rb.Checked)
            {
                rb.BackColor = ColorTranslator.FromHtml("#45526c");
                rb.ForeColor = ColorTranslator.FromHtml("#f5f4f4");
            }
            else
            {
                rb.BackColor = default;
                rb.ForeColor = default;
            }

            sellUsdTextBox.ForeColor = ColorTranslator.FromHtml("#45526c");
            sellEurTextBox.ForeColor = ColorTranslator.FromHtml("#45526c");
            buyUsdTextBox.ForeColor = ColorTranslator.FromHtml("#45526c");
            buyEurTextBox.ForeColor = ColorTranslator.FromHtml("#45526c");

            switch (_operationName)
            {
                case "sell" when _currencyName == "usd":
                    sellUsdTextBox.ForeColor = ColorTranslator.FromHtml("#5aa897");
                    break;
                case "sell" when _currencyName == "eur":
                    sellEurTextBox.ForeColor = ColorTranslator.FromHtml("#5aa897");
                    break;
                case "buy" when _currencyName == "usd":
                    buyUsdTextBox.ForeColor = ColorTranslator.FromHtml("#5aa897");
                    break;
                case "buy" when _currencyName == "eur":
                    buyEurTextBox.ForeColor = ColorTranslator.FromHtml("#5aa897");
                    break;
            }
        }

        private void sellRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _operationName = "sell";
            CheckedRadioButtonColor(sellRadioButton);
        }

        private void buyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _operationName = "buy";
            CheckedRadioButtonColor(buyRadioButton);
        }

        private void eurRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currencyName = "eur";
            CheckedRadioButtonColor(eurRadioButton);
        }

        private void usdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currencyName = "usd";
            CheckedRadioButtonColor(usdRadioButton);
        }

        private void bankRateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bankRateCheckBox.Checked == false)
            {
                buyUsdTextBox.Clear();
                buyEurTextBox.Clear();
                sellUsdTextBox.Clear();
                sellEurTextBox.Clear();
                toTextBox.Clear();
            }
            else
            {
                EnableBankRate();
            }
        }

        private void EnableBankRate()
        {
            const string url = "https://privatbank.ua/";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            sellEurTextBox.Text = doc.DocumentNode.SelectNodes("//*[@id=\"EUR_sell\"]/text()")[0].InnerText.Trim();
            sellUsdTextBox.Text = doc.DocumentNode.SelectNodes("//*[@id=\"USD_sell\"]/text()")[0].InnerText.Trim();
            buyEurTextBox.Text = doc.DocumentNode.SelectNodes("//*[@id=\"EUR_buy\"]/text()")[0].InnerText.Trim();
            buyUsdTextBox.Text = doc.DocumentNode.SelectNodes("//*[@id=\"USD_buy\"]/text()")[0].InnerText.Trim();
        }

        private void buyUsdTextBox_MouseHover(object sender, EventArgs e)
        {
            var buyUsdTextBoxToolTip = new ToolTip();
            buyUsdTextBoxToolTip.SetToolTip(buyUsdTextBox, "Dollar buying rate goes here");
        }

        private void buyEurTextBox_MouseHover(object sender, EventArgs e)
        {
            var buyEurTextBoxToolTip = new ToolTip();
            buyEurTextBoxToolTip.SetToolTip(buyEurTextBox, "Euro buying rate goes here");
        }

        private void sellUsdTextBox_MouseHover(object sender, EventArgs e)
        {
            var sellUsdTextBoxToolTip = new ToolTip();
            sellUsdTextBoxToolTip.SetToolTip(sellUsdTextBox, "Dollar selling rate goes here");
        }

        private void sellEurTextBox_MouseHover(object sender, EventArgs e)
        {
            var sellEurTextBoxToolTip = new ToolTip();
            sellEurTextBoxToolTip.SetToolTip(sellEurTextBox, "Euro selling rate goes here");
        }

        private void fromTextBox_MouseHover(object sender, EventArgs e)
        {
            var fromTextBoxToolTip = new ToolTip();
            fromTextBoxToolTip.SetToolTip(fromTextBox, "The amount of money you want to convert");
        }

        private void toTextBox_MouseHover(object sender, EventArgs e)
        {
            var toTextBoxToolTip = new ToolTip();
            toTextBoxToolTip.SetToolTip(toTextBox, "Result");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            toTextBox.Clear();
            if (fromTextBox.Text.Trim().Length == 0 || !decimal.TryParse(fromTextBox.Text.Trim(), out var from)) return;
            switch (buyRadioButton.Checked)
            {
                case true when usdRadioButton.Checked:
                {
                    if (!decimal.TryParse(buyUsdTextBox.Text.Trim(), out var num)) return;
                    if (fromUahRadioButton.Checked && num != 0)
                        toTextBox.Text = "$" + Math.Round(from / num, 2);
                    else if (fromUsdOrEurRadioButton.Checked)
                        toTextBox.Text = "₴" + Math.Round(from * num, 2);
                    break;
                }
                case true when eurRadioButton.Checked:
                {
                    if (!decimal.TryParse(buyEurTextBox.Text.Trim(), out var num)) return;
                    if (fromUahRadioButton.Checked && num != 0)
                        toTextBox.Text = "€" + Math.Round(from / num, 2);
                    else if (fromUsdOrEurRadioButton.Checked)
                        toTextBox.Text = "₴" + Math.Round(from * num, 2);
                    break;
                }
            }

            switch (sellRadioButton.Checked)
            {
                case true when usdRadioButton.Checked:
                {
                    if (!decimal.TryParse(sellUsdTextBox.Text.Trim(), out var num)) return;
                    if (fromUahRadioButton.Checked && num != 0)
                        toTextBox.Text = "$" + Math.Round(from / num, 2);
                    else if (fromUsdOrEurRadioButton.Checked)
                        toTextBox.Text = "₴" + Math.Round(from * num, 2);
                    break;
                }
                case true when eurRadioButton.Checked:
                {
                    if (!decimal.TryParse(sellEurTextBox.Text.Trim(), out var num)) return;
                    if (fromUahRadioButton.Checked && num != 0)
                        toTextBox.Text = "€" + Math.Round(from / num, 2);
                    else if (fromUsdOrEurRadioButton.Checked)
                        toTextBox.Text = "₴" + Math.Round(from * num, 2);
                    break;
                }
            }
        }

        private void clearInputButton_Click(object sender, EventArgs e)
        {
            fromTextBox.Clear();
        }

        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            toTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var dialogExitResult = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogExitResult == DialogResult.Yes) Close();
        }
    }
}