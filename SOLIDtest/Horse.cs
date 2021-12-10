using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDtest
{
    // Inheritance from Raceprogram
    public class Horse : RaceProgram
    {
        // Properties
        private string name;
        private int pnumber;
        private int hnumber;
        private string color;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Pnumber
        {
            get
            {
                return pnumber;
            }
            private set
            {
                pnumber = value;
            }
        }
        public int Hnumber
        {
            get
            {
                return hnumber;
            }
            private set
            {
                hnumber = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        // Consturctor
        public Horse(string name, int pnumber, int hnumber, string color, int sprinterdistance) : base(sprinterdistance)
        {
            this.name = name;
            this.pnumber = pnumber;
            this.hnumber = hnumber;
            this.color = color;
        }

    }
}
