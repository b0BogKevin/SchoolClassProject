using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject.Model;
using SchoolClassProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Model.Tests
{
    [TestClass()]
    public class MostPaidSchoolClass
    {
        [TestMethod()]
        public void EqualPay()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> classes = new List<SchoolClass>
            {
            new SchoolClass(9,'a', 100,3),
            new SchoolClass(10, 'b', 300, 1),
            };
            string actual = repo.MostPaidSchoolClass(classes);

            string expected = "Nincs legtöbbet fizető osztály";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FirstHigher()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> classes = new List<SchoolClass>
            {
            new SchoolClass(9,'a', 500,1),
            new SchoolClass(10, 'b', 200, 2),
            };
            string actual = repo.MostPaidSchoolClass(classes);

            string expected = "9.a";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondHigher()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> classes = new List<SchoolClass>
            {
            new SchoolClass(9,'a', 300, 3),
            new SchoolClass(10,'b', 300, 5),
            };
            string actual = repo.MostPaidSchoolClass(classes);

            string expected = "10.b";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultipleClasses()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> classes = new List<SchoolClass>
            {
            new SchoolClass(9,'a', 300,4),
            new SchoolClass(10, 'b', 400, 3),
            new SchoolClass(10, 'c', 1300, 1),
            new SchoolClass(11, 'b', 10000, 0),
            };
            string actual = repo.MostPaidSchoolClass(classes);

            string expected = "10.c";
            Assert.AreEqual(expected, actual);
        }
    }
}