using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {
        public delegate int DScore(int correct, int incorrect);
        DScore dScoringComputer;
        int correct, incorrect;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (rbAdult.Checked)
                dScoringComputer = new DScore(Scorer.AdultScore);
            if (rbChild.Checked)
                dScoringComputer = new DScore(Scorer.ChildScore);

           try 
	        {	        
		        correct = Int32.Parse(tbCorrectAns.Text);
                incorrect = Int32.Parse(tbIncorrectAns.Text);
                DisplayPoints(dScoringComputer, correct, incorrect);
	        }
	        catch (FormatException)
	        {
                MessageBox.Show("Please enter two valid whole numbers.");   
	        }            
        }

        public void DisplayPoints(DScore dscoreComputer, int correct, int incorrect)
        {
            int displayScore = dscoreComputer(correct, incorrect);
            lbScore.Text = displayScore.ToString();
        }

       
    }
}
