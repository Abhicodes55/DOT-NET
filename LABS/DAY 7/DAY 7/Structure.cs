using System;

namespace DAY_7
{    


    struct Employee
    {
        public int EmployeeID;
        public int Employeecontact;
        public string EmployeeName;
        public void Getempname()
        {
            Console.WriteLine("Enter Employee Name: ");
           EmployeeName= Console.ReadLine();
        }
        public void GetempID()
        {
            Console.WriteLine("Enter Employee ID: ");
            EmployeeID =Convert.ToInt32(Console.ReadLine());
        }
        public void Getempcontact()
        {
            Console.WriteLine("Enter Employee Contact Deatils: ");
            Employeecontact=Convert.ToInt32(Console.ReadLine());
        }
        public void Printdetails()
        {
            Console.WriteLine("\nDetails of Employee are given below : ");
            Console.WriteLine("Employee ID: {0} \nEmployee Name: {1} \nEmployee Contact Details: {2}", EmployeeID, EmployeeName, Employeecontact);
        }

    }
    class M1
    {
       public static void Main6()
        {
           Employee s1=new Employee();
            s1.GetempID();
            s1.Getempname();
            s1.Getempcontact();
            s1.Printdetails();
        }
    }
}
