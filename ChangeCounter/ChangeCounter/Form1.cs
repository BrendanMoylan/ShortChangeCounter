using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeCounter
{
    public partial class Form1 : Form
    {
        float twentyValue, tenValue, fiveValue, twoValue, oneValue, total;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (twentyValue.Equals(null))
                twentyValue = 0;
            if (tenValue.Equals(null))
                tenValue = 0;
            if (fiveValue.Equals(null))
                fiveValue = 0;
            if (twoValue.Equals(null))
                twoValue = 0;
            if (oneValue.Equals(null))
                oneValue = 0;

            total = (twentyValue + tenValue + fiveValue + twoValue + oneValue) / 100;

            textBox6.Text =  total.ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            twentyValue = float.Parse(textBox1.Text) * 20;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tenValue = float.Parse(textBox2.Text) * 10;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fiveValue = float.Parse(textBox3.Text) * 5;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            twoValue = float.Parse(textBox4.Text) * 2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            oneValue = float.Parse(textBox5.Text);
        }
    }
}
