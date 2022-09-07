using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_6
{
    class Class1
    {
       public string[] Doctor = new string[7];
        public void GetDocRegistrationNum()
        {
            Console.WriteLine("Enter Registration number of Doctor: ");
            Doctor[0] = Console.ReadLine();
        }
        public void GetDocname()
        {
            Console.WriteLine("Enter Name of Doctor: ");
            Doctor[1] = Console.ReadLine();
        }
        public void GetDocCity()
        {
            Console.WriteLine("Enter Doctor's City: ");
            Doctor[2] = Console.ReadLine();
        }
        public void GetDocSpecilization()
        {
            Console.WriteLine("Enter Specialaztion of Doctor: ");
            Doctor[3] = Console.ReadLine();
        }
        public void GetDocClinicAddresss()
        {
            Console.WriteLine("Enter Doctor's Clinic Address: ");
            Doctor[4] = Console.ReadLine();
        }
        public void GetDocClinicTiming()
        {
            Console.WriteLine("Enter Clinic Timings of Doctor: ");
            Doctor[5] = Console.ReadLine();
        }
        public void GetDocContactNum()
        {
            Console.WriteLine("Enter Doctor's Contact Number: ");
            Doctor[6] = Console.ReadLine();
        }
        public void ShowDocdetails()
        {
            Console.WriteLine("\nDeatils of Doctor are listed Below : ");
            for (int i = 0; i < Doctor.Length; i++)
            {
                Console.WriteLine(Doctor[i]);
            }
        }
    }
    class M:Class1
    {
        public static void Main()
        {
           
            M obj = new M();
            obj.GetDocRegistrationNum();
            while (string.IsNullOrEmpty(obj.Doctor[0]))
            {
                Console.WriteLine("Doctor's Registration Number is a mandatory Field,It can't be empty. Please enter Doctor's Registration Number :");
                obj.Doctor[0] = Console.ReadLine();
            }
            int numvalue1;
            bool isnum1 = int.TryParse(obj.Doctor[0], out numvalue1);
            if (isnum1 == true)
            {
                int len = obj.Doctor[0].Length;
                if (len > 7|| len < 7)
                {
                    Console.WriteLine("Please Enter 7 Digit Registration Number: ");
                    obj.Doctor[0] = Console.ReadLine();
                }
            }
            else
            {
                int len = obj.Doctor[0].Length;
                Console.WriteLine("Please Enter 7 Digit Numeric Value for Registration Number: ");
                obj.Doctor[0] = Console.ReadLine();
                if (len > 7 || len < 7)
                {
                    Console.WriteLine("Please Enter 7 Digit Registration Number: ");
                    obj.Doctor[0] = Console.ReadLine();
                }
            }


            obj.GetDocname();
            while (string.IsNullOrEmpty(obj.Doctor[1]))
            {
                Console.WriteLine("Doctor's Name is a mandatory Field,It can't be empty. Please enter Doctor's Name :");
                obj.Doctor[1] = Console.ReadLine();
            }
            int numvalue2;
            bool isnum2= int.TryParse(obj.Doctor[1], out numvalue2);
            if (isnum2 == false)
            {
                
            }
            else
            {
                Console.WriteLine("Name Cannot have Numeric Value, Please enter Doctor's name Again :");
                obj.Doctor[1] = Console.ReadLine();
            }
                obj.GetDocCity();
            while (string.IsNullOrEmpty(obj.Doctor[2]))
            {
                Console.WriteLine("Doctor's City is a mandatory Field,It can't be empty. Please enter Doctor's City :");
                obj.Doctor[2] = Console.ReadLine();
            }
            obj.GetDocSpecilization();
            while (string.IsNullOrEmpty(obj.Doctor[3]))
            {
                Console.WriteLine("Doctor's Specialaztion is a mandatory Field,It can't be empty. Please enter Doctor's Specialaztion :");
                obj.Doctor[3] = Console.ReadLine();
            }
            int numvalue3;
            bool isnum3 = int.TryParse(obj.Doctor[3], out numvalue3);
            if (isnum3 == false)
            {

            }
            else
            {
                Console.WriteLine("Doctor's Specialization Cannot have Numeric Value, Please enter Doctor's Specialization Again :");
                obj.Doctor[3] = Console.ReadLine();
            }
            obj.GetDocClinicAddresss();
            while (string.IsNullOrEmpty(obj.Doctor[4]))
            {
                Console.WriteLine("Doctor's Clinic Address is a mandatory Field,It can't be empty. Please enter Doctor's Clinic Address :");
                obj.Doctor[4] = Console.ReadLine();
            }
            obj.GetDocClinicTiming();
            while (string.IsNullOrEmpty(obj.Doctor[5]))
            {
                Console.WriteLine("Doctor's Clinic Timing is a mandatory Field,It can't be empty. Please enter Doctor's Clinic Timing :");
                obj.Doctor[5] = Console.ReadLine();
            }
            obj.GetDocContactNum();
            while (string.IsNullOrEmpty(obj.Doctor[6]))
            {
                Console.WriteLine("Doctor's Contact Number is a mandatory Field,It can't be empty. Please enter Doctors Contact Number  :");
                obj.Doctor[6] = Console.ReadLine();
            }
            int numvalue;
            bool isnum = int.TryParse(obj.Doctor[6], out  numvalue);
            if (isnum==true)
            {
                int len = obj.Doctor[6].Length;
                if (len>10||len<10)
                {
                    Console.WriteLine("Please Enter 10 Digit Contact Number: ");
                    obj.Doctor[6] = Console.ReadLine();
                }
            }
            else
            {
                int len = obj.Doctor[6].Length;
                Console.WriteLine("Please Enter Numeric Value for Contact Number: ");
                obj.Doctor[6] = Console.ReadLine();
                if (len > 10 || len < 10)
                {
                    Console.WriteLine("Please Enter 10 Digit Contact Number: ");
                    obj.Doctor[6] = Console.ReadLine();
                }
            }
            obj.ShowDocdetails();

        }
    }
     
}
