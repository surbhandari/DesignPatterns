using System;
using ActionAdventureGame.AllCharacter;
using ActionAdventureGame.Interface;
using ActionAdventureGame.Behavior;
using ActionAdventureGame.Menu;
using System.Collections.Generic;

namespace ActionAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ActionAdventureGame");
            DisplayMenu.ChooseCharacter();
        }
    }
}
