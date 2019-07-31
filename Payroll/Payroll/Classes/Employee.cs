using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public class Employee: Person
    {
        string jobTitle;
        float wage;
        float hoursWorked;
        bool onPayroll;

        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public float Wage { get => wage; set => wage = value; }
        public float HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public bool OnPayroll { get => onPayroll; set => onPayroll = value; }

        public Employee() : base()
        {
            jobTitle = "jobTitile";
            wage = 0;
            hoursWorked = 0;
            onPayroll = false;
        }

        public Employee(string firstname, string lastName, long phoneNumber, Address address , string jobTitle, float wage, float hoursWorked, bool onPayroll) : base(firstname,lastName,phoneNumber,address)
        {
            this.jobTitle = jobTitle;
            this.wage = wage;
            this.hoursWorked = hoursWorked;
            this.onPayroll = onPayroll;
        }

        /// <summary>
        /// returns the total pay of the employee
        /// </summary>
        /// <returns></returns>
        public float Pay()
        {
            return wage *hoursWorked;
        }
        public override string ToString()
        {
            string data = base.ToString()+ "\n"+ "Title: "+ jobTitle + ", Wage: "+ wage +", Hours Worked: "+ hoursWorked+ ", On Payroll: " + onPayroll;
            return data;
        }
    }
}
