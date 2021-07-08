using ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAdventureGame.AllCharacter
{
    public class King : Character 
    {
        public King()
        {

        }
        public King(IWeaponBehavior weapon)
        {
            SetWeapon(weapon);
        }
        public override void CharacterDescription()
        {
            Console.WriteLine(" I am king ......");
        }
    }
}
