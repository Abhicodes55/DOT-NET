using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Employee
    {
        public string emp_name;
        public int emp_id;
        public int emp_salary;

        public void getempname()
        {
            Console.WriteLine("Enter Employee Name: ");
            emp_name = Console.ReadLine();
        }
        public void getempid()
        {
            Console.WriteLine("Enter Employee ID: ");
            emp_id = Convert.ToInt32(Console.ReadLine());
        }
        public void getempsal()
        {
            Console.WriteLine("Enter Employee Salary: ");
            emp_salary = Convert.ToInt32(Console.ReadLine());
        }
        public void printempname()
        {
            Console.WriteLine("Employee name : " + emp_name);
        }
            public void printempid()
            {
                 Console.WriteLine("Employee ID: " + emp_id);
            }
        public void printempsal()
        {
            Console.WriteLine("Employee Salary :" + emp_salary);
        }

        public static void Main()
        {
            Employee obj = new Employee();
            Console.WriteLine("Enter the details of Employee: ");
            obj.getempid();
            obj.getempname();
            obj.getempsal();
            Console.WriteLine("\nDetails of Employee are listed Below: ");
            obj.printempid();
            obj.printempname();
            obj.printempsal();

        }


    }
    
}
