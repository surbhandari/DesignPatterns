using ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAdventureGame.Behavior
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine(" I am cutting with knife !!!!");
        }
    }
}
