using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    internal class Admin
    {
        public void AdminOperations(ref int count)
        {
            Headers headers = new Headers();
            while (true)
            {
                Console.Clear();
                headers.info();
                Console.Write("Press (1) to SignUp and (2) for SignIn : ");
                int select;
                select = int.Parse(Console.ReadLine());
                bool loggedIn = false;

                switch (select)
                {
                    case 1:
                        // for signup
                        Console.Clear();
                        headers.signUpInfo();
                        Credentials.signUp();
                        break;
                    case 2:
                        // for login
                        Console.Clear();
                        while (!loggedIn)
                        {
                            headers.loginInfo();
                            loggedIn = Credentials.login();

                            if (!loggedIn)
                            {
                                Console.WriteLine("Login failed. Please try again.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        // for Entering Customer
                        Console.Clear();
                        headers.info();
                        ManageStudent.ManageStd( ref count);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

    }
}
