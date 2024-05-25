using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UMAS.BL;

namespace UMAS.UI
{
    internal class UpdateStudentUI
    {

        public static List<string> SendUpdateData()
        {
             List<string> std = new List<string>();

            std.Clear();
            Console.Write("Enter Student ID  = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Student Name = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Student Father Name = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Matric Marks  = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Intermediate Marks = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter ECAT Marks = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Aggregate = ");
            std.Add(Console.ReadLine());
            Console.Write("Enter Your Prefer Department = ");
            std.Add(Console.ReadLine());
            Console.Write("Want a Hostel (Y/N) = ");
            string hostelid = Console.ReadLine();
            hostelid = (hostelid == "Y" || hostelid == "y") ? "Active" : "InActive";
            std.Add(hostelid);
            Console.Write("Hotel Fee : ");
            std.Add(Console.ReadLine());

            return std;
        }
    }
}
