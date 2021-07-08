using System;
using System.Collections.Generic;
using System.Text;
using SimUDuck.Interface;

namespace SimUDuck.Ducks
{
    public abstract class Duck
    {

        public IQuackBehavior quackBehavior;
        public IFlyBehavior flyBehavior;

        public Duck() {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++ ");
        }

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("Swimming on the Water ! ! !  ");
        }

        public abstract void Display();

        //Setting FlyBehavior
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        //Setting QuackBehavior
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

    }
}
