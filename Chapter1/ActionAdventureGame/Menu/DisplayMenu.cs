using ActionAdventureGame.AllCharacter;
using ActionAdventureGame.Behavior;
using ActionAdventureGame.Interface;
using System;


namespace ActionAdventureGame.Menu
{
    public static class DisplayMenu
    {
        public static void ChooseCharacter()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n \t Chose one of these character to fight !");
            Console.WriteLine("\t [1] King");
            Console.WriteLine("\t [2] Queen");
            Console.WriteLine("\t [3] Knight");
            Console.WriteLine("\t [4] Troll");
            Console.WriteLine("\t [5] Quit");
            Console.WriteLine("\t your choice: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            switch (input1)
            {
                case 1:
                    Character king = new King();
                    //Character king2 = new King()
                    ChooseWeapon(king);
                    break;

                case 2:
                    Character queen = new Queen();
                    ChooseWeapon(queen);
                    break;
                case 3:
                    Character knight = new Knight();
                    ChooseWeapon(knight);
                    break;
                case 4:
                    Character troll = new Troll();
                    ChooseWeapon(troll);
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }
            Console.Clear();
            ChooseCharacter();
        }
        public static void ChooseWeapon(Character fighter)
        {
            Console.WriteLine("\n \t Chose one of these weapon for your character !");
            Console.WriteLine("\t [1] Axe");
            Console.WriteLine("\t [2] Bow and Arrow");
            Console.WriteLine("\t [3] Knife");
            Console.WriteLine("\t [4] Sword");
            Console.WriteLine("\t your choice: ");
            int input2 = Convert.ToInt32(Console.ReadLine());


            IWeaponBehavior wb = new AxeBehavior();

            switch (input2)
            {
                case 1:
                    wb = new AxeBehavior();
                    break;

                case 2:
                    wb = new BowAndArrowBehavior();
                    break;

                case 3:
                    wb = new KnifeBehavior();
                    break;

                case 4:
                    wb = new SwordBehavior();
                    break;
            }

            fighter.SetWeapon(wb);
            fighter.CharacterDescription();
            fighter.Fight();

            Console.ReadKey();

        }  
    }
}
