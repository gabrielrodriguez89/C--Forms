/*********************
 
@Auth: Gabriel Rodriguez
Course: CIS162AD
Section: #13552
Date:12/29/2017
Application: Employee Pay Calculator
Assignment: At-Home Final  
Class: Employee

**********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayCalculator
{
    public class Employee
    { 
        //declarations
        private string empFName =  "";
        private string empLName = "";
        private double empRate = 0.00;
        private double empHoursWorked = 0.00;
        //constructors
        public Employee()
        {

        }
        public Employee(string fname, string lname, double rate)
        {
            empFName = fname;
            empLName = lname;
            empRate = rate;
        }
        public Employee(string fname, string lname, double rate, double hours)
        {
            empFName = fname;
            empLName = lname;
            empHoursWorked = hours;
        }
        //get and set methods
        public string FirstName
        {
            set
            {
                empFName = value;
            }
            get
            {
                return empFName;
            }
        }
        public string LastName
        {
            set
            {
                empLName = value;
            }
            get
            {
                return empLName;
            }
        }
        public double PayRate
        {
            set
            {
                empRate = value;
            }
            get
            {
                return empRate;
            }
        }
        public double HoursWorked
        {
            set
            {
                empHoursWorked = value;
            }
            get
            {
                return empHoursWorked;
            }
        }
    }
}
