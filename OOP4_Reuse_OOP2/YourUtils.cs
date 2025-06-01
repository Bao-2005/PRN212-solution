using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP4_Reuse_OOP2
{
    public static class YourUtils
    {
        public static int tuoi(this Employee employee)
        {
            return DateTime.Now.Year - employee.Birthday.Year;
        }

        public static bool thangSinhNhat(this Employee employee)
        {
            return DateTime.Now.Month == employee.Birthday.Month;
        }
    }
}
