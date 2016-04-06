using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class tamagotchi
    {
        private string Name;
        private string Gender;
        private int Fullness;
        private int Happiness;


        public tamagotchi(string name, string gender, int fullness, int happiness)
        {
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
        }

        public string getName()
        {
            return Name;
        }

        public string getGender()
        {
            return Gender;
        }

        public int getFullness()
        {
            return Fullness;
        }

        public int getHappiness()
        {
            return Happiness;
        }

        public void pet()
        {
            Random rnd = new Random();
            int CoolNumberH = rnd.Next(10); //chooses a random number from 0-10 and stores it in the new varible
            Console.WriteLine(CoolNumberH); //tells user the random number it chose
            Happiness += CoolNumberH; //increments the happiness by the random number it chose
        }

        public void feed()
        {
            Random rnd = new Random();
            int CoolNumberF = rnd.Next(10);
            Console.WriteLine(CoolNumberF);
            Fullness += CoolNumberF;
        }

        public void dostuff()
        {
            Random rnd = new Random();
            Fullness -= rnd.Next(5);
            Happiness -= rnd.Next(5);
        }
    }
}
