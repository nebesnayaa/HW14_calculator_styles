using System;
using System.Globalization;
using System.Windows;

namespace HW14_calculator
{
    public partial class MainWindow : Window
    {
        string Operand1 = "";
        string Operand2 = "";
        string Operator = "";

        bool OperatorActive = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "1";
            if (OperatorActive) 
                Operand2 += "1";
            else 
                Operand1 += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "2";
            if (OperatorActive) 
                Operand2 += "2";
            else 
                Operand1 += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "3";
            if (OperatorActive) 
                Operand2 += "3";
            else 
                Operand1 += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "4";
            if (OperatorActive) 
                Operand2 += "4";
            else 
                Operand1 += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "5";
            if (OperatorActive) 
                Operand2 += "5";
            else 
                Operand1 += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "6";
            if (OperatorActive) 
                Operand2 += "6";
            else 
                Operand1 += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "7";
            if (OperatorActive) 
                Operand2 += "7";
            else 
                Operand1 += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "8";
            if (OperatorActive) 
                Operand2 += "8";
            else 
                Operand1 += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "9";
            if (OperatorActive) 
                Operand2 += "9";
            else 
                Operand1 += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            result_TextBox.Text += "0";
            if (OperatorActive) 
                Operand2 += "0";
            else 
                Operand1 += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") 
                Operator = "+";
            OperatorActive = true;
            result_TextBox.Text += "+";
            if (Operand2 != "")
            {
                lastResult_TextBox.Text = Convert.ToString(Result());
                Operand1 = lastResult_TextBox.Text;
                Operand2 = "";
                result_TextBox.Text = lastResult_TextBox.Text;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") 
                Operator = "-";
            OperatorActive = true;
            result_TextBox.Text += "-";
            if (Operand2 != "")
            {
                lastResult_TextBox.Text = Convert.ToString(Result());
                Operand1 = lastResult_TextBox.Text;
                Operand2 = "";
                result_TextBox.Text = lastResult_TextBox.Text;
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (Operand2 == "")
                Operator = "*";
            OperatorActive = true;
            result_TextBox.Text += "*";
            if (Operand2 != "")
            {
                lastResult_TextBox.Text = Convert.ToString(Result());
                Operand1 = lastResult_TextBox.Text;
                Operand2 = "";
                result_TextBox.Text = lastResult_TextBox.Text;
            }

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") 
                Operator = "/";
            OperatorActive = true;
            result_TextBox.Text += "/";
            if (Operand2 != "")
            {
                lastResult_TextBox.Text = Convert.ToString(Result());
                Operand1 = lastResult_TextBox.Text;
                Operand2 = "";
                result_TextBox.Text = lastResult_TextBox.Text;
            }
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            lastResult_TextBox.Text = Result();
            Operand1 = lastResult_TextBox.Text;
            Operand2 = "";
            result_TextBox.Text = lastResult_TextBox.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            OperatorActive = false;
            result_TextBox.Text = "";
            lastResult_TextBox.Text = "";
            Operand1 = "";
            Operand2 = "";
            Operator = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = "";
            Operand2 = "";
        }

        private string Result()
        {
            if (Operator == "*")
            {
                Operand1 = Operand1.Replace(',', '.');
                Operand2 = Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
            }
            else if (Operator == "/")
            {
                if (Operand2 == "0")
                    return "Error";
                else
                {
                    Operand1 = Operand1.Replace(',', '.');
                    Operand2 = Operand2.Replace(',', '.');
                    return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) / (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
                }
            }
            else if (Operator == "+")
            {
                Operand1 = Operand1.Replace(',', '.');
                Operand2 = Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) + (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
            }
            else if (Operator == "-")
            {
                Operand1 = Operand1.Replace(',', '.');
                Operand2 = Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) - (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
            }
            return "";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (Operand1 == "")
            {
                Operand1 += "0,";
                result_TextBox.Text += "0,";
            }
            else if (Operand2 == "" && Operand1 != "" && (OperatorActive))
            {
                Operand2 += "0,";
                result_TextBox.Text += "0,";
            }
            else if (Operand2 != "" && Operand1 != "" && (OperatorActive))
            {
                Operand2 += ",";
                result_TextBox.Text += ",";
            }
            else
            {
                Operand1 += ",";
                result_TextBox.Text += ",";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (result_TextBox.Text == "")
                return;
            else
            {
                if (OperatorActive)
                {
                    if (result_TextBox.Text[result_TextBox.Text.Length - 1] == Operator[0])
                    {
                        result_TextBox.Text = result_TextBox.Text.Remove(result_TextBox.Text.Length - 1);
                    }
                    else
                    {
                        Operand2 = Operand2.Remove(Operand2.Length - 1);
                        result_TextBox.Text = result_TextBox.Text.Remove(result_TextBox.Text.Length - 1);
                    }
                }
                else
                {
                    Operand1 = Operand1.Remove(Operand1.Length - 1);
                    result_TextBox.Text = result_TextBox.Text.Remove(result_TextBox.Text.Length - 1);
                }
            }
        }
    }
}