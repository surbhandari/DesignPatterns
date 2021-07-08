using ActionAdventureGame.Interface;
using ActionAdventureGame.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAdventureGame.AllCharacter
{
    public abstract class Character 
    {
        public IWeaponBehavior weaponBehavior;

        public  void Fight()
        {
            weaponBehavior.UseWeapon();
        }

        public abstract void CharacterDescription();
       
        public void SetWeapon(IWeaponBehavior w)
        {
            this.weaponBehavior = w;
        }

    }
}
