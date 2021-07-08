using SimUDuck.Interface;
using System;

namespace SimUDuck.Behaviours
{
    public class FlyWithWings: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying .....");
        }
    }
}
