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
            PopulateListBoxes();            
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

            PopulateListBoxes();
        } // End of Add 

        private void btnBattle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            const int NUMBER_OF_FIGHTERS = 2;

            if (checkedListBox1.CheckedItems.Count == NUMBER_OF_FIGHTERS)
            {
                foreach (Character character in Character.characterList)
                {
                    for (int i = 0; i < NUMBER_OF_FIGHTERS; i++)
                    {
                        if (character.Name == checkedListBox1.CheckedItems[i].ToString())
                        {
                            BattleCry(character);
                        }
                    }
                } 
            }
            else
                MessageBox.Show("Please select exactly two characters to battle.");
        }

        private void btnChangeWeapon_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 0)
            {
                foreach (Character character in Character.characterList)
                {
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        if (character.Name == checkedListBox2.CheckedItems[i].ToString())
                        {
                            if (rdClub.Checked)
                                character.weapon = new Club();
                            else if (rdBow.Checked)
                                character.weapon = new Bow();
                            else if (rdSword.Checked)
                                character.weapon = new Sword();
                            else if (rdKnife.Checked)
                                character.weapon = new Knife();
                            else
                                MessageBox.Show("Please select a new weapon to change to.");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Please select at leaset one character to change their weapon.");
        }//End of change weapon


        public void PopulateListBoxes()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            foreach (Character character in Character.characterList)
            {
                checkedListBox1.Items.Add(character.Name);
                checkedListBox2.Items.Add(character.Name);
            }
        }

        public void BattleCry(Character character)
        {            
            listBox1.Items.Add("My name is " + character.Name);
            listBox1.Items.Add(character.declaim);
            listBox1.Items.Add(character.weapon.UseWeapon());
            listBox1.Items.Add("");
        }
    }
}
