using ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;
namespace ActionAdventureGame.Behavior
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine(" I am shoting arrow with a bow  !!!!");
        }
     }
}
