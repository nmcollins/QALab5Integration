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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
