using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Model
{
    public class SchoolClass
    {
        public SchoolClass(int year, char schoolType, int monthlyFee, int numberOfStudents)
        {
            Year = year;
            SchoolType = schoolType;
            MonthlyFee = monthlyFee;
            NumberOfStudents = numberOfStudents;
        }
        public SchoolClass()
        {
            Year = 9;
            SchoolType = 'a';
            MonthlyFee = 0;
            NumberOfStudents = 0;
        }

        public int Year { get; set; }
        public char SchoolType { get; set; }
        public int MonthlyFee { get; set; }
        public int NumberOfStudents { get; set; }

        public override string ToString() 
        {
            return $"{Year}. {SchoolType} ({MonthlyFee} Ft)";
        }
    }
}
