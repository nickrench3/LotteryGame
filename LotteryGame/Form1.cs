using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = getNumber();
            int num2 = getNumber();
            int num3 = getNumber();
            int num4 = getNumber();
            int num5 = getNumber();
            int num6 = getNumber();
            int num7 = getNumber();
            int num8 = getNumber();
            int num9 = getNumber();

            int numberOfWins = 0;

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
            textBox7.Text = num7.ToString();
            textBox8.Text = num8.ToString();
            textBox9.Text = num9.ToString();

            string result1 = isAWinner(num1, num2, num3);
            string result2 = isAWinner(num4, num5, num6);
            string result3 = isAWinner(num7, num8, num9);

            if (result1 == "Win")
            {
                textBox10.Text = "You are a winner!";
                numberOfWins++;
            }
            else
                textBox10.Text = "Sorry, better luck next time";

            if (result2 == "Win")
            {
                textBox11.Text = "You are a winner!";
                numberOfWins++;
            }
            else
                textBox11.Text = "Sorry, better luck next time";

            if (result3 == "Win")
            {
                textBox12.Text = "You are a winner!";
                numberOfWins++;
            }
            else
                textBox12.Text = "Sorry, better luck next time";

            textBox13.Text = numberOfWins.ToString();
        }

        public int getNumber ()
        {
            int lotteryNumber = r.Next(1,9);
            int winningNumber = 0; 

            switch (lotteryNumber)
            {
                case 1: winningNumber = 1;
                    break;
                case 2: winningNumber = 2;
                    break;
                case 3: winningNumber = 3;
                    break;
                case 4: winningNumber = 4;
                    break;
                case 5: winningNumber = 5;
                    break;
                case 6: winningNumber = 6;
                    break;
                case 7: winningNumber = 7;
                    break;
                case 8: winningNumber = 8;
                    break;
                case 9: winningNumber = 9;
                    break;
            }
            return winningNumber;
        }

        public String isAWinner(int num1, int num2 ,int  num3)
        {
            int total = num1 + num2 + num3;

            if (total == 7 || total == 11 || total == 21)
                return "Win";
            else
                return "Lose";
        }
    }
}
