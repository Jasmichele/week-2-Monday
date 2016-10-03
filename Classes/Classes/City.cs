using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class City
    {
        private bool ppl = true;
        private int howManyPpl;
        private bool lake;
        private int howManyLakes;
        private bool police;

        public City(int people)
        {
            HowManyPpl = people;
        }

        public bool Ppl
        {
            get
            {
                return ppl;
            }
          
        }

        public int HowManyPpl
        {
            get
            {
                return howManyPpl;
            }

            set
            {
               if ( value < 100 )
                {
                    howManyPpl = 100;
                }
               else
                {
                    howManyPpl = value;
                }
            }
        }

        public bool Lake
        {
            get
            {
                return lake;
            }

            set
            {
                lake = value;
            }
        }

        public int HowManyLakes
        {
            get
            {
                return howManyLakes;
            }

            set
            {
                howManyLakes = value;
            }
        }

        public bool Police
        {
            get
            {
                return police;
            }

            set
            {
                police = value;
            }
        }
    }
}
