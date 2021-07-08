using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame.AllCharacter
{
    public class King : Character
    {
        public override void CharacterDescription(PictureBox pictureBox1)
        {

            pictureBox1.ImageLocation = @"C:\Users\a806535\source\repos\AdventureGame\Images\King.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load();
           
        }
    }
}
