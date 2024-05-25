using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.DL;

namespace UMAS.BL
{
    internal class Users
    {
        public void User()
        {

            Headers headers = new Headers();

            Console.Clear();
            headers.info();
            string id;
            Console.Write("Enter the ID : ");
            id = Console.ReadLine();
            string path = "C:\\Users\\Hammad\\Desktop\\UMAS\\UMAS\\StudentData.txt";
            UserCRUD.Read(path,id);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
