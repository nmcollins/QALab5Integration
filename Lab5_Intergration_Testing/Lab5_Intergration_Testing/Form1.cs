using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Intergration_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check age of USA
            int age;

            try
            {
                age = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                age = 0;
            }

            //Person 2:  Code a working user interface that checks if your age is > 21; // Alcohol in USA
            if (check_age_US(age) == true)
            {
                label2.Text = "It is OK to Drink in US with age " + age;
            }
            else
            {
                label2.Text = "It is illegal to Drink in US with age " + age;
            }
        }

        public static int CheckAgeSouthKorea(int yearOfBirth)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - yearOfBirth;
        }
        public Boolean check_age_US(int age)
        {
            //Person 2:  Code a working user interface that checks if your age is > 21; // Alcohol in USA
            const int ADULT_AGE = 21;

            if (age > ADULT_AGE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean check_age_Canada(int age)
        {
            const int ADULT_AGE_CANADA = 18;

            if (age > ADULT_AGE_CANADA)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check age of South Korea
            int yearOfBirth = int.Parse(textBox1.Text);
            int ageS = CheckAgeSouthKorea(yearOfBirth);
            if (ageS > 19)
            {
                label2.Text = "Your age is " + ageS +
                    ".\n Your are now allowed to\n drink alcohol in South Korea";
            }
            else
            {
                label2.Text = "Your age is " + ageS +
                    ".\n Your are allowed to\n drink alcohol in South Korea";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //check Germany
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //check Canada
            int age;

            try
            {
                age = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                age = 0;
            }

            check_age_Canada(age);

            if (check_age_Canada(age) == true)
            {
                label2.Text = "It is Legal to Drink in Canada with age " + age;
            }
            else
            {
                label2.Text = "It is NOT legal to Drink in Canada with age " + age;
            }

        }
    }

}
