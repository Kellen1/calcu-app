﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = " " +
                Class1.addition(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = " " +
                Class1.subtraction(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = " " +
                Class1.division(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = " " +
                Class1.multiplication(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }
    }
}
