using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Intergration_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Intergration_Testing.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        //Set up fixture
        Form1 fl = new Form1();

        [TestMethod()]
        public void check_age_USTest_FOR_0()
        {
            Assert.AreEqual(false, fl.check_age_US(0));
        }

        [TestMethod()]
        public void check_age_USTest_FOR_21()
        {

            Assert.AreEqual(false, fl.check_age_US(21));
        }

        [TestMethod()]
        public void check_age_USTest_FOR_22()
        {
            Assert.AreEqual(true, fl.check_age_US(22));
        }
    }
}