using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UMAS.DL;
using UMAS.UI;

namespace UMAS.BL
{
    internal class Credentials
    {
        static public bool login()
        {
            string username, line, password, user = "", pass = "";

            Console.Write("~~~> Username: ");
            username = Console.ReadLine();
            Console.Write("~~~> Password: ");
            password = Console.ReadLine();
            string path = "C:\\Users\\Hammad\\Desktop\\C#\\C#\\UAMS\\UAMS\\Login.txt";
            StreamReader file = new StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {
                user = UserCRUD.getField(line, 1);
                pass = UserCRUD.getField(line, 2);
            }
            file.Close();
            if (username == user && password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void signUp()
        {
            string path = "C:\\Users\\Hammad\\Desktop\\C#\\C#\\UAMS\\UAMS\\Login.txt";
            StreamWriter file = new StreamWriter(path);
            string username, password;
            List<string> credentials = CredentialUI.SendCredentialData();

            username = credentials[0] ;
            password =credentials[1]; ;
            file.WriteLine($"{username},{password}");
            file.Close();

    
            Console.WriteLine("Press any Key to Continue........");
            Console.ReadKey();
        }

    }
}
