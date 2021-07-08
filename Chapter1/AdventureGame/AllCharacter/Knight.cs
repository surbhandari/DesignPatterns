using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame.AllCharacter
{
    class Knight : Character
    {
        public override void CharacterDescription(PictureBox pictureBox1)
        {
            pictureBox1.ImageLocation = @"C:\Users\a806535\source\repos\AdventureGame\Images\Knight.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load();
        }
    }

}
