using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double? accumulatedValue = null;
        private string operation = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNumber(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                textBox1.Text += b.Text;
            }
        }

        private void Operations(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (double.TryParse(textBox1.Text, out double operand))
                {
                    if (accumulatedValue == null)
                    {
                        accumulatedValue = operand;
                    }
                    else if (operation != null)
                    {
                        PerformOperation(operand);
                    }

                    operation = b.Text;
                    textBox1.Text = null;
                }
                else
                {
                    MessageBox.Show("Invalid number");
                }
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double secondOperand))
            {
                if (operation != null && accumulatedValue != null)
                {
                    PerformOperation(secondOperand);
                    operation = null;
                }
            }
            else
            {
                MessageBox.Show("Invalid number");
            }
        }

        private void PerformOperation(double operand)
        {
            switch (operation)
            {
                case "+":
                    accumulatedValue += operand;
                    break;
                case "-":
                    accumulatedValue -= operand;
                    break;
                case "*":
                    accumulatedValue *= operand;
                    break;
                case "/":
                    if (operand == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                    }
                    else
                    {
                        accumulatedValue /= operand;
                    }
                    break;
                default:
                    MessageBox.Show("Unknown operation");
                    break;
            }

            if (accumulatedValue != null)
            {
                textBox1.Text = accumulatedValue.Value.ToString("F2");
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = null;
            accumulatedValue = null;
            operation = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isControl = char.IsControl(e.KeyChar);
            bool isDecimalSeparator = e.KeyChar == '.' && textBox1.Text.IndexOf('.') == -1;

            if (!(isDigit || isControl || isDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}