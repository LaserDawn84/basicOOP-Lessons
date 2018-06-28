using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    
    class Farm
    {
        Cow cow = new Cow();
        Doge doge = new Doge();
        public void LoadFarm()
        {
            cow.MakeNoise("Moo!", "Cow");
            doge.MakeNoise("Bawk!", "Doge");

            
        }
        public void FeedAnimals()
        {
            cow.FeedMe("Cow", 50f);
            doge.FeedMe("Doge", 100f);
        }
    }
}
