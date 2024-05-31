using SchoolClassProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Repo
{
    public class SchoolClassRepo
    {
        public SchoolClassRepo() 
        {
            SchoolClasses = new List<SchoolClass> 
            {
                new SchoolClass(9,'a',9000,30),
                new SchoolClass(9, 'b', 6000, 30),
                new SchoolClass(10,'a',8000,30),
                new SchoolClass(10, 'b', 7000, 30),
                new SchoolClass(11,'a',5500,30),
                new SchoolClass(11, 'b', 9800, 30),
                new SchoolClass(12,'a',2000,30),
                new SchoolClass(12, 'b', 12000, 30),
        };
        }

        public List<SchoolClass> SchoolClasses { get; set; }

        public string MostPaidSchoolClass(List<SchoolClass> classes)
        {
            string MostPaidClass = "";
            int maxPaid = int.MinValue;
            bool equalPay = false;
            foreach (SchoolClass c in classes) 
            {
                if (c.MonthlyFee == maxPaid)
                    equalPay = true;
                if (c.MonthlyFee > maxPaid)
                {
                    maxPaid = c.MonthlyFee;
                    MostPaidClass = $"{c.Year}.{c.SchoolType}";
                    equalPay = false;
                }
            }
            if (equalPay)
                return "Nincs legtöbbet fizető osztály";
            return MostPaidClass;
        }
    }
}
