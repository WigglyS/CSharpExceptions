using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Classes;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

           List< Employee> employees = new List<Employee>();

            int input = -1;
            do
            {
                //Address address = new Address("111 meme street", 101, "tempe", "Arizona", 85285);
                //employees.Add(new Employee("bob","rob",4803205454,address,"Memer",4.5f,5f,true ));
                Console.Clear();
                Console.WriteLine("Enter 1 to Add a Employee to the payroll");
                Console.WriteLine("Enter 2 to Edit an Employees data");
                Console.WriteLine("Enter 3 to Pay all Employees on the payroll");
                Console.WriteLine("Enter 4 to Display all Employees");
                Console.WriteLine("Enter 0 to Quit");

                long longConversion ;
                if(Int64.TryParse(Console.ReadLine(), out longConversion))
                {
                    input = (int)longConversion;
                    switch (input)
                    {
                        case 1:
                            Employee newEmployee =  new Employee();
                            EditData(ref newEmployee);
                            employees.Add(newEmployee);
                            break;
                        case 2:
                            Console.WriteLine("Enter the first name of the employee");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter the Last name of the employee");
                            string lastName = Console.ReadLine();

                            Employee employee = findEmployee(employees, firstName, lastName);

                            if(employee != null)
                            {
                                EditData(ref employee);
                            }
                            break;
                        case 3:
                            Console.WriteLine("You Paid " + PayEmployees(employees)+" to "+ employees.Count + " employees");

                            break;
                        case 4:
                            displayList(employees);
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }
                }

                Console.ReadKey();

            } while (input != 0);


            /// <summary>
            /// Displays all of the employees and their data
            /// </summary>
            /// <returns></returns>
            void displayList(List<Employee> list)
            {
                foreach (Employee employee in list)
                {
                    Console.Write(employee.ToString());
                    Console.WriteLine();
                }
            }
            /// <summary>
            ///Returns a employee with a given first and last name
            /// </summary>
            /// <returns></returns>
            
            Employee findEmployee(List<Employee> list , string firstname, string lastname)
            {
                foreach (Employee employee in list)
                {
                    if(firstname == employee.FirstName && lastname == employee.LastName)
                    {
                        return employee;
                    }
                }

                Console.WriteLine("That Employee dosent exist");
                return null;
            }
            /// <summary>
            ///pays alls the employees on the payroll
            /// </summary>
            /// <returns></returns>

            float PayEmployees(List<Employee> list)
            {
                float TotalPaid = 0;
                foreach (Employee employee in list)
                {
                    TotalPaid += employee.Pay();
                }
                return TotalPaid;
            }

            /// <summary>
            /// edit all the data of a given employee
            /// </summary>
            /// <returns></returns>
            void EditData(ref Employee employee)
            {
                Console.WriteLine("Enter the first name of the employee");
                string firstName = Console.ReadLine();
                employee.FirstName = firstName;
                Console.WriteLine("Enter the Last name of the employee");
                string lastName = Console.ReadLine();
                employee.LastName = lastName;

                Console.WriteLine("Enter the phone number of the employee");
                long phoneNumber = 0;
                Int64.TryParse(Console.ReadLine(), out phoneNumber);
                employee.PhoneNumber = phoneNumber;

                Console.WriteLine("Enter the Job Title of the employee");
                string jobTitle = Console.ReadLine();
                employee.JobTitle = jobTitle;

                Console.WriteLine("Enter the wage of the employee");
                float wage = 0;
                float.TryParse(Console.ReadLine(), out wage);
                employee.Wage = wage;

                Console.WriteLine("Enter the hours worked of the employee");
                float hoursWorked = 0;
                float.TryParse(Console.ReadLine(), out hoursWorked);
                employee.HoursWorked = hoursWorked;

                Console.WriteLine("is the employee on the payroll (true/false)");
                bool onPayroll = false;
                bool.TryParse(Console.ReadLine(), out onPayroll);
                employee.OnPayroll = onPayroll;


                Console.WriteLine("Enter the address of the employee");
                string streetAdress = Console.ReadLine();


                Console.WriteLine("Enter the Apartment number of the employee");
                long temp = 0;
                Int64.TryParse(Console.ReadLine(), out temp);
                int appNum = (int)temp;

                Console.WriteLine("Enter the city of the employee");
                string city = Console.ReadLine();

                Console.WriteLine("Enter the state of the employee");
                string state = Console.ReadLine();

                Console.WriteLine("Enter the Zip Code of the employee");
                temp = 0;
                Int64.TryParse(Console.ReadLine(), out temp);
                int zip = (int)temp;
                Address address = new Address(streetAdress, appNum, city, state, zip);

                employee.Address = address;

            }
        }

        
    }
}
