/*********************
 
@Auth: Gabriel Rodriguez
Course: CIS162AD
Section: #13552
Date:12/29/2017
Application: Employee Pay Calculator
Assignment: At-Home Final  
Class: EmployeePayCalculator

**********************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayCalculator
{
    public partial class PayCalculator : Form
    {
        //declarations
        public int calc = 0;
        public int counter = 0;
        public int countAgain = 0;
        public int backCount = 0;
        public int displayCount = 0;
        public bool clear_flag = false;
        public bool bi_weekly = false;
        public Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
        public Dictionary<int, EmployeePay> employeePayDictionary = new Dictionary<int, EmployeePay>();
        public double gPay = 0.00;
        public double nPay = 0.00;
        public double sSec = 0.00;
        public double medWith = 0.00;
        public double stWith = 0.00;
        public double fedWith = 0.00;
        public double fedTAX = 0.00;
        public double stateTax = 0.06;
        public double totalGross = 0.00;
        public double totalNet = 0.00;
        public double totalSecurity = 0.00;
        public double totalMedicaid = 0.00;
        public double totalState = 0.00;
        public double totalFederal = 0.00;
        public const double FIR_TAX_BR = 500.00;
        public const double SEC_TAX_BR = 999.99;
        public const double THI_TAX_BR = 1499.99;
        public const double FOU_TAX_BR = 1999.99;
        public const double FIF_TAX_BR = 2999.99;
        public const double MEDICARE = 0.0145;
        public const double SOCIAL_SEC = 0.062;
        public const double REG_HOURS = 40.00;
        public const double OT_RATE = 1.50;

        public PayCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //display button actions based on text from the button object
        //moves forward and back through calculated output
        //resets the window
        private void Prev_Next_Finish_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Prev")
            {
                if(displayCount > 0)
                {
                    displayCount--;
                    DisplayPay();
                }
                else
                {
                    MessageBox.Show("There are no more records to display.");
                }
            }
            else
                if(b.Text == "Next")
            {
                if(displayCount < counter - 1)
                {
                    displayCount++;
                    DisplayPay();
                }
                else
                {
                    MessageBox.Show("That was the last record entered.");
                }
            }
            else
            {
                Reset();
            }
        }
        //sets all data fields for an employee object and validates input
        private void Next_Click(object sender, EventArgs e)
        {
            //check to see if the user scrolled back to avoid adding duplicate entries
            if (backCount > 0)
            {
                backCount--;
                counter++;
                int j = counter;   
                if(counter > 0)
                {
                    Calculate.Visible = true;
                }

                if(backCount == 0)
                {
                    FirstName.ReadOnly = false;
                    LastName.ReadOnly = false;
                    HourlyRate.ReadOnly = false;
                    HoursWorked.ReadOnly = false;
                    Clear_Data();
                }
                else
                {
                    Show_Employee(j);
                }
            }
            else//begin the addition of new employee's
            {
                string fName = FirstName.Text;
                string lName = LastName.Text;

                try
                {
                    if (double.Parse(HourlyRate.Text) > 0.0000001)
                    {
                        double rate = double.Parse(HourlyRate.Text);
                        HourlyRate.BackColor = Color.White;

                        if (double.Parse(HoursWorked.Text) > 0.0000001)
                        {
                            double hours = double.Parse(HoursWorked.Text);
                            HoursWorked.BackColor = Color.White;
                            if (fName.Length > 0)
                            {
                                FirstName.BackColor = Color.White;
                                if (lName.Length > 0)
                                {
                                    LastName.BackColor = Color.White;

                                    employeeDictionary.Add(counter, new Employee { FirstName = fName, LastName = lName, PayRate = rate, HoursWorked = hours });
                                    counter++;
                                    
                                    Calculate.Visible = true;
                                }
                                else
                                {
                                    LastName.BackColor = Color.Red;
                                    MessageBox.Show("You have not entered the employee's Last Name for this work week.\n\nPlease enter the required field to continue.");
                                }
                            }
                            else
                            {
                                FirstName.BackColor = Color.Red;
                                MessageBox.Show("You have not entered the employee's First Name for this work week.\n\nPlease enter the required field to continue.");
                            }

                        }
                        else
                        {
                            HoursWorked.BackColor = Color.Red;
                            MessageBox.Show("You have not entered the employee's hours for this work week.\n\nPlease enter the required field to continue.");
                        }
                    }
                    else
                    {
                        HourlyRate.BackColor = Color.Red;
                        MessageBox.Show("You have not entered the employee's pay rate for this work week.\n\nPlease enter the required field to continue.");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Clear_Data();
            }
        }
        //re-display last entered data for user if they want to recheck data input 
        private void Back_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                backCount++;
                counter--;
                FirstName.ReadOnly = true;
                LastName.ReadOnly = true;
                HourlyRate.ReadOnly = true;
                HoursWorked.ReadOnly = true;
                if (counter == 0)
                {
                    Show_Employee(counter);
                    Calculate.Visible = false;
                }
                else
                {
                    Show_Employee(counter);
                }
            }
            else
            {
                MessageBox.Show("You have no more employee records.");
            }
        }
        //start pay calculation and display each result
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (FirstName.Text.Length > 0 || LastName.Text.Length > 0 || HourlyRate.Text.Length > 0 || HoursWorked.Text.Length > 0)
            {
                MessageBox.Show("Please push 'Next' to store user data or Press 'Clear' to Clear the Entry.\nThen you can calculate the pay.");
                Clear.Visible = true;
                clear_flag = true;
            }
            else
            {
                if(BiWeekly.Checked == true)
                {
                    bi_weekly = true;
                }
                while(calc < counter)
                {
                    CalculatePay(calc);
                    calc++;
                }
                HideControls();
                Init_Output();
                Start_Display();
                DisplayPay();
            }
        }
        //set tax rates based upon pay scale
        private void CalculatePay(int k)
        {
            if(clear_flag)
            {
                Clear.Visible = false;
                clear_flag = false;
            }
            double extraTime = 0.00;
            double overTime = 0.00;
            double overTimeRate = 0.00;
            double checkHours = employeeDictionary[k].HoursWorked;
            double rate = employeeDictionary[k].PayRate;

            if(bi_weekly)
            {
                //check if the employee has overtime
                if (checkHours <= 80)
                {
                    gPay = rate * 80;
                }
                else
                {
                    overTimeRate = rate * OT_RATE;
                    extraTime = checkHours - 80;
                    overTime = extraTime * overTimeRate;
                    gPay = rate * 80 + overTime;
                }
            }
            else
            {
                //check if the employee has overtime
                if (checkHours <= REG_HOURS)
                {
                    gPay = rate * checkHours;
                }
                else
                {
                    overTimeRate = rate * OT_RATE;
                    extraTime = checkHours - REG_HOURS;
                    overTime = extraTime * overTimeRate;
                    gPay = rate * REG_HOURS + overTime;
                }
            }
            
            //set tax rates
            if (gPay <= FIR_TAX_BR)
            {
                stateTax = 0.02;
                fedTAX = 0.05;
            }
            else
                if (gPay <= SEC_TAX_BR)
            {
                stateTax = 0.04;
                fedTAX = 0.10;
            }
            else
                if (gPay <= THI_TAX_BR)
            {
                fedTAX = 0.15;
            }
            else
                if (gPay <= FOU_TAX_BR)
            {
                fedTAX = 0.20;
            }
            else
                if (gPay <= FIF_TAX_BR)
            {
                fedTAX = 0.25;
            }
            else
            {
                fedTAX = 0.30;
            }

            //calculate withholdings
            fedWith = gPay * fedTAX;
            stWith = gPay * stateTax;
            medWith = gPay * MEDICARE;
            sSec = gPay * SOCIAL_SEC;
            nPay = gPay - fedWith - stWith - medWith - sSec;

            //store user object/information in dictionary for later use
            employeePayDictionary.Add(k, new EmployeePay { GrossPay = gPay, NetPay = nPay, SSWithheld = sSec, MedicareWithheld = medWith, StateTaxWithheld = stWith, FederalTaxWithheld = fedWith });

            //set totals
            totalGross = totalGross + gPay;
            totalNet = totalNet + nPay;
            totalSecurity = totalSecurity + sSec;
            totalMedicaid = totalMedicaid + medWith;
            totalState = totalState + stWith;
            totalFederal = totalFederal + fedWith;

        }
        public void HideControls()
        {
            //hide controls and labels
            EmpName.Visible = false;
            Rate.Visible = false;
            Hours.Visible = false;
            FirstName.Visible = false;
            LastName.Visible = false;
            HourlyRate.Visible = false;
            HoursWorked.Visible = false;
            Back.Visible = false;
            Next.Visible = false;
            Calculate.Visible = false;
            name1.Visible = false;
            name2.Visible = false;
            Bi_label.Visible = false;
            BiWeekly.Visible = false;
        }
        public void Init_Output()
        {
            //show labels for output
            OutputBox.Visible = true;
            TotalFedTax.Visible = true;
            TotalFedOut.Visible = true;
            TotalGrossPay.Visible = true;
            TotalGrossOut.Visible = true;
            TotalMedicare.Visible = true;
            TotalMedicareOut.Visible = true;
            TotalNetPay.Visible = true;
            TotalNetOut.Visible = true;
            TotalSS.Visible = true;
            TotalSSOut.Visible = true;
            TotalStateOut.Visible = true;
            TotalStateTax.Visible = true;
            prev.Visible = true;
            next2.Visible = true;
            Fin.Visible = true;
            totallabel.Visible = true;
        }
        //resets the display to allow user to continue
        public void Reset()
        {
            OutputBox.Visible = false;
            TotalFedTax.Visible = false;
            TotalFedOut.Visible = false;
            TotalGrossPay.Visible = false;
            TotalGrossOut.Visible = false;
            TotalMedicare.Visible = false;
            TotalMedicareOut.Visible = false;
            TotalNetPay.Visible = false;
            TotalNetOut.Visible = false;
            TotalSS.Visible = false;
            TotalSSOut.Visible = false;
            TotalStateOut.Visible = false;
            TotalStateTax.Visible = false;
            prev.Visible = false;
            next2.Visible = false;
            Fin.Visible = false;
            totallabel.Visible = false;

            EmpName.Visible = true;
            Rate.Visible = true;
            Hours.Visible = true;
            name1.Visible = true;
            name2.Visible = true;
            FirstName.Visible = true;
            LastName.Visible = true;
            HourlyRate.Visible = true;
            HoursWorked.Visible = true;
            Back.Visible = true;
            Next.Visible = true;
            Calculate.Visible = true;
            Bi_label.Visible = true;
            BiWeekly.Visible = true;
            displayCount = 0;
        }
        //initialize the display text
        public void Start_Display()
        {
            totallabel.Text = "Totals For Week";
            TotalFedTax.Text = "Federal";
            TotalFedOut.Text = "$" + totalFederal.ToString();
            TotalStateTax.Text = "State";
            TotalStateOut.Text = "$" + totalState.ToString();
            TotalSS.Text = "Social";
            TotalSSOut.Text = "$" + totalSecurity.ToString();
            TotalMedicare.Text = "Medicare";
            TotalMedicareOut.Text = "$" + totalMedicaid.ToString();
            TotalNetPay.Text = "Net Pay";
            TotalNetOut.Text = "$" + totalNet.ToString();
            TotalGrossPay.Text = "Gross";
            TotalGrossOut.Text = "$" + totalGross.ToString();
        }
        /*******
         * displays final output
         * convert output to strings retreiving data from dictionary
         * --> OutputBox is a RichTextBox and does not accept Formatting output --> {0:C3}
         * 
         * *****/
        public void DisplayPay()
        {
            countAgain = counter;

            if (employeeDictionary[displayCount].FirstName.Length > 0)
            {
                string fname = employeeDictionary[displayCount].FirstName;
                string lname = employeeDictionary[displayCount].LastName;
                string hours = employeeDictionary[displayCount].HoursWorked.ToString();
                string pRate = employeeDictionary[displayCount].PayRate.ToString();
                string gross = "$ " + employeePayDictionary[displayCount].GrossPay.ToString();
                string net = "$ " + employeePayDictionary[displayCount].NetPay.ToString();
                string ss = "$ " + employeePayDictionary[displayCount].SSWithheld.ToString();
                string med = "$ " + employeePayDictionary[displayCount].MedicareWithheld.ToString();
                string state = "$ " + employeePayDictionary[displayCount].StateTaxWithheld.ToString();
                string fed = "$ " + employeePayDictionary[displayCount].FederalTaxWithheld.ToString();

                OutputBox.Text = ("\n\tFirst Name: " + fname + "\tLast Name: " + lname + "\n\n\t Hours Worked: " + hours + "\t Pay Rate: " + pRate + "\n\n\tGross Pay: " + gross + "\n\n\tSocial Security: " + ss + "\n\n\tMedicare: " + med + "\n\n\tState Tax: " + state + "\n\n\tFederal Tax: " + fed + "\n\n\tNet Pay: " + net);
            }
        }
        //display employee back to user
        public void Show_Employee(int i)
        {
            FirstName.Text = employeeDictionary[i].FirstName;
            LastName.Text = employeeDictionary[i].LastName;
            HourlyRate.Text = employeeDictionary[i].PayRate.ToString();
            HoursWorked.Text = employeeDictionary[i].HoursWorked.ToString();
        }
        //clear text fields for new data
        public void Clear_Data()
        {
            FirstName.Text = "";
            LastName.Text = "";
            HourlyRate.Text = "";
            HoursWorked.Text = "";
            if(clear_flag)
            {
                Clear.Visible = false;
            }
        }
        //clear button 
        private void Clear_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }

        private void PayCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
