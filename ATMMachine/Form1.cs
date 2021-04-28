using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deposit_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength <4)
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string bkp = RemoveLastChar(textBox1.Text);
            textBox1.Text = bkp;
        }
   

        public string RemoveLastChar(string fulltext)
        {
            string bkp = string.Empty;
            char[] text = fulltext.ToCharArray();
            for (int i = 0; i < text.Length - 1; i++)
            {
                bkp += text[i];
            }
            return bkp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "0";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("1231"))
                inactivateNumpad();
            else
                MessageBox.Show("Invalid PIN!");
        }
        public void inactivateNumpad()
        {
            welcome.Visible = true;
            welcome.Text = "Welcome to ATM machine, Select your preffered transaction !";
            panel1.Enabled = false;

            check.Enabled = true;
            deposit.Enabled = true;
            withdraw.Enabled = true;
            //button1.Enabled = false;
            //button2.Enabled = false;
            //button3.Enabled = false;
            //button4.Enabled = false;
            //button5.Enabled = false;
            //button6.Enabled = false;
            //button7.Enabled = false;
            //button8.Enabled = false;
            //button9.Enabled = false;
            //button11.Enabled = false;
            //button12.Enabled = false;
            //ok.Enabled = false;
            //textBox1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            
         
        }

        private void valid(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void check_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("1231"))
            {
                balance.Text = balanceMangment.balance.ToString();
            }
        }

        private void deposit_Click_1(object sender, EventArgs e)
        {
           double depo =  Double.Parse( Interaction.InputBox("How many you want to deposit?", "deposit amount", "500"));
            balanceMangment.deposit(depo);
            balance.Text = balanceMangment.balance.ToString();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            double dwithdraw = Double.Parse(Interaction.InputBox("How many you want to withdraw?", "withdraw amount", "100"));
            balanceMangment.withdraw(dwithdraw);
            balance.Text = balanceMangment.balance.ToString();
        }
    }
}
