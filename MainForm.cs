using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Deklarar variabler i startet av programmet ifall det behövs återanvända
        int amountOfDraws;
        int lotteryValueOne;
        int lotteryValueTwo;
        int lotteryValueThree;
        int lotteryValueFour;
        int lotteryValueFive;
        int lotteryValueSix;
        int lotteryValueSeven;
        int correctFive;
        int correctSix;
        int correctSeven;
    
        private void startLottery_Click_1(object sender, EventArgs e)  
        {
            
            // Lägger in alla input värdena från användare i en list
            List<int> lotteryInput = new List<int>();
            lotteryInput.Add(lotteryValueOne);
            lotteryInput.Add(lotteryValueTwo);
            lotteryInput.Add(lotteryValueThree);
            lotteryInput.Add(lotteryValueFour);
            lotteryInput.Add(lotteryValueFive);
            lotteryInput.Add(lotteryValueSix);
            lotteryInput.Add(lotteryValueSeven);

//Skapar hash set eftersom det endast kan innehålla unika element      
            HashSet<int> s = new HashSet<int>(lotteryInput);
            Boolean lotteryFilled = true;
            // Kollar så programmet inte körs ifall dessa villkor nedanför är ej i fyllda 
            if (lotteryValue1.Text == ""|| lotteryValue2.Text == "" || lotteryValue3.Text == "" || 
                lotteryValue4.Text == "" || lotteryValue5.Text == "" || lotteryValue6.Text == "" || lotteryValue7.Text == "")
            {
                lotteryFilled = false;
                MessageBox.Show("Please fill in all input fields");
            }
                else if (amountOfDraws < 1 || drawAmount.Text == "")
            {
                MessageBox.Show("Please input a valid number of draws (minimum: 1)");
            }
            else if (!(lotteryInput.Count == s.Count))
            {
                MessageBox.Show("There shouldn't be any duplicate numbers, please try again.");

            }
            

            Random random = new Random();
                if (amountOfDraws >= 1 && lotteryInput.Count == 7 && lotteryInput.Count == s.Count && lotteryFilled)
                {
                    for (int i = 0; i < amountOfDraws; i++)
                    {
                    // Skapar en random lista lotto nummer för x antal drag användaren väljer
                        int count = 0;
                        List<int> randomLottery = new List<int>();
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                        randomLottery.Add(random.Next(1, 35));
                    // Loopar igenom input listan och randoms listan, 
                    // ifall liknande siffror dyker upp, adderar ihop de i en variabel
                    for (int j = 0; j < 7; j++)
                            for (int k = 0; k < 7; k++)
                            {
                                {

                                    if (randomLottery[j] == lotteryInput[k])
                                    {
                                        count++;
                                    }
                                }
                            }
                        if (count == 7)
                        {
                            correctSeven += 1;
                        }
                        else if (count == 6)
                        {
                            correctSix += 1;
                        }
                        else if (count == 5)
                        {
                            correctFive += 1;
                        }
                    }
                    correct5.Text = $"{correctFive}";
                    correct6.Text = $"{correctSix}";
                    correct7.Text = $"{correctSeven}";
                }
            }
 

        private void drawAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Behöver spara värdet av antal "drag" för att kunna loopa igenom senare
                amountOfDraws = Int32.Parse(drawAmount.Text);
            } catch
            {
                MessageBox.Show("Only input whole positive numbers please");
            }
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
            // Kod från stackoverflow, för att bara ta siffror som input i textbox)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           

        }
        /* Gäller alla lotteri raderna - kollar så att input är värde mellan 1-35
         Annars får användaren ett meddelande om det och "fel inputen" blir även markerat i rött*/
        private void lotteryValue1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueOne = Int32.Parse(lotteryValue1.Text);
                if (lotteryValueOne > 34 || lotteryValueOne <= 0)
                {
                    lotteryValue1.Text = "";
                    lotteryValue1.BackColor = Color.Red;

                }
                else 
                {
                    lotteryValue1.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

        private void lotteryValue2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueTwo = Int32.Parse(lotteryValue2.Text);
                if (lotteryValueTwo > 34 || lotteryValueTwo <= 0)
                {
                    lotteryValue2.Text = "";
                    lotteryValue2.BackColor = Color.Red;

                }
                else 
                {
                    lotteryValue2.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

        private void lotteryValue3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueThree = Int32.Parse(lotteryValue3.Text);
                if (lotteryValueThree > 34 || lotteryValueThree <= 0)
                {
                    lotteryValue3.Text = "";
                    lotteryValue3.BackColor = Color.Red;

                }
                else
                {
                    lotteryValue3.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

        private void lotteryValue4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueFour = Int32.Parse(lotteryValue4.Text);
                if (lotteryValueFour > 34 && lotteryValueFour <= 0)
                {
                    lotteryValue4.Text = "";
                    lotteryValue4.BackColor = Color.Red;

                }
                else
                {
                    lotteryValue4.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

        private void lotteryValue5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueFive = Int32.Parse(lotteryValue5.Text);
                if (lotteryValueFive > 34 && lotteryValueFive <= 0)
                {
                    lotteryValue5.Text = "";
                    lotteryValue5.BackColor = Color.Red;

                }
                else
                {
                    lotteryValue5.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

        private void lotteryValue6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueSix = Int32.Parse(lotteryValue6.Text);
                if (lotteryValueSix > 34 && lotteryValueSix <= 0)
                {
                    lotteryValue6.Text = "";
                    lotteryValue6.BackColor = Color.Red;

                }
                else
                {
                    lotteryValue6.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }

      
        private void lotteryValue7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lotteryValueSeven = Int32.Parse(lotteryValue7.Text);
                if (lotteryValueSeven > 34 && lotteryValueSeven <= 0)
                {
                    lotteryValue7.Text = "";
                    lotteryValue7.BackColor = Color.Red;

                }
                else
                {
                    lotteryValue7.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please input a number between 1-34");

            }
        }


    }
        }
    

