using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.DL;
using UMAS.UI;

namespace UMAS.BL
{
    abstract class Student:IStudent
    {
       protected string ID, names,  Fname,  matric,  fsc,  ecat,  agg, preference;
        protected int count;
        protected  string StudentDataFilePath = "C:\\Users\\Hammad\\Desktop\\UMAS\\UMAS\\StudentData.txt";
      static  string calculateAggregate(string matric, string inter, string ecat)
        {
            float agg = (float.Parse(matric) * 25) / 1100 + (float.Parse(inter) * 45) / 1100 + (float.Parse(ecat) * 30) / 400;
            return agg.ToString();
        }


     public  void addStudent()
        {
            List<string> std = new List<string>();
            std = AddStudentUI.SendStudentData();

            ID = std[0];

            names = std[1];

            Fname = std[2];

            matric = std[3];

            fsc = std[4];

            ecat = std[5];

            agg = calculateAggregate(matric, fsc, ecat);

            preference = std[6];
            count += 1;
         


        }

        public   void DeleteStudentData( ref int count)
        {
            Console.Clear();
            string address = "C:\\Users\\Hammad\\Desktop\\UMAS\\UMAS";
            Headers headers = new Headers();
            headers.deleteInfo();
            ViewRecords(ref count);
            string Studentpath = $"{address}\\StudentData.txt";
            string temppath = $"{address}\\Temp.txt";

            if (count > 0)
            {



                Console.Write("ENTER THE CUSTOMER'S NUMBER WHOSE DATA YOU WANT DELETED (Starting from 0) = ");
                int opt = int.Parse(Console.ReadLine());

                UserCRUD.Delete(opt, Studentpath, temppath);
                Console.WriteLine("DATA DELETED ! ");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No data to delete...");
                Console.ReadKey();
            }
        }
        public   void UpdateStudentData(ref int count)
        {

            Console.Clear();
            Headers headers = new Headers();
            headers.updateInfo();
            ViewRecords(ref count);

            if (count > 0)
            {
                string address = "C:\\Users\\Hammad\\Desktop\\UMAS\\UMAS";
                string Studentpath = $"{address}\\StudentData.txt";
                string temppath = $"{address}\\Temp.txt";


                Console.Write("ENTER THE CUSTOMER'S NUMBER WHOSE DATA YOU WANT UPDATED (Starting from 0) = ");
                int opt = int.Parse(Console.ReadLine());

                UserCRUD.Update(opt, Studentpath, temppath);

                Console.WriteLine("DATA UPDATED!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No data to update...");
                Console.ReadKey();
            }
        }
        public   void ViewRecords(ref int count)
        {

            string path = "C:\\Users\\Hammad\\Desktop\\UMAS\\UMAS\\StudentData.txt";
            UserCRUD.ReadAllData(path, ref count);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
      

    }
}
