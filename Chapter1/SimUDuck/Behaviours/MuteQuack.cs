using SimUDuck.Interface;
using System;

namespace SimUDuck.Behaviours
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >> ");
        }
    }
}
