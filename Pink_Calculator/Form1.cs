using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace Pink_Calculator
{
    public partial class Calculator : Form
    {
        Double result_value = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool button_minus_clicked = false;
        bool button_equal_clicked = false;
        
        public Calculator()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == "," || button.Text == "-")
            {
                if (!textBox_result.Text.Contains(",") || !textBox_result.Text.Contains("-"))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
                textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result_value != 0)
            {
                if (button_minus_clicked) 
                { button_equal_clicked = true; }
                else if (isOperationPerformed)
                { }
                else
                { button_equal.PerformClick(); }
                operationPerformed = button.Text;
                switch (operationPerformed)
                {
                    case "√":
                        CurrentOperation.Text = operationPerformed + "" + result_value; break;
                    case "sin":
                        CurrentOperation.Text = operationPerformed + "(" + result_value + " rad)"; break;
                    case "x²":
                        CurrentOperation.Text = result_value + "² "; break;
                    default:
                        CurrentOperation.Text = result_value + " " + operationPerformed; break;
                }
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                result_value = Double.Parse(textBox_result.Text);
                switch (operationPerformed)
                {
                    case "√":
                        CurrentOperation.Text = operationPerformed + "" + result_value; break;
                    case "sin":
                        CurrentOperation.Text = operationPerformed + "(" + result_value + " rad)"; break;
                    case "x²":
                        CurrentOperation.Text = result_value + "² "; break;
                    default:
                        CurrentOperation.Text = result_value + " " + operationPerformed; break;
                }
                isOperationPerformed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "")
            {
                string s = textBox_result.Text;
                s = s.Remove(textBox_result.Text.Length - 1, 1);
                textBox_result.Text = s;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result_value = 0;
            operationPerformed = default;
            CurrentOperation.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            button_equal.Enabled = false;
            button_equal_clicked = false;
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (result_value + Double.Parse(textBox_result.Text)).ToString(); break;
                case "-":
                    textBox_result.Text = (result_value - Double.Parse(textBox_result.Text)).ToString(); break;
                case "/":
                    textBox_result.Text = (result_value / Double.Parse(textBox_result.Text)).ToString(); break;
                case "×":
                    textBox_result.Text = (result_value * Double.Parse(textBox_result.Text)).ToString(); break;
                case "√":
                    textBox_result.Text = (Math.Sqrt(result_value).ToString()); break;
                case "sin":
                    textBox_result.Text = (Math.Sin(result_value).ToString()); break;
                case "x²":
                    textBox_result.Text = (Math.Pow(result_value, 2).ToString()); break;
                default:
                    textBox_result.Text = "0"; break;
            }
            result_value = Double.Parse(textBox_result.Text);
            CurrentOperation.Text = "";
            button_equal.Enabled = true;
            button_equal_clicked = true;
            isOperationPerformed = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            button_minus_clicked = true;
            if (result_value == 0)
            {
                button2.PerformClick();
                textBox_result.Text = ("-").ToString();
            }
            else if (result_value < 0 || textBox_result.Text.Contains("-"))
            {
                string s = textBox_result.Text;
                s = s.Replace("-", "");
                textBox_result.Text = s;
                result_value = Double.Parse(textBox_result.Text);
            }
            else if (result_value > 0 || !textBox_result.Text.Contains("-"))
            {
                textBox_result.Text = ("-" + result_value).ToString();
                result_value = Double.Parse(textBox_result.Text);
            }
        }
       

        private void textBox_range(object sender, EventArgs e)
        {
            bool d = int.TryParse(textBox_result.Text, out int i);
            if (d && (textBox_result.Text.Length >= 0 && textBox_result.Text.Length <= 7))
            {
                if (!(i >= -1000000 && i <= 1000000))
                {
                    textBox_result.Text = ("invalid value");
                    //tbNumericRange.Text = tbNumericRange.Text.Substring(0, 7);
                    //tbNumericRange.SelectionStart = tbNumericRange.Text.Length;
                }
            }
            else
            {
                if (!d && textBox_result.Text.Length > 7)
                {
                    if (!(i >= -1000000 && i <= 1000000))
                    {
                        textBox_result.Text = ("error");
                        //tbNumericRange.Text = tbNumericRange.Text.Substring(0, 7);
                        //tbNumericRange.SelectionStart = tbNumericRange.Text.Length;
                    }
                }
                else if (!d && textBox_result.Text.Length > 7 && !textBox_result.Text.Contains("-"))
                {
                    textBox_result.Text = ("error");
                }
            }
        }
        private void textBox_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            // запрет ввода символов с клавиатуры
            e.KeyChar = (char)Keys.None;
        }
    }
}
