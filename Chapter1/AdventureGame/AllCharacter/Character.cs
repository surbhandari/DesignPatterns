using AdventureGame.Interface;
using AdventureGame.Behavior;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame.AllCharacter
{
    public abstract class Character
    {
        public IWeaponBehavior weaponBehavior;

        public  void Fight(PictureBox pictureBox)
        {
            weaponBehavior.UseWeapon(pictureBox);
        }

        public abstract void CharacterDescription(PictureBox pictureBox1);
       
        public void SetWeapon(IWeaponBehavior w)
        {
            this.weaponBehavior = w;
        }

        
    }
}
