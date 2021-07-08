using SimUDuck.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Ducks
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine(" looks like a DecoyDuck ");
        }

    }
}
