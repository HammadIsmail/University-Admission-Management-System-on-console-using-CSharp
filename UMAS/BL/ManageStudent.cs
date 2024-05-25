using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    internal class ManageStudent
    {
        public static void ManageStd(ref int count)
        {
            Headers headers = new Headers();
            while (true)
            {
                Console.Clear();
                headers.menu();
                Hotelide hotelide = new Hotelide();
                int choice;
                Console.Write("Enter Your Choice = ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        headers.info();
                        hotelide.addStudent();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        headers.recordInfo();
                        hotelide.ViewRecords(ref count);
                        Console.Clear();
                        break;
                    case 3:
                        hotelide.UpdateStudentData(ref count);
                        Console.Clear();
                        break;
                    case 4:
                        hotelide.DeleteStudentData(ref count);
                        Console.Clear();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                }
            }
        }
    }
}
