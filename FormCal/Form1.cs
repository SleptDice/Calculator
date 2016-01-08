using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryCal;

namespace FormCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            opr.Text = "+";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            opr.Text = "-";
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            opr.Text = "*";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            opr.Text = "/";
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = "0";
            else num2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0"))?"1":num1.Text+"1";
            else num2.Text = (num2.Text.Equals("0")) ? "1" : num2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "2" : num1.Text + "2";
            else num2.Text = (num2.Text.Equals("0")) ? "2" : num2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "3" : num1.Text + "3";
            else num2.Text = (num2.Text.Equals("0")) ? "3" : num2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "4" : num1.Text + "4";
            else num2.Text = (num2.Text.Equals("0")) ? "4" : num2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "5" : num1.Text + "5";
            else num2.Text = (num2.Text.Equals("0")) ? "5" : num2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "6" : num1.Text + "6";
            else num2.Text = (num2.Text.Equals("0")) ? "6" : num2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "7" : num1.Text + "7";
            else num2.Text = (num2.Text.Equals("0")) ? "7" : num2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "8" : num1.Text + "8";
            else num2.Text = (num2.Text.Equals("0")) ? "8" : num2.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "9" : num1.Text + "9";
            else num2.Text = (num2.Text.Equals("0")) ? "9" : num2.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue)) num1.Text = (num1.Text.Equals("0")) ? "0" : num1.Text + "0";
            else num2.Text = (num2.Text.Equals("0")) ? "0" : num2.Text + "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            result.Text = (num2.Text.Equals("0") && opr.Text.Equals("/")) ? "error" : "" + new Calculator(opr.Text, num1.Text, num2.Text,new FileLogger()).Cal();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            num1.ForeColor = Color.Blue;
            num2.ForeColor = Color.Black;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            num2.ForeColor = Color.Blue;
            num1.ForeColor = Color.Black;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (num1.ForeColor.Equals(Color.Blue))
                num1.Text = (!num1.Text.Contains(".")) ? num1.Text + "." : num1.Text;
            else
                num2.Text = (!num2.Text.Contains(".")) ? num2.Text + "." : num2.Text;
        }
    }
}
