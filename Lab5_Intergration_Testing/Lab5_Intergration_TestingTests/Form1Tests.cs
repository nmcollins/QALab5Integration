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
            int result = Lab5_Intergration_Testing.Form1.CheckAgeSouthKorea(yearOfBirth);
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
            int result = Lab5_Intergration_Testing.Form1.CheckAgeSouthKorea(yearOfBirth);
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
            int result = Lab5_Intergration_Testing.Form1.CheckAgeSouthKorea(yearOfBirth);
            Assert.AreEqual(35, result);
        }

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

        [TestMethod()]
        public void check_age_Canada_FOR_0()
        {
            Assert.AreEqual(false, fl.check_age_Canada(0));
        }

        [TestMethod()]
        public void check_age_Canada_FOR_18()
        {

            Assert.AreEqual(false, fl.check_age_Canada(18));
        }

        [TestMethod()]
        public void check_age_Canada_FOR_19()
        {
            Assert.AreEqual(true, fl.check_age_Canada(19));
        }

        /*
         Test Identifier: 1.0
         * Test Description: Testing Bigger than 16
         * Input Data: 17
         * Actions: check the age
         * Expected Output: True
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 17
         */
        [TestMethod()]
        public void Check_Age_In_Germany_Age_Bigger_Than_16()
        {
            //Arrange
            int age = 17;
            var Form1 = new Form1();
            bool result = false;
            bool expected = true;

            //Act 

            result = Form1.TestAgeInGermany(age);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /*
         Test Identifier: 1.1
         * Test Description: Testing less than 16
         * Input Data: 15
         * Actions: check the age
         * Expected Output: Flase
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 15
         */
        [TestMethod()]
        public void Check_Age_In_Germany_Less_Than_16()
        {
            //Arrange
            int age = 15;
            var Form1 = new Form1();
            bool result = false;
            bool expected = false;

            //Act 
            result = Form1.TestAgeInGermany(age);

            //Assert
            Assert.AreEqual(expected, result);
        }

        /*
         Test Identifier: 1.2
         * Test Description: Testing exactly 16
         * Input Data: 16
         * Actions: check the age
         * Expected Output: True
         * OBserved Output: will be reported
         * Failed Action: Alert the user that their input failed to check 16
         */
        [TestMethod()]
        public void Check_Age_In_Germany_Exactly_16()
        {
            //Arrange
            int age = 16;
            var Form1 = new Form1();
            bool result = false;
            bool expected = true;

            //Act 
            result = Form1.TestAgeInGermany(age);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}