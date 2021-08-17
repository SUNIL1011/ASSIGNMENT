using System;
using System.Collections.Generic;
using System.Text;

namespace myappaug12
{
    abstract class  Employees //Parent class


    {
        /// <summary>
        /// Abstract class for Employee details of ID,Name,Address and basicPay.
        /// </summary>

        public Employees(int EmployeeID, string EmployeeName, string Address, int BasicPay)
    {
        this.EmployeeID = EmployeeID;
        this.EmployeeName = EmployeeName;
        this.Address = Address;
        this.BasicPay = BasicPay;

        }
    public int EmployeeID{ get; set; }  //Getters and Setters
        public string  EmployeeName { get; set; }
    public string Address { get; set; }
    public int BasicPay { get; set; }

        public virtual double CalculateSalary()
        {
            return BasicPay;
        }

        public override string ToString()  //Method overriding
        {
            return  $"{EmployeeName}'s EmployeeID is {EmployeeID} stays in {Address} with BaseSalary of {BasicPay}";
        }
    }


    class TechnicalEmployee : Employees //Child class
    {
        public TechnicalEmployee(int EmployeeID, string EmployeeName, string Address, int BasicPay,string Skills) : base(EmployeeID,EmployeeName,Address,BasicPay)
        {
            this.Skills = Skills;
        }
        public string Skills { get; set; }//Getters and Setters

        public virtual double CalculateSalaryTech()
        {
            return CalculateSalary()+.12*BasicPay;
        }

        public override string ToString() //Method overriding
        {
            return base.ToString() + $"Has skills like {Skills} ";
        }

        public void ValidateEmpID()
        {
            if (this.EmployeeID < 0 || this.EmployeeID > 30000)
            {
                throw (new InvalidEmpID("Employee ID is invalid"));
            }

        }
        public class InvalidEmpID : Exception //Exception Handling 
        {
            public InvalidEmpID(string message) : base(message)
            {

            }
        }
        public void ValidateBasePay()
        {
            if (this.BasicPay < 0)
            {
                throw (new InvalidBasePay("Base Salary is invalid"));
            }

        }
        public class InvalidBasePay : Exception//Exception Handling 
        {
            public InvalidBasePay(string message) : base(message)
            {

            }
        }

    }

    class Staff : Employees  //Child class
    {
        public Staff(int  EmployeeID, string EmployeeName, string Address, int BasicPay,string Title) : base(EmployeeID, EmployeeName, Address, BasicPay)
        {
            this.Title = Title;
        }
        public string Title { get; set; }//Getters and Setters

        public virtual double CalculateSalaryStaff()
        {
            return CalculateSalary() + .18* BasicPay;
        }

        public override string ToString()  //Method overriding
        {
            return base.ToString() + $"Has Title {Title} ";


        }

        public void ValidateEmpID()
        {
            if (this.EmployeeID < 0 || this.EmployeeID > 30000)
            {
                throw (new InvalidEmpID("EmployeeID is invalid"));
            }

        }
        public class InvalidEmpID : Exception//Exception Handling 
        {
            public InvalidEmpID(string message) : base(message)
            {

            }
        }
        public void ValidateBasePay()
        {
            if (this.BasicPay < 0)
            {
                throw (new InvalidBasePay("Base Salary is invalid"));
            }

        }
        public class InvalidBasePay : Exception//Exception Handling 
        {
            public InvalidBasePay(string message) : base(message)
            {

            }
        }




    }

    class PeopleTestNow
    {
        public static void Main()
        {
            TechnicalEmployee t1 = new TechnicalEmployee(123, "SUNIL", "42252 Falcon City", 50000, "C#,Python,SQL");//Creating an Instance t1
            Console.WriteLine($"HAS TOTAL SAL AS");
            Console.WriteLine(t1.CalculateSalaryTech());//Printing salary
            Console.WriteLine(t1.ToString());//Printing details
            Staff s1 = new Staff(127, "JOSEPH", "SNN Raj LakeView", 20000, "Security Head");//Creating an Instance s1
            Console.WriteLine($"HAS TOTAL SAL AS");
            Console.WriteLine(s1.CalculateSalaryStaff());//Printing salary
            Console.WriteLine(s1.ToString());//Printing details




        }

    }
}
