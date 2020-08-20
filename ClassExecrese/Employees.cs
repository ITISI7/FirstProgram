using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExecrese
{
    public class Employees
    {
        public string firstName;
        public string lastName;
        public int yearsOfExperiene;

        public void PrintVital()
        {
            Console.WriteLine("First Name: " + firstName + "\n" 
                + "Last Name: " + lastName + "\n" + "Years Of Experience: " + yearsOfExperiene);
        }
    }
}
