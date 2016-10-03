using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Restaurant 
    {
        private bool stove = true;
        private int howManyStoves;
        private bool tables;
        private int howManyTables;
        private bool cashRegister;

        public Restaurant(int cook, int seats)
        {
            HowManyStoves = cook;
            HowManyTables = seats;
        }

        public Restaurant()
        {

        }

        public bool Stove
        {
            get
            {
                return stove;
            }
        
        }

        public int HowManyStoves
        {
            get
            {
                return howManyStoves;
            }

            set
            {
                if (value < 1)
                {
                    howManyStoves = 1;
                }
                else
                {
                    howManyStoves = value;
                }
            }
        }

        public bool Tables
        {
            get
            {
                return tables;
            }

            set
            {
                tables = value;
            }
        }

        public int HowManyTables
        {
            get
            {
                return howManyTables;
            }

            set
            {
                howManyTables = value;
            }
        }

        public bool CashRegister
        {
            get
            {
                return cashRegister;
            }

            set
            {
                cashRegister = value;
            }
        }
    }
}
