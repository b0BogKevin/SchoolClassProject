using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Model
{
    public static class SchoolClassExtension
    {
        public static string HigherFee(this SchoolClass self, SchoolClass other)
        {
            if (self.MonthlyFee > other.MonthlyFee)
            {
                return $"{self.Year}.{self.SchoolType} osztály diákjai havonta {self.MonthlyFee-other.MonthlyFee} forinttal többet fizetnek osztálypénzbe, mint {other.Year}.{other.SchoolType} osztály tanulói.";
            }
            else if (self.MonthlyFee < other.MonthlyFee)
            {
                return $"{other.Year}.{other.SchoolType} osztály diákjai havonta {other.MonthlyFee - self.MonthlyFee} forinttal többet fizetnek osztálypénzbe, mint {self.Year}.{self.SchoolType} osztály tanulói.";

            }
            return $"{self.Year}.{self.SchoolType} és {other.Year}.{other.SchoolType} osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.";
        }

    }
}
