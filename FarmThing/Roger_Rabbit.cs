using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmThing
{
    class Roger_Rabbit
    {
        public void roger_rabbit()
        {
            Greeting();
        }

        private static void Greeting()
        {
            Console.WriteLine("Hello my name is Roger Rabbit, what would you like to do?");
            Console.WriteLine("1) Watch Jessica Rabbits show. \n2) Ask why Jessica is married to a rabbit. \n3) Go out to eat.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Show();
                    break;
                case 2:
                    Ask_About_Wife();
                    break;
                case 3:
                    Go_Eat();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    Greeting();
                    break;
            }
        }

        private static void Go_Eat()
        {
            Console.Clear();
            Console.WriteLine("I dont eat with strangers, bye.");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Ask_About_Wife()
        {
            Console.Clear();
            Console.WriteLine("Because she LOVES ME!!");
            Console.WriteLine("1) Ok geez calm down \n2) How could anybody love you.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Roger continues to spazz out for hours, you leave.");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("How could you say that, Roger goes into a depression and jessica hates you. You leave.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    Console.ReadLine();
                    Ask_About_Wife();
                    break;
            }
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Show()
        {
            Console.Clear();
            Console.WriteLine("You watch the show, it was great.)");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }
    }
}
