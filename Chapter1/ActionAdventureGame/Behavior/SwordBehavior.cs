using ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAdventureGame.Behavior
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void KillEveryone()
        {
            throw new NotImplementedException();
        }

        public void UseWeapon()
        {
            Console.WriteLine(" I am Swinging a sword !!!!");
        }
    }
}
