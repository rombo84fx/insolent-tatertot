using System;

namespace ModuleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            DateTime BirthDate;
            string AddressLine1;
            string AddressLine2;
            string City;
            string StateProvince;
            string ZipPostal;
            string Country;

            FirstName = "John";
            LastName = "Doe";
            BirthDate = new DateTime(1994, 12, 26);
            AddressLine1 = "123 Main Street";
            AddressLine2 = "Apartment A-12";
            City = "Los Angeles";
            StateProvince = "California";
            ZipPostal = "90185";
            Country = "United States";

            Console.WriteLine("The student information is:\nFirst Name: {0}\nLast Name: {1}\nBirth Date: {2}\nAdress Line 1: {3}\n"
                + "Address Line 2: {4}\nCity: {5}\nState/Province: {6}\nZip/Postal: {7}\nCountry: {8}", 
                FirstName, LastName, BirthDate.ToString("d"), AddressLine1, AddressLine2, City, StateProvince, ZipPostal, Country);
            Console.ReadKey();
        }
    }
}
