using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private int num1, num2;
        private int result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = num1 + num2;
            MessageBox.Show ("The Addition result is = "+ sum.ToString());
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sub = num1 - num2;
            MessageBox.Show("The Substraction result is = "+ sub.ToString());
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double multi = num1 * num2;
            MessageBox.Show("The Multiplication result is = "+ multi.ToString());
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double div = num1 / num2;
            MessageBox.Show("The Divition result is = "+ div.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button_Exit_MouseHover(object sender, EventArgs e)
        {
            button_Exit.Text = "!!! ? TERMINATE ? !!!";
        }

        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.Text = "EXIT";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
