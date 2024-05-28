using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Model.Tests
{
    [TestClass()]
    public class HigherFeeTest
    {

        [TestMethod()]
        public void FirstHigher()
        {
            SchoolClass schoolClass = new SchoolClass(9, 'a', 100,2);
            SchoolClass schoolClass2 = new SchoolClass(9, 'b', 300,3);

            string actual = schoolClass.HigherFee(schoolClass2);

            string expected = "9.b osztály diákjai havonta 200 forinttal többet fizetnek osztálypénzbe, mint 9.a osztály tanulói.";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SecondHigher()
        {
            SchoolClass schoolClass = new SchoolClass(9, 'a', 500,2);
            SchoolClass schoolClass2 = new SchoolClass(9, 'b', 200,4);

            string actual = schoolClass.HigherFee(schoolClass2);

            string expected = "9.a osztály diákjai havonta 300 forinttal többet fizetnek osztálypénzbe, mint 9.b osztály tanulói.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SameFee()
        {
            SchoolClass schoolClass = new SchoolClass(9, 'a', 300, 2);
            SchoolClass schoolClass2 = new SchoolClass(9, 'b', 300, 4);

            string actual = schoolClass.HigherFee(schoolClass2);

            string expected = "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.";
            Assert.AreEqual(expected, actual);
        }
    }
}