using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmThing
{
    class Snowball
    {
        public void snowball()
        {
            Greeting();
        }

        private static void Greeting()
        {
            Console.WriteLine("Hello my name is Snowball, what would you like to do?");
            Console.WriteLine("1) Make SnowBall speak \n2) feed snowball \n3) take snowball for a walk or \n4) ask him about his testicles.");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Speak();
                    break;
                case 2:
                    Feed();
                    break;
                case 3:
                    Walk();
                    break;
                case 4:
                    Testicles();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    Greeting();
                    break;
            }
        }

        private static void Testicles()
        {
            Console.Clear();
            Console.WriteLine("DO YOU KNOW WHAT HAPPENED TO MY TESTICLES!!!!!!");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "yes":
                    Console.WriteLine("TELL ME!!! TELL ME NOW!!!");
                    string Choice = Console.ReadLine();
                    if (Choice == "yes")
                    {
                        Console.WriteLine("Thank you for telling me, i must go know summer must pay for waht she has done to me.");
                        Console.ReadLine();
                    }
                    else if (Choice =="no")
                    {
                        Console.WriteLine("Very well then, just know you have made an enemy here today and I will be seeing you again.");
                        Console.ReadLine();
                    }
                    break;
                case "no":
                    Console.WriteLine("I have been trying to find out that answer my whole life, my old family wouldn't tell me. I sorry I must leave to continue my searching for my answer.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That is not an option.");
                    Console.ReadLine();
                    Testicles();
                    break;

            }
            Console.Clear();
                  new Animals().All_Animals();
        }

        private static void Walk()
        {
            Console.Clear();
            Console.WriteLine("Oh how fun, i do enjoy a good walk.");
            Console.WriteLine("Where do you want to go to.\n1) Gotham, \n2) Metropolis.");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("To Gotham we go");
                    Console.WriteLine("You have entered Gotham and you find a man laying on the sidewalk. \n1) Ask him if he is ok, \n2) Walk past him.");
                    int Choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("The man gets up and takes Snowball from you. 1) cry, 2) scream SNOWBAAAAALLLL!!!!!");
                        int CHOICE = int.Parse(Console.ReadLine());
                        switch (CHOICE)
                        {
                            case 1:
                                Console.WriteLine("You cry for hours and then realize Snowball is gone and you return to the farm.");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("A dark figure falls from the sky and lands on the man then vanishes. Snowball runs back to you and you both run back to the farm, where Snowball then falls asleep.");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("That's not an option.");
                                Console.ReadLine();
                                Walk();
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("To Metropolis we go");
                    Console.WriteLine("You walk to to Metropolis, it was a far walk. You and Snowball are very tired and head back to the farm were you both go into hibernation.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("We can't go that way.");
                    Walk();
                    break;
            }
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Feed()
        {
            Console.Clear();
            Console.WriteLine("YES, IM STARVING!!");
            Console.WriteLine("1) Feed Snowball \n2) Say nevermind.");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("You feed Snowball chocolate and he dies....");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Snowball leaves to find a human that's not useless.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    Console.ReadLine();
                    Feed();
                    break;
            }
            Console.Clear();
            new Animals().All_Animals();
        }

        private static void Speak()
        {
            Console.WriteLine("Who do you think I am human, I am Snowball I do not take orders from HUMANS! (storms off.)");
            Console.ReadLine();
            Console.Clear();
            new Animals().All_Animals();
        }
    }
}
