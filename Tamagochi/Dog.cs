using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public class Dog : pet
    {
        public override string WhoamI()
        {
            return "Dog";
        }
        //public int Hunger { get; private set; } = 30; equal to underneath
        private int hunger = 50;
        public int Hunger
        {
         get
            {
                return hunger; 
            }
            set 
            {
                hunger = value;

                if (!Isalive())
                {
                    throw new DeadPetException();
                }
            }
        }
        public int Boredom { get; private set; } = 50;
        public void Feed()
        {
            Hunger -= 30;
            Boredom += 15;
            Console.WriteLine("Feeding");
        }
        public void Play()
        {
            Hunger += 30;
            Boredom -= 25;
            Console.WriteLine("Playing");
        }
        public void Chill()
        {
            Hunger += 10;
            Boredom += 10;
            Console.WriteLine("Chillin...");
        }
        private Random random = new Random();
        public int Do()
        {
            var toss = random.Next(1, 20);

            if (toss < 10)
            { Chill(); }

            else if (toss < 16)
            { Play(); }

            else
            { Feed(); }
            return toss;
        }

        public bool Isalive()
        {
            if (Hunger > 100 || Hunger < 0)
            {
                return false;
            }
            return true;
        }

    }

}
