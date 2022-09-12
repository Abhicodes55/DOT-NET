using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOapplication
{
    class Class1
    {
        
       public static void Main4(string[] args)
        {
            FileStream a = new FileStream("Sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter s = new StreamWriter(a);
            string str = "Abhishek Mishra";
            s.WriteLine(str);
            s.Flush();
            s.Close();
            a.Close();
            // Reading from File
            FileStream ab = new FileStream("Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(ab);
            Console.WriteLine("Content from File : ");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (str != null)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }
            sr.Close();
            ab.Close();

        }
    }
}
