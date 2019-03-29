using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmThing
{
    class Daffy_Duck
    {
        public void daffy_duck()
        {
            Greeting();
        }

        private static void Greeting()
        {
            Console.WriteLine("Hello my name is Daffy Duck, what would you like to do?");
            Console.WriteLine("1) Go shopping \n2) Go to the park \n3) Get angry because you're not as popular as Bugs.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Shop();
                    break;
                case 2:
                    Park();
                    break;
                case 3:
                    Get_Mad();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    Greeting();
                    break;
            }
        }

        private static void Get_Mad()
        {
            Console.Clear();
            Console.WriteLine("How dare you, that QUACK! wishes he was as talented as i was.");
            Console.WriteLine("1) You'll never be as good as good Bugs, \n2) Calm down daffy it was a joke you're amazing.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("That's it put up your dukes bub.");
                    Console.WriteLine("1) Fight Daffy. 2) Walk away.");
                    int Choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Daffy beats you up, he's actually a pretty good fighter, you leave in defeat.");
                        Console.ReadLine();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Daffy chases you down and beats you up anyways.");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("It better be a joke.");
                    Console.WriteLine("It gets awkward after that, you soon leave.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("We can't go that way.");
                    Console.ReadLine();
                    Get_Mad();
                    break;
            }
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Park()
        {
            Console.Clear();
            Console.WriteLine("I love the park, lets go.");
            Console.WriteLine("you arrive at the park.");
            Console.WriteLine("1) Feed the ducks \n2) Go on a hike.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You cram food down Daffys throut and casue him to choke to death...");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You and Daffy begin to hike up a huge hill.");
                    Console.WriteLine("You encounter a mountain lion.");
                    Console.WriteLine("1) Dont make sudden movements and remain calm.\n 2) Find a weapon.");
                    Console.WriteLine("Daffy panics and begins to run. This causes the lion to case Daffy giving you time to get away.");
                    Console.WriteLine("You never see Daffy again.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    Console.ReadLine();
                    Park();
                    break;
            }
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Shop()
        {
            Console.Clear();
            Console.WriteLine("I don't hve money leave me alone...");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }
    }
}

