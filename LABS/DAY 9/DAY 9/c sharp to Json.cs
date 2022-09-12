using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace DAY_9
{
    class Student
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StudentRollnum { get; set; }
        public Student(string a , int c, string b)
        {
            StudentRollnum = c;
            Firstname = a;
            Lastname = b;
        }
        public void Writeinfile()
        {
            FileStream f = new FileStream("Student.json", FileMode.Append, FileAccess.Write);
            StreamWriter s1 = new StreamWriter(f);
            s1.Write(StudentRollnum);
            s1.Write(Firstname);
            s1.Write(Lastname);
            s1.Close();
            f.Close();

        } 
        public void Readfromfile()
        {
            FileStream r = new FileStream("Student.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(r);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (r!= null)
            {
                Console.WriteLine("\nStudent Rollnum: " + "\t" +StudentRollnum);

                Console.WriteLine("Student Fist Name:" + "\t" + Firstname);

                Console.WriteLine("Student Last Name:" + "\t" + Lastname);

                Console.ReadLine();
            }
            Console.WriteLine();
            sr.Close();
            r.Close();
        }

        public static void Main()
        {
            string f ,  l;
            int r1;
            Console.WriteLine("Enter Student Rollnum: ");
           r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student First Name: ");
            f = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name: ");
            l = Console.ReadLine();
            Student stu = new Student(f,r1,l);
            Console.WriteLine("\nconverting c# to json: ");
;            var json = JsonConvert.SerializeObject(stu);
            Console.WriteLine(json);
            stu.Writeinfile();
            Console.WriteLine("\nconverting Json to C# Class: ");
            var studentobj = JsonConvert.DeserializeObject<Student>(json);
            Console.WriteLine(studentobj);
            Console.WriteLine("\nReading Content from file:");
            stu.Readfromfile();
            
           



        }

         
    }
}
