using SimUDuck.Behaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new DoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Model duck  ");
        }
    }
}
