using SimUDuck.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new DoQuack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine(" looks like a mallard ");
        }
    }
}
