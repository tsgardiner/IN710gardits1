using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateLab
{
    public partial class Form1 : Form
    {
        List<int> numbers;
        Random random;

        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>();
        }

        private void btnGenRandoms_Click(object sender, EventArgs e)
        {
            lbRandoms.Items.Clear();
            numbers.Clear();

            random = new Random();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(100));
            }

            foreach (int number in numbers)
            {
                lbRandoms.Items.Add(number.ToString());
            }
            
        }

        private void btnEvenNums_Click(object sender, EventArgs e)
        {
            lbDisplaySelected.Items.Clear();

            //Predicate<int> predicate = isEven; //Does the same thing as using a method that meets the predicate.
            List<int> evenNums = numbers.FindAll(isEven); //Returns a list of evenNumbers from the list of random numbers generated

            foreach (int number in evenNums)
            {
                lbDisplaySelected.Items.Add(number.ToString());
            }     
        }


        private void btnLessThanTen_Click(object sender, EventArgs e)
        {
            lbDisplaySelected.Items.Clear();

            List<int> lessThanTen = numbers.FindAll(isLessThanTen);

            foreach (int number in lessThanTen)
            {
                lbDisplaySelected.Items.Add(number.ToString());
            }
        }

        public bool isEven(int num)
        {
            return (num % 2) == 0;
        }

        public bool isLessThanTen(int num)
        {
            return num < 10;
        }

    }
}
