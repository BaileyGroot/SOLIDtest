using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDtest
{
    public class Participant
    {

        // List of horses
        public List<Horse> horses = new List<Horse>();

        public void listHorse()
        {
            horses.Add(new Horse("HorseNumb1", 1, 2321, "red", 3000));
            horses.Add(new Horse("HorseNumb2", 2, 2255, "red", 3000));
            horses.Add(new Horse("HorseNumb3", 3, 2237, "red", 3000));
            horses.Add(new Horse("HorseNumb4", 4, 2256, "red", 3000));
            horses.Add(new Horse("HorseNumb5", 5, 2215, "red", 3000));
            horses.Add(new Horse("HorseNumb6", 6, 2645, "red", 3000));
            horses.Add(new Horse("HorseNumb7", 7, 2162, "red", 3000));
            horses.Add(new Horse("HorseNumb8", 8, 2781, "red", 3000));
        }



    }
}
