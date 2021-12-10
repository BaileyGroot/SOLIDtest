using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDtest
{
    public class RaceProgram
    {
        // Properties
        private int sprinterdistance;
        private int stayerdistance;
        private int normaldistance;

        public int Sprinterdistance
        {
            get
            {
                return sprinterdistance;
            }
            set
            {
                sprinterdistance = value;
            }
        }
        public int Stayerdistance
        {
            get
            {
                return stayerdistance;
            }
            set
            {
                stayerdistance = value;
            }
        }
        public int Normaldistance
        {
            get
            {
                return normaldistance;
            }
            set
            {
                normaldistance = value;
            }
        }

        // Constructor
        public RaceProgram(int sprinterdistance)
        {
            this.sprinterdistance = sprinterdistance;
        }
    }
}
