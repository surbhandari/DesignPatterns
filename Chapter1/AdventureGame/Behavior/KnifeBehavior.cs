using AdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame.Behavior
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = @"C:\Users\a806535\source\repos\AdventureGame\Images\knife.jpg";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Load();
        }
    }
}
