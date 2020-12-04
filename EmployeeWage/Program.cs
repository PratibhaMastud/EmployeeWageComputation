using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Employee Wage");
            EmpBuilderClass dMart = new EmpBuilderClass("DMart", 20, 2, 10);
            EmpBuilderClass relience = new EmpBuilderClass("Relience", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            relience.computeEmpWage();
            Console.WriteLine(relience.toString());


        }
    }
}