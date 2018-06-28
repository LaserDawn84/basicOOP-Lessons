using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    public class Animal
    {
        protected float hunger = 100f;
        public Animal()
        {
            Console.WriteLine("New Animal");
        }
        public virtual void MakeNoise(String noise, String animalType)
        {
            Console.WriteLine(animalType + " goes " + noise);
        }
        public virtual void FeedMe(String animalType, float food)
        {
            Console.WriteLine("Fed The " + animalType + food + " Snax");
        }
    }
}
