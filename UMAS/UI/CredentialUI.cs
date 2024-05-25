using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.UI
{
    internal class CredentialUI
    {

        public static List<string> SendCredentialData()
        {
           List<string> data = new List<string>();
            Console.Write("~~~> Username: ");
            data.Add(Console.ReadLine());
            Console.Write("~~~> Password: ");
            data.Add(Console.ReadLine());
            return data;
        }
    }
}
