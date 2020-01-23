using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startLottery_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }


        private void correct7_TextChanged(object sender, EventArgs e)
        {

        }

        private void correct6_TextChanged(object sender, EventArgs e)
        {

        }

        private void correct5_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lotteryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            lotteryValue1.MaxLength = 2;
            lotteryValue2.MaxLength = 2;
            lotteryValue3.MaxLength = 2;
            lotteryValue4.MaxLength = 2;
            lotteryValue5.MaxLength = 2;
            lotteryValue6.MaxLength = 2;
            lotteryValue7.MaxLength = 2;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void lotteryValue1_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue1.Text);


            if (value > 35)
            {
                lotteryValue1.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 1");

            }
        }

        private void lotteryValue2_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue2.Text);


            if (value > 35)
            {
                lotteryValue2.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 2");

            }
        }

        private void lotteryValue3_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue3.Text);


            if (value > 35)
            {
                lotteryValue3.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 3");

            }
        }

        private void lotteryValue4_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue4.Text);


            if (value > 35)
            {
                lotteryValue4.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 4");

            }
        }

        private void lotteryValue5_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue5.Text);


            if (value > 35)
            {
                lotteryValue5.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 5");

            }
        }

        private void lotteryValue6_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue6.Text);


            if (value > 35)
            {
                lotteryValue6.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 6");

            }
        }

        private void lotteryValue7_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(lotteryValue7.Text);


            if (value > 35)
            {
                lotteryValue7.Text = "0";
                MessageBox.Show("Please input a number below 35 in row 7");

            }
        }

        
    }
        }
    

