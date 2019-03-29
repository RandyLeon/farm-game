using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmThing
{
    public class Animals
    {
        public void All_Animals()
        {
            Console.WriteLine("Who in the farm would you like to meet, 1 2 3 or 4???");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                new Snowball().snowball();
                    break;
                case 2:
                new Daffy_Duck().daffy_duck();
                    break;
                case 3:
                new Roger_Rabbit().roger_rabbit();
                    break;
                case 4:
                new Bugs_Bunny().bugs_bunny();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    Console.Clear();
                    All_Animals();
                    break;

            }
        }
    }
}
