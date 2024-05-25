using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    internal class Headers
    {
        string address = "C:\\Users\\Hammad\\Desktop\\OOPs With C#\\UMAS\\UMAS";

        public void header()
        {
            string path = $"{address}\\header.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();
        }

        public void menu()
        {
            string path = $"{address}\\menu.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();

        }

        public void info()
        {
            string path = $"{address}\\Info.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();

        }
        public void loginInfo()
        {
            string path = $"{address}\\loginInfo.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();

        }
        public void recordInfo()
        {

            string path = $"{address}\\recordInfo.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();
        }

        public void updateInfo()
        {
            string path = $"{address}\\updateInfo.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();

        }

        public void deleteInfo()
        {
            string path = $"{address}\\deleteInfo.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();

        }

        public void signUpInfo()
        {
            string path = $"{address}\\SignUpInfo.txt";
            StreamReader fs = new StreamReader(path);
            string line;

            if (File.Exists(path))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error opening header.txt file.");
            }



            fs.Close();
        }

    }
}
