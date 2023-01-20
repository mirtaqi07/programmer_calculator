﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "1";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button6_Click(object sender, EventArgs e)
        {
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void Button9_Click(object sender, EventArgs e)
        {
        }

        private void Button8_Click(object sender, EventArgs e)
        {
        }

        private void Button7_Click(object sender, EventArgs e)
        {
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            textBox_enter.Text = textBox_enter.Text + "0";
        }

        private void Button16_Click(object sender, EventArgs e)
        {/*
            if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "A";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "A";
            }*/
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            /*if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "B";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "B";
            }*/
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            /*if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "C";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "C";
            }*/
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            /*if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "D";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "D";
            }*/
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            /*if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "E";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "E";
            }*/
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            /*if (textBox_enter.Text == "0" && textBox_enter.Text != null)
            {
                textBox_enter.Text = "F";
            }
            else
            {
                textBox_enter.Text = textBox_enter.Text + "F";
            }*/
        }

        private void Button10_Click(object sender, EventArgs e)
        {
        }

        private void Button11_Click(object sender, EventArgs e)
        {
        }

        private void Button12_Click(object sender, EventArgs e)
        {
        }

        private void Button13_Click(object sender, EventArgs e)
        {
        }

        private void Button_converter_Click(object sender, EventArgs e)
        {
            if (textBox_enter.Text == "")
            {
                MessageBox.Show("Please Enter a Digit");
            }
            else
            {
                
                
                long numconverter = Convert.ToInt64(textBox_enter.Text, 2);
                textBox_decimal.Text = numconverter.ToString();

                textBox_octal.Text = Convert.ToString(numconverter, 8);
                textBox_hexa.Text = Convert.ToString(numconverter, 16).ToUpper();
            }
                
        }

        private void TextBox_enter_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "/")
            {
                int equal = int.Parse(textBox_equal1.Text) / int.Parse(textBox_equal2.Text);
                textBox_enter.Text = Convert.ToString(equal);
            }
            else if (comboBox1.Text == "*")
            {
                int equal = int.Parse(textBox_equal1.Text) * int.Parse(textBox_equal2.Text);
                textBox_enter.Text = Convert.ToString(equal);
            }
            else if (comboBox1.Text == "+")
            {
                int equal = int.Parse(textBox_equal1.Text) + int.Parse(textBox_equal2.Text);
                textBox_enter.Text = Convert.ToString(equal);
            }
            else if (comboBox1.Text == "-")
            {
                int equal = int.Parse(textBox_equal1.Text) - int.Parse(textBox_equal2.Text);
                textBox_enter.Text = Convert.ToString(equal);
            }
            else
                MessageBox.Show("Invalid Operation");

            Timer time = new Timer();
            time.Interval = (6000);
            time.Tick += new EventHandler(task);
            time.Start();
        }
        private void task(object sender, EventArgs e)
        {
            textBox_equal1.Text = "";
            textBox_equal2.Text = "";
            comboBox1.Text = "";
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            textBox_enter.Text = "";
            textBox_decimal.Text = "";
            textBox_octal.Text = "";
            textBox_hexa.Text = "";
        }
    }
}
