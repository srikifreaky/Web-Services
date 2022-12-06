using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CalculatorFormOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);
            double resultdiv = input1 / input2;
            MessageBox.Show("DIVISION RESULT = " + resultdiv.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);
            int resultadd = input1 + input2;
            MessageBox.Show("ADDITION RESULT = " + resultadd.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);
            int resultsub = input1 - input2;
            MessageBox.Show("SUBTRACTION RESULT = " + resultsub.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);
            int resultmul = input1 * input2;
            MessageBox.Show("MULTIPLICATION RESULT = " + resultmul.ToString());
        }
    }
}