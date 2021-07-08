using SimUDuck.Ducks;
using SimUDuck.Behaviours;

namespace SimUDuck
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Duck model = new ModelDuck();
            model.performFly();
            model.Display();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();


            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.performQuack();
            mallard.performFly();
            mallard.Swim();
            
            Duck redhead = new RedheadDuck();
            redhead.Display();
            redhead.performFly();
            redhead.performQuack();
            redhead.Swim();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.performFly();
            rubberDuck.performQuack();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.performFly();
            decoyDuck.performQuack();

        }

    }

}

