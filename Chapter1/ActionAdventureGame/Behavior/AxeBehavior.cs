using ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAdventureGame.Behavior
{
    public class AxeBehavior : IWeaponBehavior
    {
        //public void UseWeapon()
        //{
        //    Console.WriteLine(" I am choping with axe !!!!");
        //}
        void IWeaponBehavior.UseWeapon()
        {
            Console.WriteLine(" I am choping with axe !!!!");        
        }

        public void KillEveryone()
        {
            Console.WriteLine("I have killed everybody ");
        }
    }
}
