using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    class Doge : Animal
    {
        public override void MakeNoise(string noise, string animalType)
        {
            Console.WriteLine(animalType + " goes " + noise);
        }
    }
}
