using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmThing
{
    class Bugs_Bunny
    {
        public void bugs_bunny()
        {
            Greeting();
        }
       
        private static void Greeting()
        {
            Console.WriteLine("Hello my name is Bugs Bunny, what would you like to do?");
            Console.WriteLine("1) Eat Carrots. \n2) Dig tunnels. \n3) Do nothing.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Eat();
                    break;
                case 2:
                    Dig();
                    break;
                case 3:
                    Nothing();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    Greeting();
                    break;
            }
        }

      
        private static void Nothing()
        {
            Console.Clear();
            Console.WriteLine("You and bugs do nothing together.");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Dig()
        {
            Console.Clear();
            Console.WriteLine("Bugs begins to dig");
            Console.WriteLine("You quickly realize that you're not a cartoon character and bugs leaves you.");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Eat()
        {
            Console.Clear();
            Console.WriteLine("Bugs gives you a fake carrot and runs away, yelling these carrots belong to me.)");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }
    }
}
