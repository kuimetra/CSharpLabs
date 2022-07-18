using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Operation
        {
            None,
            Add,
            Sub,
            Mul,
            Div
        }

        private Operation _currentOperation = Operation.None;
        private Operation _previousOperation = Operation.None;

        private void numButton_Click(object sender, EventArgs e)
        {
            ErrorMessageCheck();
            calculateTextBox.Text += ((Button) sender).Text;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            ErrorMessageCheck();
            calculateTextBox.Text += ((Button) sender).Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text.Length > 0)
                calculateTextBox.Text = calculateTextBox.Text[..^1];
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            ErrorMessageCheck();
            _previousOperation = Operation.None;
            calculateTextBox.Clear();
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            ErrorMessageCheck();
            _currentOperation = ((Button) sender).Text switch
            {
                "+" => Operation.Add,
                "-" => Operation.Sub,
                "*" => Operation.Mul,
                "/" => Operation.Div,
                _ => _currentOperation
            };
            Calculate(_previousOperation);
            _previousOperation = _currentOperation;
            calculateTextBox.Text += ((Button) sender).Text;
        }


        private void ErrorMessageCheck()
        {
            if (calculateTextBox.Text == "DivByZero" || calculateTextBox.Text == "Error")
                calculateTextBox.Clear();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.TextLength == 0) return;
            if (_previousOperation != Operation.None)
                Calculate(_previousOperation);

            _previousOperation = Operation.None;
        }

        private void Calculate(Operation previousOperation)
        {
            try
            {
                if (previousOperation == Operation.None) return;

                List<double> numbers;
                switch (previousOperation)
                {
                    case Operation.Add:
                        if (_currentOperation == Operation.Sub)
                        {
                            _currentOperation = Operation.Add;
                            return;
                        }

                        numbers = calculateTextBox.Text.Split('+').Select(double.Parse).ToList();
                        calculateTextBox.Text = (numbers[0] + numbers[1]).ToString();
                        break;
                    case Operation.Sub:
                        var minusSignIndex = calculateTextBox.Text.LastIndexOf('-');
                        if (minusSignIndex > 0)
                        {
                            var firstNum = Convert.ToDouble(calculateTextBox.Text.Substring(0, minusSignIndex));
                            var secondNum = Convert.ToDouble(calculateTextBox.Text.Substring(minusSignIndex + 1));
                            calculateTextBox.Text = (firstNum - secondNum).ToString();
                        }

                        break;
                    case Operation.Mul:
                        if (_currentOperation == Operation.Sub)
                        {
                            _currentOperation = Operation.Mul;
                            return;
                        }

                        numbers = calculateTextBox.Text.Split('*').Select(double.Parse).ToList();
                        calculateTextBox.Text = (numbers[0] * numbers[1]).ToString();
                        break;
                    case Operation.Div:
                        if (_currentOperation == Operation.Sub)
                        {
                            _currentOperation = Operation.Div;
                            return;
                        }

                        numbers = calculateTextBox.Text.Split('/').Select(double.Parse).ToList();
                        calculateTextBox.Text = numbers[1] == 0 ? "DivByZero" : (numbers[0] / numbers[1]).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                calculateTextBox.Text = "Error";
            }
        }
    }
}