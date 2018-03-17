/*********************
 
@Auth: Gabriel Rodriguez
Course: CIS162AD
Section: #13552
Date:12/29/2017
Application: Employee Pay Calculator
Assignment: At-Home Final  
Class: EmployeePay

**********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayCalculator
{
    public class EmployeePay
    {
        //declarations
        public double grossPay = 0.00;
        public double netPay = 0.00;
        public double ssWithheld = 0.00;
        public double medicareWithheld = 0.00;
        public double stateTaxWithheld = 0.00;
        public double fedTaxWithheld = 0.00;
        //constructors
        public EmployeePay()
        {

        }
        public EmployeePay(double gross, double net, double ss, double med, double state, double fed)
        {
            grossPay = gross;
            netPay = net;
            ssWithheld = ss;
            medicareWithheld = med;
            stateTaxWithheld = state;
            fedTaxWithheld = fed;
        }
        public EmployeePay(double gross, double net, double ss, double med, double state)
        {
            grossPay = gross;
            netPay = net;
            ssWithheld = ss;
            medicareWithheld = med;
            stateTaxWithheld = state;
        }
        public EmployeePay(double gross, double net, double ss, double med)
        {
            grossPay = gross;
            netPay = net;
            ssWithheld = ss;
            medicareWithheld = med;
        }
        public EmployeePay(double gross, double net, double ss)
        {
            grossPay = gross;
            netPay = net;
            ssWithheld = ss;
        }
        public EmployeePay(double gross, double net)
        {
            grossPay = gross;
            netPay = net;
        }
 
        //get and set methods
        public double GrossPay{ set { grossPay = value; } get{ return grossPay; } }
        public double NetPay { set { netPay = value; } get { return netPay; } }
        public double SSWithheld { set { ssWithheld = value; } get { return ssWithheld; } }
        public double MedicareWithheld { set { medicareWithheld = value; } get { return medicareWithheld; } }
        public double StateTaxWithheld { set { stateTaxWithheld = value; } get { return stateTaxWithheld; } }
        public double FederalTaxWithheld { set { fedTaxWithheld = value; } get { return fedTaxWithheld; } }


    }
}
