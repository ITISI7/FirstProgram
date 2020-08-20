using System;
using System.Threading.Channels;

namespace ClassExecrese
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employees David = new Employees();
            David.firstName = "David";
            David.lastName = "Tounn";
            David.yearsOfExperiene = 1;
            David.PrintVital();
        }                                           
    }
}
