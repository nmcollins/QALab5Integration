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
        /*
         Test Identifier: 1.1
         * Test Description: Testing age by 2000
         * Input Data: 2000
         * Actions: check the age from input value
         * Expected Output: 15
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 2000 
         */
        [TestMethod()]
        public void CheckAgeTest2000()
        {
            int yearOfBirth = 2000;
            int result = Lab5_Intergration_Testing.Form1.CheckAge(yearOfBirth);
            Assert.AreEqual(15, result);
        }

        /*
         Test Identifier: 1.2
         * Test Description: Testing age by 1990
         * Input Data: 1990
         * Actions: check the age from input value
         * Expected Output: 25
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 1990 
         */
        [TestMethod()]
        public void CheckAgeTest1990()
        {
            int yearOfBirth = 1990;
            int result = Lab5_Intergration_Testing.Form1.CheckAge(yearOfBirth);
            Assert.AreEqual(25, result);
        }

        /*
         Test Identifier: 1.3
         * Test Description: Testing age by 1980
         * Input Data: 1980
         * Actions: check the age from input value
         * Expected Output: 35
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 1980 
         */
        [TestMethod()]
        public void CheckAgeTest1980()
        {
            int yearOfBirth = 1980;
            int result = Lab5_Intergration_Testing.Form1.CheckAge(yearOfBirth);
            Assert.AreEqual(35, result);
        }
    }
}