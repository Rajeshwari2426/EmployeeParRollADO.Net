using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll service program");

            EmployeeRepo employeeRepo = new EmployeeRepo();

            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter the Program number to get executed \n0.Exit \n1.Check Connection");// \n2.Add Data to Table ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            employeeRepo.GetAllEmployees();
                           // Console.WriteLine("\nGet all employees with data adapter :");
                            // employeeRepo.GetAllEmployeesWithDataAdapter();
                            break;
                    }
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
        }
    }
}
