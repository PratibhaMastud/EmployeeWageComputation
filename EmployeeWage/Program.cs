using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            partTimeEmployeeWage();
        }
        public static int partTimeEmployeeWage()
        {
            int wagePerHour = 20;
            int dayHour = 4;
            int dailyEmployeeWage = wagePerHour * dayHour;
            Console.WriteLine("Part time Employee Wage is : {0}", dailyEmployeeWage);
            return dailyEmployeeWage;
        }
    }
}
