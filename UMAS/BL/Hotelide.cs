using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.DL;

namespace UMAS.BL
{
    internal class Hotelide:Student
    {

     public   void  addStudent()
        {
            
            base.addStudent();
            Console.Write("Want a Hotel (Y/N) : ");
            string hostelide = Console.ReadLine();
            hostelide = (hostelide == "Y" || hostelide == "y") ? "Active" : "InActive";
            Console.Write("Hotel Fee : ");
            int fee= int.Parse(Console.ReadLine());
            UserCRUD.Add(base.StudentDataFilePath, ID, names, Fname, matric, fsc, ecat, agg, preference,hostelide,fee);
            Console.WriteLine("Enter any key to Continue.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
