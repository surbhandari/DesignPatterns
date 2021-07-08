using AdventureGame.AllCharacter;
using AdventureGame.Behavior;
using System;
using System.Windows.Forms;

namespace AdventureGame
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            characterPanel.Visible = true;
            weaponPanel.Visible = false;
        }

        private Character currentCharacter;
        private void king_Click(object sender, EventArgs e)
        {
            Character king = new King();
            king.CharacterDescription(pictureBox1);
            currentCharacter = king;
        }

        private void queen_Click(object sender, EventArgs e)
        {
            Character queen = new Queen();
            queen.CharacterDescription(pictureBox1);
            currentCharacter = queen;
        }

        private void knight_Click(object sender, EventArgs e)
        {
            Character knight = new Knight();
            knight.CharacterDescription(pictureBox1);
            currentCharacter = knight;

        }

        private void troll_Click(object sender, EventArgs e)
        {
            Character troll = new Troll();
            troll.CharacterDescription(pictureBox1);
            currentCharacter = troll;
        }

        private void Knife_Click(object sender, EventArgs e)
        {
            currentCharacter.SetWeapon(new KnifeBehavior());
            currentCharacter.Fight(pictureBox2);
        }

        private void bow_Click(object sender, EventArgs e)
        {
            currentCharacter.SetWeapon(new BowAndArrowBehavior());
            currentCharacter.Fight(pictureBox2);
        }

        private void axe_Click(object sender, EventArgs e)
        {
            currentCharacter.SetWeapon(new AxeBehavior());
            currentCharacter.Fight(pictureBox2);
        }

        private void sword_Click(object sender, EventArgs e)
        {
            currentCharacter.SetWeapon(new SwordBehavior());
            currentCharacter.Fight(pictureBox2);
        }

        private void weapons_Click(object sender, EventArgs e)
        {
            characterPanel.Visible = false;
            weaponPanel.Visible = true;
        }

        private void characters_Click(object sender, EventArgs e)
        {
            characterPanel.Visible = true;
            weaponPanel.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

    }
}
