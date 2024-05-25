using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    internal interface IStudent
    {
        void addStudent();
        void DeleteStudentData(ref int count);
        void UpdateStudentData(ref int count);
        void ViewRecords(ref int count);
    }
}
