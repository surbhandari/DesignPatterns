﻿using SimUDuck.Interface;
using System;

namespace SimUDuck.Behaviours
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket.");
        }
    }
}
