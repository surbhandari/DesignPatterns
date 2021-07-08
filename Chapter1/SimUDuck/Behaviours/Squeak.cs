using SimUDuck.Interface;
using System;

namespace SimUDuck.Behaviours
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("squeak .....");
        }
    }
}
