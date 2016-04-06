using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            tamagotchi t1 = new tamagotchi("Luna", "M", 100, 100);
            Console.WriteLine("Name: {0}, Gender: {1}, Fullness: {2}, Happiness: {3}", t1.getName(), t1.getGender(), t1.getFullness(), t1.getHappiness());
            //Console.ReadLine();
            while (t1.getHappiness() > 0 && t1.getFullness() > 0)
            {
                Console.WriteLine("Would you like to pet or feed {0}?", t1.getName() );
                string input = Console.ReadLine();

                if (input == "pet") {
                    t1.pet();
                }
                else if (input == "feed") {
                    t1.feed();
                }
                else {
                    Console.WriteLine("Please only use 'pet' or 'feed'.");

                }
                t1.dostuff();
                Console.WriteLine("Name: {0}, Gender: {1}, Fullness: {2}, Happiness: {3}", t1.getName(), t1.getGender(), t1.getFullness(), t1.getHappiness());
            }
        }
    }
}
