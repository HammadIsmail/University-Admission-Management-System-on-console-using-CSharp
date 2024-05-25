using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;

namespace UMAS
{
    internal class Program
    {

        public static int count = 0;
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Headers headers = new Headers();
            headers.header();
            Console.WriteLine("Press Enter to Continue.........");
            Console.ReadKey();
            Console.Clear();
            Admin admin = new Admin();
            Users users = new Users();
            while (true)
            {
                headers.info();
                Console.WriteLine("Enter (1) for Admin");
                Console.WriteLine("Enter (2) for Student");
                Console.WriteLine("Enter (3) for Exit");
                Console.Write("Enter the option: ");
                int opt;
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        admin.AdminOperations( ref count);
                        break;
                    case 2:
                        users.User();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }


    }
}
