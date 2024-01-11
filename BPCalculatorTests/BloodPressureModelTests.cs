using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPCalculator.Pages.Tests
{
    [TestClass()]
    public class BloodPressureModelTests
    {
        public BloodPressure BP { get; set; }

        [TestMethod()]
        public void OnGetTest()
        {
            try
            {
                BP = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Low Blood Pressure");
            }


            //Assert.Fail();
        }

        [TestMethod()]
        public void OnPostTest()
        {
            try
            {
                BP = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Low Blood Pressure");
            }
        }
    }
}