using SimUDuck.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();

        }
        public override void Display()
        {
            Console.WriteLine(" looks like a RubberDuck ");
        }

    }
}
