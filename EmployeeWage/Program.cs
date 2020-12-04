using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            EmpBuilderClass empWageBuilder = new EmpBuilderClass();
            empWageBuilder.addComapnyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addComapnyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }

    }
}