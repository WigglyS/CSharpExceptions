using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public class Address
    {
        string StreetAddress;
        int ApartmentNumber;
        string City;
        string State;
        int Zip;
        Address()
        {
            StreetAddress = "";
            ApartmentNumber = 0;
            City = "";
            State = "";
            Zip = 0;
        }
        public Address(string streetAddress, int apartmentNumber, string city, string state, int zip)
        {
            StreetAddress = streetAddress;
            ApartmentNumber = apartmentNumber;
            City = city;
            State = state;
            Zip = zip;
        }

      
      
        public override string ToString()
        {
            return StreetAddress + " Apartment " + ApartmentNumber + " " + City + " " + State + " " + Zip;
        }
    }
}
