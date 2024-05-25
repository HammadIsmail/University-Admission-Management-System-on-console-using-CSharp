using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UMAS.BL;
using UMAS.UI;

namespace UMAS.DL
{
    internal class UserCRUD
    {
        static List<string> ID = new List<string>();
        static List<string> names = new List<string>();
        static List<string> Fname = new List<string>();
        static List<string> matric = new List<string>();
        static List<string> fsc = new List<string>();
        static List<string> ecat = new List<string>();
        static List<string> agg = new List<string>();
        static List<string> preference = new List<string>();
        static List<string> hotelide = new List<string>();
        static List<string> hostelFee = new List<string>();
        static  public void Read(string path,string id) 
        {
            Headers headers = new Headers();

            string record;
            StreamReader data;

            data = new StreamReader(path);
            int idx = 0;

            while ((record = data.ReadLine()) != null)
            {
                ID.Add(getField(record, 1));
                names.Add(getField(record, 2));
                Fname.Add(getField(record, 3));
                matric.Add(getField(record, 4));
                fsc.Add(getField(record, 5));
                ecat.Add(getField(record, 6));
                agg.Add(getField(record, 7));
                preference.Add(getField(record, 8));
                hotelide.Add(getField(record, 9));
                hostelFee.Add(getField(record, 10));
                

                if (ID[idx] == id)
                {
                    break;
                }
                idx++;
            }

            Console.Clear();
            headers.recordInfo();

            Console.WriteLine("Following Student Exist in the System");
            Console.WriteLine("Index\tID\tName\tFather Name\tMatric Marks\tFSC Marks\tECAT Marks\tAggregate\t\tPreference\t\tHostelied\tHostel Fee");
            Console.WriteLine($"{idx}\t{ID[idx]}\t{names[idx]}\t{Fname[idx]}\t\t{matric[idx]}\t\t{fsc[idx]}\t\t{ecat[idx]}\t\t{agg[idx]}\t\t{preference[idx]}\t{hotelide[idx]}\t\t{hostelFee[idx]}");

            data.Close();

            ID.Clear();
            names.Clear();
            Fname.Clear();
            matric.Clear();
            fsc.Clear();
            ecat.Clear();
            agg.Clear();
            preference.Clear();

        }

        static public void Update(int opt,string Studentpath , string temppath)
        {
            int c = 0;
            List<string> std = new List<string>();
            StreamReader customer = new StreamReader(Studentpath);
            StreamWriter temp = new StreamWriter(temppath);
            string line;
            while ((line = customer.ReadLine()) != null)
            {
                if (c == opt)
                {
                    std = UpdateStudentUI.SendUpdateData();
                  
                 
                    temp.WriteLine($"{std[0]},{std[1]},{std[2]},{std[3]},{std[4]},{std[5]},{std[6]},{std[7]},{std[8]},{std[9]}");
                }

                else
                {
                    temp.WriteLine(line);
                }
                c++;
            }

            customer.Close();
            temp.Close();
            ID.Clear();
            names.Clear();
            Fname.Clear();
            matric.Clear();
            fsc.Clear();
            ecat.Clear();
            agg.Clear();
            preference.Clear();
            hotelide.Clear();
            hostelFee.Clear();
            File.Delete(Studentpath);
            File.Move(temppath, Studentpath);
       
        }

        static public void Delete(int opt, string Studentpath, string temppath)
        {
            int c = 0;
            string line;

            StreamReader customer = new StreamReader(Studentpath);
            StreamWriter temp = new StreamWriter(temppath);
            while ((line = customer.ReadLine()) != null)
            {
                if (c != opt)
                {
                    temp.WriteLine(line);
                }
                c++;
            }

            customer.Close();
            temp.Close();

            File.Delete(Studentpath);
            File.Move(temppath, Studentpath);

        }

        static public void Add(string StudentDataFilePath,string ID,string names,string Fname,string matric ,string fsc ,string ecat,string agg , string preference,string hotelide,int hostelFee)
        {
            StreamWriter fs = new StreamWriter(StudentDataFilePath, true);
            if (!File.Exists(StudentDataFilePath))
            {
                Console.WriteLine("Error opening StudentData.txt file.");
                return;
            }

            fs.WriteLine($"{ID},{names},{Fname},{matric},{fsc},{ecat},{agg},{preference},{hotelide},{hostelFee}");

            fs.Close();
        }

        static public void ReadAllData(string path,ref int count)
        {
            string record;
            StreamReader data = new StreamReader(path);
            int idx = 0;
            while ((record = data.ReadLine()) != null)
            {
                ID.Add(getField(record, 1));
                names.Add(getField(record, 2));
                Fname.Add(getField(record, 3));
                matric.Add(getField(record, 4));
                fsc.Add(getField(record, 5));
                ecat.Add(getField(record, 6));
                agg.Add(getField(record, 7));
                preference.Add(getField(record, 8));
                hotelide.Add(getField(record,9));
                hostelFee.Add(getField(record,10));
                idx += 1;
            }
            count = idx;
            data.Close();



            if (idx > 0)
            {
                Console.WriteLine("Following Student Exist in the System");
                Console.WriteLine("Index\tID\tName\tFather Name\tMatric Marks\tFSC Marks\tECAT Marks\tAggregate\t\tPreference\tHostelied\tHostel Fee");
                for (int i = 0; i < idx; i++)
                {
                    Console.WriteLine($"{i}\t{ID[i]}\t{names[i]}\t{Fname[i]}\t\t{matric[i]}\t\t{fsc[i]}\t\t{ecat[i]}\t\t{agg[i]}\t{preference[i]}\t{hotelide[i]}\t\t{hostelFee[i]}");
                }
            }
            else
            {
                Console.WriteLine("No data to display.....");
            }

            data.Close();
            ID.Clear();
            names.Clear();
            Fname.Clear();
            matric.Clear();
            fsc.Clear();
            ecat.Clear();
            agg.Clear();
            preference.Clear();
            hotelide.Clear();
            hostelFee.Clear();
        }
        static public string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
    }
}
