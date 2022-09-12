using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DAY_9
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int EmployeeId { get; set; }
      class m {
            public static void Main3(string[] args)
            {
                Employee em = new Employee();
                Console.WriteLine("Enter Employee ID: ");
                em.EmployeeId = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter Employee First Name: ");
                em.Firstname = Console.ReadLine();
                Console.WriteLine("Enter Employee Last Name: ");
                em.Lastname = Console.ReadLine();
                FileStream f = new FileStream("Employee.json", FileMode.Append, FileAccess.Write);
                StreamWriter s = new StreamWriter(f);
                s.Write(em.EmployeeId);
                s.Write(em.Firstname);
                s.Write(em.Lastname);
                s.Close();
                f.Close();

                FileStream r = new FileStream("Employee.json", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(r);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (em != null)
                {
                    Console.WriteLine("\nEmployee ID:" + "\t"+ em.EmployeeId);
                    
                    Console.WriteLine("Employee Fist Name:" + "\t"+ em.Firstname);
                    
                    Console.WriteLine("Employee Last Name:" + "\t"+ em.Lastname);
                    
                    Console.ReadLine();
                }
                Console.WriteLine();
                sr.Close();
                r.Close();

            }
      }
      

    }

        

    }
        

