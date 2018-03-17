using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithMath
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void Num_One_TextChanged(object sender, EventArgs e)
        {
            int number;

            try
            {
                while (int.TryParse(numOne.Text, out number) == false)
                {
                    MessageBox.Show("You have entered an invalid character.\n\nPlease enter a number.");
                    numOne.Text = "0";
                    numOne.Focus();
                }
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            catch (Exception arg)
            {
                Console.WriteLine(arg.Message);
            }
        }

        private void Num_Two_TextChanged(object sender, EventArgs e)
        {
            int number;

            try
            {
                while (int.TryParse(numTwo.Text, out number) == false)
                {
                    MessageBox.Show("The input is not numeric.\nPlease enter a number.");
                    numTwo.Text = "0";
                    numTwo.Focus();
                }
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            catch (Exception arg)
            {
                Console.WriteLine(arg.Message);
            }
        }

        private void Adding_MouseClick(object sender, EventArgs e)
        {
            string userInput;
            double answer, firstNum, secNum;

            userInput = numOne.Text;
            firstNum = double.Parse(userInput);

            userInput = numTwo.Text;
            secNum = double.Parse(userInput);

            answer = firstNum + secNum;
            display.Text = string.Format("{0}", answer);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_MouseClick(object sender, MouseEventArgs e)
        {
            string userInput;
            double answer, firstNum, secNum;

            userInput = numOne.Text;
            firstNum = double.Parse(userInput);

            userInput = numTwo.Text;
            secNum = double.Parse(userInput);

            answer = firstNum - secNum;
            display.Text = string.Format("{0}", answer);
        }

        private void Multiply_MouseClick(object sender, MouseEventArgs e)
        {
            string userInput;
            double answer, firstNum, secNum;

            userInput = numOne.Text;
            firstNum = double.Parse(userInput);

            userInput = numTwo.Text;
            secNum = double.Parse(userInput);

            answer = firstNum * secNum;
            display.Text = string.Format("{0}", answer);
        }

        private void Divide_MouseClick(object sender, MouseEventArgs e)
        {
            string userInput;
            double answer, firstNum, secNum;

            userInput = numOne.Text;
            firstNum = double.Parse(userInput);

            userInput = numTwo.Text;
            secNum = double.Parse(userInput);

            answer = firstNum / secNum;
            display.Text = string.Format("{0}", answer);
        }

        private void Math_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Welcome to Math Wiz!\n\nTo get started simply enter any numbers you'd like!\n\nYou can Add, Subtract, Multiply and Divide!");
        }
    }
}
