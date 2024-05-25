using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UMAS.UI
{
    internal class AddStudentUI
    {
      static  List<string> Std = new List<string>();

        public static List<string> SendStudentData()
        {
            Std.Clear();
            Console.Write("Enter ID: ");
            Std.Add(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            Std.Add(Console.ReadLine());

            Console.Write("Enter Student Father Name: ");
            Std.Add(Console.ReadLine());

            Console.Write("Enter Matric Marks: ");
            Std.Add(Console.ReadLine());

            Console.Write("Enter Intermediate Marks: ");
            Std.Add(Console.ReadLine());

            Console.Write("Enter ECAT Marks: ");
            Std.Add(Console.ReadLine());


            Console.Write("Enter Prefer Department: ");
            Std.Add(Console.ReadLine());

            return Std;
        }
    }
}
