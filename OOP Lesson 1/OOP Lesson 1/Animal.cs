using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("New Animal");
        }
        public virtual void MakeNoise(String noise, String animalType)
        {
            Console.WriteLine(animalType + " goes " + noise);
        }
    }
}
