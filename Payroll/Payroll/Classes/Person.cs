using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public class Person
    {
        string firstName;
        string lastName;
        long phoneNumber;
        Address address;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Address Address { get => address; set => address = value; }

       

        public Person()
        {
            firstName = "first name";
            lastName = "last name";
            phoneNumber = 0;
            address = new Address("Adress",0,"city","state",0);
        }

        public Person(string firstName, string lastName, long phoneNumber, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

    

        public override string ToString()
        {
            string data = firstName + " " + lastName + ", Phone Number: " + phoneNumber +", Address: "+ address.ToString();
            return data;
                
        }
    }
}
