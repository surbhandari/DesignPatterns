using SimUDuck.Interface;
using System;


namespace SimUDuck.Behaviours
{
    public class DoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack .... Quack ....");
        }
    }
    
}
