using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    class Cow : Animal
    {
        
        public override void MakeNoise(string noise, string animalType)
        {
            Console.WriteLine(animalType + " goes " + noise);
            //form.AppendText(animalType + " goes " + noise + "\r\n");
            
        }
        public override void FeedMe(string animalType, float food)
        {
            Console.WriteLine("Fed The " + animalType + " " + food + " Snax");
            //form.AppendText("Fed The " + animalType + food + " Snax" + "\r\n");
        }
    }
}
