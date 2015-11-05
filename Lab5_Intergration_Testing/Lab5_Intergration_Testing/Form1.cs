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
            int yearOfBirth = int.Parse(textBox1.Text);
            int age = CheckAge(yearOfBirth);
            if (age > 19)
            {
                label2.Text = "Your age is " + age +
                    ".\n Your are now allowed to\n drink alcohol in South Korea";
            }
            else
            {
                label2.Text = "Your age is " + age +
                    ".\n Your are allowed to\n drink alcohol in South Korea";
            }
        }

        public static int CheckAge(int yearOfBirth)
        {            
            int currentYear = DateTime.Now.Year;
            return currentYear - yearOfBirth;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Input your year of birth";
            button1.Text = "Check your age";
            label2.Text = "Your age is";
        }
    }
}
