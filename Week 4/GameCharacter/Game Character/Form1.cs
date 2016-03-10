using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Character.CreateStartingCharaters();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Character newCharacter;

            try 
	        {
                if (name != "")
                {
                    if (rdKing.Checked) {
                        newCharacter = new King(name);
                        Character.characterList.Add(newCharacter);
                    }
                    else if (rdKnight.Checked) {                    
                        newCharacter = new Knight(name);
                        Character.characterList.Add(newCharacter);
                    }
                    else if (rdQueen.Checked){
                        newCharacter = new Queen(name);
                        Character.characterList.Add(newCharacter);
                    } 
                    else if (rdTroll.Checked){
                        newCharacter = new Troll(name);
                        Character.characterList.Add(newCharacter);
                    }                        
                    else
                        MessageBox.Show("Please choose a title for your character.");
                }
                else
                    MessageBox.Show("Please enter a name for your character.");                
	        }
	        catch (NullReferenceException)
	        {
                MessageBox.Show("Name cannot be null.");
	        }            
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
