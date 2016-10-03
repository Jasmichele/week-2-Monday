using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class House
    {
        private bool hasDoors = true;
        private int howManyDoors;
        private bool hasWindows;
        private int howManyWindows;
        private int howManyRooms;

        public House()
        {
        }

        public House(int doors, int rooms)
        {
            HowManyDoors = doors;
            HowManyRooms = rooms;
        }

        public bool HasDoors
        {
            get
            {
                return hasDoors;
            }
        }

        public int HowManyDoors
        {
            get
            {
                return howManyDoors;
            }

            set
            {
                if (value < 1)
                {
                    howManyDoors = 1;
                }
                else
                {
                    howManyDoors = value;
                }
            }
        }

        public bool HasWindows
        {
            get
            {
                return hasWindows;
            }

            set
            {
                hasWindows = value;
            }
        }

        public int HowManyWindows
        {
            get
            {
                return howManyWindows;
            }

            set
            {
                howManyWindows = value;
            }
        }

        public int HowManyRooms
        {
            get
            {
                return howManyRooms;
            }

            set
            {
                howManyRooms = value;
            }
        }
    }
}
