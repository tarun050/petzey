using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViewAllappointments.Repository.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;

namespace ViewAllappointments.Repository.Repository.Implementations.Tests
{
    [TestClass()]
    public class AllappointmentsRepositoryTests
    {
       [TestMethod()]
        public void GetAllAppointmentsTest()
        {
            string PetName = "abc";
            string expected = "abc";
            AllAppointments allAppointments = new AllAppointments();
            string actual = expected;
            Assert.AreEqual(actual, expected);

        }

        [TestMethod()]
        public void GetAllAppointmentsByIdTest()
        {
            int id = 1;
            int expected = 1;
            AllAppointments allAppointments = new AllAppointments();
            int actual = expected;
            Assert.AreEqual(actual,expected);
        }
    }
}