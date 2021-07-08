using SimUDuck.Interface;
using System;

namespace SimUDuck.Behaviours
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
